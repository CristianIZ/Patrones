using Memento;
using System.Text;

namespace User
{
    public partial class Form1 : Form
    {
        public static CareTaker caretaker = new CareTaker();
        public int Count { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Count = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var p = new Memento.User();
            
            p.Nombre = "Pepe";
            caretaker.Add(p.Save());

            p.Nombre = "Pepe1";
            caretaker.Add(p.Save());

            p.Nombre = "Pepe2";
            caretaker.Add(p.Save());

            Memento.Memento m1 = caretaker.GetMemento(0);
            Console.WriteLine("Viendo memento 1: " + m1.State);
            Console.WriteLine("Viendo memento 2: " + caretaker.GetMemento(1).State);
            Console.WriteLine("Viendo memento 3: " + caretaker.GetMemento(2).State);
            
            p.Restore(m1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new Memento.User();

            user.Nombre = $"User {Count}: Estado {1}";
            caretaker.Add(user.Save());

            Count = Count + 1;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            txtReport.Clear();

            var sb = new StringBuilder();

            foreach (var item in caretaker.GetMementos())
            {
                sb.AppendLine(item.State);
            }

            txtReport.Text = sb.ToString();
        }
    }
}