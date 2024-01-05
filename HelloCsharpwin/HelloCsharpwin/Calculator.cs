namespace HelloCsharpwin
{

    /*enum = ������ ������ Ÿ�� -> ������ �ϰ� ����� �� �ִ�.
    public enum Season {Spring, Summer, Fall, Winter};
    Season currentSeason = Season.Spring;
    */

    public enum Operators {Add, Sub, Multi, Div}

    public partial class Calculator : Form
    {
        public double Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();

        }

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
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


        private void OptBtn_Click(object sender, EventArgs e)
        {
            if (isNewNum == false)
            {
                double num = double.Parse(NumScreen.Text);

                if (Opt == Operators.Add)
                    Result += num;
                else if (Opt == Operators.Sub)
                    Result -= num;
                else if (Opt == Operators.Multi)
                {
                    Result *= num;
                }
                else if (Opt == Operators.Div && num != 0)
                {
                    Result /= num;
                }

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;

            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "x")
                Opt = Operators.Multi;
            else if (optButton.Text == "��")
                Opt = Operators.Div;
        }

        //Clear(��ü ����) 
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }

        //Back(�ϳ��� ����)
        //����ó�� : ���� ���̰� 1���� ������ 0���� ����
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text.Length > 1)
                NumScreen.Text = NumScreen.Text.Substring(0, NumScreen.Text.Length - 1);
            else
                NumScreen.Text = "0";
            

        }

        //+/- ���� ��� ��ȯ
        private void switchPM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(NumScreen.Text, out double currentNumber))
            {
                currentNumber *= -1;
                NumScreen.Text = currentNumber.ToString();
                Result = currentNumber; // ���� ����� Result�� ��ȣ ����
            }
            else
            {
                NumScreen.Text = "0";
            }
        }


    }
}
