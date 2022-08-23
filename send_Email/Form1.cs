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
        cMail mail;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucSend.strTitle = "받는이";
            ucRef.strTitle = "참조";
            ucHide.strTitle = "숨김";

            mail = new cMail("aaa000@naver.com");   //EMail주소 입력

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            List<string> ListSend = ucSend.ListAdress;
            List<string> ListRef = ucRef.ListAdress;
            List<string> ListHide = ucHide.ListAdress;

            string result = mail.SendEMail(tboxSubject.Text,tboxBody.Text,ListSend,ListRef,ListHide);
            MessageBox.Show(result);
        }


    }
}
