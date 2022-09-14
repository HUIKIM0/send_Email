using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace send_Email
{
    class cMail
    {
        private string _sendID = cSecretInfo._sendID;  //EMail account ID
        private string _sendPassword = cSecretInfo._sendPassword;  //EMail account Password

        private string _sendAddress =null;  // EMail Address
        private string _sendNic = null;  // EMail Nicname


        public cMail(string sendMail,string sendNic)  
        {
            _sendAddress = sendMail;  // aaa000@naver.com
            _sendNic = sendNic;
        }


        //메일제목,메일내용,받는이,참조,숨김
        public string SendEMail(string strSubjcet, string strBody, List<string> LtoSend,List<string> LtoRef,List<string> LtoHide)
        {
            SmtpClient smtp = null;
            MailMessage message = null;

            try
            {
                /* Naver 계정 SMTP 설정 */
                smtp = new SmtpClient();
                smtp.Host = "smtp.naver.com";  //"smtp.gamil.com";
                smtp.UseDefaultCredentials = false;
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(_sendID,_sendPassword);



                /* 메세지 전송*/
                message = new MailMessage(); //from address를 따로 넣기? 어떻게?
                message.From = new MailAddress(_sendAddress,_sendNic, System.Text.Encoding.UTF8);

                if (LtoSend.Count > 0)
                {
                    foreach (var oitem in LtoSend)
                    {
                        message.To.Add(new MailAddress(oitem)); // 정규식 체크는 ucAddress.EmailFormatCheck 에서 해줌
                    }
                }

                if(LtoRef.Count > 0)
                {
                    foreach (var oitem in LtoRef)
                    {
                        message.CC.Add(new MailAddress(oitem));
                    }
                }

                if (LtoHide.Count > 0)
                {
                    foreach (var oitem in LtoHide)
                    {
                        message.Bcc.Add(new MailAddress(oitem));
                    }
                }

                message.Subject = strSubjcet;
                message.SubjectEncoding = System.Text.Encoding.UTF8;  
                message.Body = strBody;
                message.BodyEncoding = System.Text.Encoding.UTF8;  

          
                smtp.Send(message);
                return null;   //전송 성공이면 null 

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                if (smtp != null) smtp.Dispose();
                if (message != null) message.Dispose();
            }
        }

    }
}
