namespace T8_MVMR_1157722
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Binario = "";
            int Numero = int.Parse(NB10.Text);

            while (Numero > 0)
                {

                Binario = (Numero % 2) + Binario;
                Numero = (int) Numero / 2;
            }

            Resultado.Text = Binario;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Hexa = "";
            int Numero = int.Parse(NB10.Text);

            while (Numero > 0)
            {

                switch (Numero % 16)
                {
                    case 10: Hexa = "A" + Hexa; break;
                    case 11: Hexa = "B" + Hexa; break;
                    case 12: Hexa = "C" + Hexa; break;
                    case 13: Hexa = "D" + Hexa; break;
                    case 14: Hexa = "E" + Hexa; break;
                    case 15: Hexa = "F" + Hexa; break;
                    default:
                        Hexa = (Numero % 16) + Hexa; break;
                                        
                }
               
                Numero = (int)Numero / 16;
            }

            Resultado.Text = Hexa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NB10.Text = "";
        }
    }
}