using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWallApp
{
    public partial class MessageWall : Form
    {
        BindingList<string> messages = new BindingList<string>();
        public MessageWall()
        {
            InitializeComponent();
            ShowMessage();
        }

        public void ShowMessage()
        {
            MessageListBox.DataSource = messages;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
           if (messageInput.Text == string.Empty)
            {
                MessageBox.Show("Please type some message, then send message","Blank message send",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           else
            {
                messages.Add(messageInput.Text);
            }
           messageInput.Text = string.Empty;
        }
    }
}
