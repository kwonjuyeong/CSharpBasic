namespace HelloCsharpwin
{

    /*enum = 열거형 데이터 타입 -> 선언을 하고 사용할 수 있다.
    public enum Season {Spring, Summer, Fall, Winter};
    Season currentSeason = Season.Spring;
    */

    public enum Operators {Add, Sub, Multi, Div}

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;



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
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            SetNum("3");
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            SetNum("4");
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            SetNum("5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            SetNum("6");

        }

        private void Num7_Click(object sender, EventArgs e)
        {
            SetNum("7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            SetNum("8");
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            SetNum("9");
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            SetNum("0");
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
            

            if(Opt == Operators.Add)
            {
                Result = Result + num;
            }
            else if(Opt == Operators.Sub)
            {
                Result = Result - num;
            }
            else if(Opt == Operators.Multi)
            {
                Result = Result * num;
            }
            

            NumScreen.Text = Result.ToString();
            isNewNum = true;

        }

    


    }
}
