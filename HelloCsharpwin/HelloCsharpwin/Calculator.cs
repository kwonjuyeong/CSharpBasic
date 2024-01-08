using System.Xml.Linq;

namespace HelloCsharpwin
{

    /*enum = 열거형 데이터 타입 -> 선언을 하고 사용할 수 있다.
    public enum Season {Spring, Summer, Fall, Winter};
    Season currentSeason = Season.Spring;
    */

    public enum Operators {Nothing, Add, Sub, Multi, Div, Shift8}

    public partial class Calculator : Form
    {
        public double Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Nothing;

        public Calculator()
        {
            InitializeComponent();

        }

        //숫자 버튼 클릭 이벤트
        private void NumButton_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }


        //숫자 입력 처리 메소드
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
                NumScreen.Text += num;
            }

        }


        //사칙 연산 처리
        private void OptBtn_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("입력 발생!");

            double num = double.Parse(NumScreen.Text);

            if (Opt != Operators.Nothing && !isNewNum)
            {
                System.Diagnostics.Debug.WriteLine("입력 발생2!");
                if (Opt == Operators.Add)
                    Result += num;
                else if (Opt == Operators.Sub)
                    Result -= num;
                else if (Opt == Operators.Multi)
                    Result *= num;
                else if (Opt == Operators.Div && num != 0)
                    Result /= num;
            }
            else
            {
                Result = num;
            }

            NumScreen.Text = Result.ToString();
            isNewNum = true;

            Button optButton = (Button)sender;
            System.Diagnostics.Debug.WriteLine(optButton.Text);

            Console.WriteLine(optButton.Text);

            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "x" || optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "÷")
                Opt = Operators.Div;
            else
                Opt = Operators.Nothing;
                equalsBtn.Focus();


        }

        //Clear(초기화)
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Nothing;

            NumScreen.Text = Result.ToString();
        }

        //Back(숫자 지움 처리)
        //예외처리 : 글자 길이가 1보다 작으면 0으로 변경
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text.Length > 1)
                NumScreen.Text = NumScreen.Text.Substring(0, NumScreen.Text.Length - 1);
            else
                NumScreen.Text = "0";

        }

        // 음수/양수 변환 처리
        private void switchPM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(NumScreen.Text, out double currentNumber))
            {
                currentNumber *= -1;
                NumScreen.Text = currentNumber.ToString();
                Result = currentNumber; // 연산 결과인 Result도 부호 변경
            }
            else
            {
                NumScreen.Text = "0";
            }
        }

        //역수 처리
        private void OneOverXBtn_Click(object sender, EventArgs e)
        {
            if (!isNewNum)
            {
                double inputNumber = Double.Parse(NumScreen.Text);
                double inverse = 1.0 / inputNumber;
                NumScreen.Text = inverse.ToString();
                isNewNum = true;
            }
        }


        // 소수점 처리
        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text.Contains("."))
                return;
            else
                NumScreen.Text += ".";
        }

        //제곱 처리
        private void SqrBtn_Click(object sender, EventArgs e)
        {
            double num = double.Parse(NumScreen.Text);
            double result = num * num;
            NumScreen.Text = result.ToString();
            Result = result;

        }

        //제곱근 계산
        private void rootBtn_Click(object sender, EventArgs e)
        {
            double num = double.Parse(NumScreen.Text);
            double result = Math.Sqrt(num); // 제곱근 계산
            NumScreen.Text = result.ToString();
            Result = result;

        }

        // % (퍼센트) 연산
        private void PercentBtn_Click(object sender, EventArgs e)
        {
            if (!isNewNum)
            {
                double num = double.Parse(NumScreen.Text);
                double percent = num / 100.0;
                double result = Result + (Result * percent); // 이전 결과에 퍼센트를 더함
                NumScreen.Text = result.ToString();
                isNewNum = true;
            }
        }

        // CE(현재 입력된 숫자 삭제)
        private void CEBtn_Click(object sender, EventArgs e)
        {
            NumScreen.Text = "0";
            isNewNum = true;
        }



        //키보드 입력 로직 구현
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {

            System.Diagnostics.Debug.WriteLine(e.KeyCode);

            
            if (Control.ModifierKeys == Keys.Shift && e.KeyCode == Keys.D8) //수정된 조건
            {
                  OptBtn_Click(multiplyBtn, e);
            }
            else
            {

                if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                {
                    SetNum((e.KeyCode - Keys.D0).ToString());
                }
                else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
                {
                    SetNum((e.KeyCode - Keys.NumPad0).ToString());
                }
                else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                {
                    OptBtn_Click(plusBtn, e);
                }
                else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                {
                    OptBtn_Click(minusBtn, e);
                }
                else if (e.KeyCode == Keys.Multiply)
                {
                    OptBtn_Click(multiplyBtn, e);
                }
                else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
                {
                    OptBtn_Click(divBtn, e);
                }
                else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
                {
                    dotBtn_Click(dotBtn, e);
                }
                else if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
                {
                    OptBtn_Click(equalsBtn, e);
                }
                else if (e.KeyCode == Keys.Back)
                {
                    backBtn_Click(backBtn, e);
                }

             }

            
        }

    }
}
