using static System.Net.Mime.MediaTypeNames;

namespace Atividade_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ideal=0;
            double altura = double.Parse(textBox1.Text);
            string sexo = textBox2.Text;

            if (sexo == "masculino" || sexo == "M" || sexo == "Masculino")
            {
                ideal = (72.7 * altura)-58;
                label4.Text = "O peso ideal é " + ideal;
            } else if (sexo == "feminino"|| sexo =="F"|| sexo == "Feminino")
            {
                ideal = (62.1 * altura)-44.7;
                label4.Text = Convert.ToString(ideal);
            }
            else
            {
                label4.Text = "Digite 'feminino' ou 'masculino' para continuar";
            }
        }
    }
}
