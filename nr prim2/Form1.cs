namespace nr_prim2
{
    public partial class Form1 : Form
    {
        private object textbox;
        private object textBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("S-a introdus " + numberTextBox.Text);
            int result = 0;


            bool isNumber = Int32.TryParse(textbox.Text, out result);
            if (isNumber)
            {
                bool isPrime = true;
                for (int i = 2; i <= result / 2; i++)
                {
                    if (result % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
            else
            {
                this.BackColor = Color.Yellow;
                MessageBox.Show("S-a introdus un text");

            }


        }
    }
}
