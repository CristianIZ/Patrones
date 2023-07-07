using Observer;
using System.Text;

namespace User1
{
    public partial class Form1 : Form, IChatNotifier
    {
        public string UserName { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChatHelper.user.Attach(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatHelper.user.Detach(this);
        }

        private void bntSend_Click(object sender, EventArgs e)
        {
            ChatHelper.user.Text = $"{UserName}: {txtWrite.Text}";
            ChatHelper.user.Notify();
        }

        public void Update(string text)
        {
            var sb = new StringBuilder();

            sb.Append(txtChat.Text);
            sb.AppendLine(text);

            txtChat.Text = sb.ToString();
        }
    }
}