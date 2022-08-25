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

        string _strDBPath = Application.StartupPath + @"\EMailSendInfo.mdb";  

        cMail mail;
        cDBConnect _db;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucSend.strTitle = "받는이";
            ucRef.strTitle = "참조";
            ucHide.strTitle = "숨김";

            mail = new cMail("aa@naver.com","히히");   //EMail주소 입력

        }

        // Mail Send (DB 저장)
        // Mail 받을 사람들, Mail 내용 등.. DB에 저장
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
        }

        // DB 조회
        private void btnDBSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
