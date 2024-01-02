namespace HelloCsharpwin
{
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;



        public Calculator()
        {
            InitializeComponent();
        }


        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;

        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }
        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;

        }

        private void NumButton1_Click(object sender, EventArgs e)
        {

            SetNum("1");
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        public void SetNum(string num)
        {

            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {
                NumScreen.Text = NumScreen.Text + num;

            }

        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result = Result + num;

            NumScreen.Text = Result.ToString();
            isNewNum = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
