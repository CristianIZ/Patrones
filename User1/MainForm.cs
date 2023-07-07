using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User1
{
    public partial class MainForm : Form
    {
        public int UserCount { get; set; }
        public MainForm()
        {
            InitializeComponent();
            UserCount = 1;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var chat1 = new Form1();
            chat1.UserName = GetUserName();
            chat1.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var chat1 = new Form1();
            chat1.UserName = GetUserName();
            chat1.Show();

            var chat2 = new Form1();
            chat2.UserName = GetUserName();
            chat2.Show();

            this.SendToBack();
        }

        public string GetUserName()
        {
            var result = $"Usuario: {UserCount}";
            UserCount = UserCount + 1;
            return result;
        }
    }
}
