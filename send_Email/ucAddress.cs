using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace send_Email
{
    public partial class ucAddress : UserControl
    {
        /// <summary>
        /// lboxAAdress.Items에 담긴 메일주소(받는이,참조,숨김)를 List<string>에 담기
        /// 담아놓은 값들을 이용하여 message 보낼거임
        /// </summary>
        public List<string> ListAddress
        {

            get => lboxAddress.Items.Cast<string>().ToList();
        }

        public string strTitle
        {
            set => gboxMain.Text = value;
        }

        public ucAddress()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button 클릭하면 ListBox에 입력한 메일주소 추가됨 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (EmailFormatCheck())
            {
                if(ListAddress != null && ListAddress.Contains(tboxAddress.Text))  
                {
                    MessageBox.Show("이미 등록되어 있는 메일주소 입니다.");
                    return;  //기존에 있으면 빠꾸
                }

                lboxAddress.Items.Add(tboxAddress.Text);
                tboxAddress.Text = "";
            }
            else
            {
                MessageBox.Show("입력 값이 메일주소 형식이 아닙니다.");
            }
        }


        private void lboxAddress_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int iRow = lboxAddress.SelectedIndex;
            if(iRow >=0 )
            {
                lboxAddress.Items.RemoveAt(iRow);
            }
        }


        /// <summary>
        /// Mail 주소 형식이 맞는지 정규식Regex 체크
        /// </summary>
        /// <returns></returns>
        private bool EmailFormatCheck()
        {
            string regExp = @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?";  // 이메일 정규식 체크
            Regex regex = new Regex(regExp);

            if (regex.IsMatch(tboxAddress.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
