using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace send_Email
{
    public partial class Form1 : Form
    {
        enum enCol
        {
            ID,
            작성일시,
            받는이,
            참조,
            숨김,
            제목,
            내용,
            전송여부,
            전송일시,
            전송결과,
            미전송사유,
        }

        string _strDBProgramPath = Application.StartupPath + @"\EMailSendInfo.mdb";  

        cMail mail;
        cDBConnect _db;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new cDBConnect(_strDBProgramPath);

            ucSend.strTitle = "받는이";
            ucRef.strTitle = "참조";
            ucHide.strTitle = "숨김";

            mail = new cMail("aa@naver.com","히히");   //EMail주소 입력
            fTimerStart();  // Form_Load시 Timer시작
        }

        // Mail Send (DB 저장)
        // Mail 받을 사람들, Mail 내용 등.. !DB에 저장! 
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            #region List에 넣어진 mail들 여기에 가져와서 mail send work Function에!
            //List<string> ListSend = ucSend.ListAdress;
            //List<string> ListRef = ucRef.ListAdress;
            //List<string> ListHide = ucHide.ListAdress;

            //string result = mail.SendEMail(tboxSubject.Text,tboxBody.Text,ListSend,ListRef,ListHide);
            //MessageBox.Show(result);
            #endregion

            DateTime dt = DateTime.Now;

            // DB 주소등록 type이 string이라서 문자열로 연결
            string strLSend = string.Join(",", ucSend.ListAdress);
            string strLRef = string.Join(",", ucRef.ListAdress);
            string strLHide = string.Join(",", ucHide.ListAdress);

            if(string.IsNullOrEmpty(strLSend) || string.IsNullOrEmpty(tboxSubject.Text) || string.IsNullOrEmpty(tboxBody.Text))
            {
                MessageBox.Show("[제목,내용,받는이]는 필수로 입력해야 합니다.");
                return;
            }

            // MS DB Query...
            string Query = $@"INSERT INTO TB_MAIL_INFO 
                            ({enCol.작성일시}, {enCol.받는이}, {enCol.참조}, {enCol.숨김}, {enCol.제목}, {enCol.내용}, {enCol.전송여부}) 
                            VALUES (""{dt}"", ""{strLSend}"", ""{strLRef}"", ""{strLHide}"", ""{tboxSubject.Text}"", ""{tboxBody.Text}"", ""N"")";

            DataSet ds = _db.QueryExeCute(Query);

            fSelectEMailInfo();
        }

        // DB 조회
        private void btnDBSelect_Click(object sender, EventArgs e)
        {

        }


        #region DB 조회(Query)
        // DB Data 조회. 
        private void fSelectEMailInfo()
        {
            string Query = $@"select *
                              from TB_MAIL_INFO
                              order by ID desc";

            DataSet ds = _db.QueryExeCute(Query);

            dgEMailInfo.DataSource = ds.Tables[0];  
        }

        // DB Select 이후 전송 여부 Update
        private void fUpdateDataRead(int iID)
        {
            DateTime dt = DateTime.Now;

            string Query = $@"update TB_MAIL_INFO set 전송여부 =""Y"", 전송일시 =""{dt}"" WHERE ID = {iID}";

            DataSet ds = _db.QueryExeCute(Query);
        }

        // Mailing 전송 이후 결과 업뎃 필요!!!!

        #endregion


        #region DB에서 전송여부N -> Queue에 담기 -> Queue에 담긴것들 전송하고 전송여부Y로
        Timer _tmDBSelect = new Timer();  // 전송여부N인 최신Data가 DB에 있는지 Timer
        Timer _tmQueueMailing = new Timer(); //Queue에 Mailing할 값이 들어와있는지 Timer
        Queue<DataRow> _QMailData = new Queue<DataRow>(); 

        // Timer로 계속 상황 Check
        private void fTimerStart()
        {
            _tmDBSelect.Interval = 3000;
            _tmDBSelect.Tick += _tmDBSelect_Tick;
            _tmDBSelect.Start();

            _tmQueueMailing.Interval = 5000;
            _tmQueueMailing.Tick += _tmQueueMailing_Tick;
            _tmQueueMailing.Start();
        }

        // DB에 전송여부 N인 DataRow를 찾고 Queue에 넣는다 
        private void _tmDBSelect_Tick(object sender, EventArgs e)
        {
            string Query = $@"select *
                              from TB_MAIL_INFO
                              where 전송여부 =""N""
                              order by 작성일시";
            DataSet ds = _db.QueryExeCute(Query);

            foreach (DataRow oRow in ds.Tables[0].Rows)
            {
                _QMailData.Enqueue(oRow);

                int iID = (int)oRow[enCol.ID.ToString()]; //Queue에 넘어가게 된게 뭔지 보여줄려고
                lboxQueueData.Items.Add(iID);

                fUpdateDataRead(iID);
            }

            lblQueueCount.Text = _QMailData.Count.ToString();

            if(ds.Tables[0].Rows.Count > 0)
            {
                fSelectEMailInfo();
            }
        }


        // Queue에 있는 Data 하나씩 빼서 Mail 전송 필요!!!
        private void _tmQueueMailing_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
