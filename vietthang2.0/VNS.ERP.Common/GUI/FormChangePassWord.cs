using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using VNS.Windows.Forms;
using System.Windows.Forms;
using VNS.ERP.Common;
using VNS.Security;

namespace VNS.ERP.Common
{
    public partial class FormChangePassWord : FormBase
    {
        public FormChangePassWord()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string messageType, message;
            message = "Error Data";
            int Err;

           
                if (Crypto.EncryptString( txtOldPassWord.Text).Equals( Contexts.CurrentUser.Password))
                {
                    if (txtNewPassWord.Text == txtConfirm.Text)
                    {
                        messageType = "UPDATE";
                        Contexts.CurrentUser.Password = Crypto.EncryptString(txtNewPassWord.Text);
                        Err = new UserBLL().Update(Contexts.CurrentUser);
                    }
                    else
                    {
                        messageType = "Confirm";
                        MessageBox.Show(GetTextMessage(messageType, message));
                        return;
                    }
                }
                else
                {
                    messageType = "ControlValid";
                    MessageBox.Show(GetTextMessage(messageType, message));
                    return;
                }

            if (Err != 0)
                MessageBox.Show(GetTextMessage(messageType + Err.ToString(), message));
            else
            {
                MessageBox.Show(GetTextMessage(messageType , message));
                this.Close();
            }
            this.Cursor = Cursors.Default;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
        

       
    }
}