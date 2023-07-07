using AbstractFactory.Factory;
using System.Text;

namespace User2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var gbFatory = new GameBoyItemFactory();

            var gbQuestionBlock = gbFatory.CreateQuestionBlock();
            var gbCoin = gbFatory.CreateCoin();

            var dsFactory = new NintendoDsItemFactory();

            var dsQuestionBlock = dsFactory.CreateQuestionBlock();
            var dsCoin = dsFactory.CreateCoin();

            var sb = new StringBuilder();

            sb.AppendLine(gbQuestionBlock.Name);
            sb.AppendLine(gbCoin.Name);

            sb.AppendLine(dsQuestionBlock.Name);
            sb.AppendLine(dsCoin.Name);

            txtEntities.Text = sb.ToString();
        }
    }
}