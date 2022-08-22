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
    public partial class ucAddress : UserControl
    {
        public List<string> ListAdress
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ListBox에 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lboxAddress_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int iRow = lboxAddress.SelectedIndex;
            if(iRow >=0 )
            {
                lboxAddress.Items.RemoveAt(iRow);
            }
        }
    }
}
