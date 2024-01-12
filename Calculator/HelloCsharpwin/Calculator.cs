using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace HelloCsharpwin
{

    /*enum = 열거형 데이터 타입 -> 선언을 하고 사용할 수 있다.
    public enum Season {Spring, Summer, Fall, Winter};
    Season currentSeason = Season.Spring;
    */

    public enum Operators {None, Add, Sub, Multi, Div}

    public partial class Calculator : Form
    {
        public double Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.None;

        public Calculator()
        {
            InitializeComponent();

        }

        //숫자 버튼 클릭 이벤트
        private void NumButton_Click(object sender, EventArgs e)
        {

            Button numButton = (Button)sender;
            string num = numButton.Text;
            
            SetNum(num);
        }

        //숫자 입력 처리
        public void SetNum(string num)
        {
            System.Diagnostics.Debug.WriteLine(NumScreen);

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
            FormatNumber();
        }


        //사칙 연산 처리
        private void OptBtn_Click(object sender, EventArgs e)
        {

            double num = double.Parse(NumScreen.Text);

            if (Opt != Operators.None && !isNewNum)
            {
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

            NumScreen.Text = Result.ToString("#,##0.############");
            isNewNum = true;

            Button optButton = (Button)sender;
            string opt = optButton.Text;

            if (opt == "=") // =일때 조건 추가
            {
                SetExpression(num + " " + opt);
                isNewNum = true;
            }
            else
            {
                if(isNewNum) //isNewNum이 true이면 수식 라벨 초기화
                {
                    expressionScreen.Text = "";
                }
                SetExpression(" " + NumScreen.Text + " " + opt + " "); // "+" 버튼 클릭 시 수식 라벨에 연산자 추가

                if (opt == "+")
                    Opt = Operators.Add;
                else if (opt == "-")
                    Opt = Operators.Sub;
                else if (opt == "x" || opt == "*")
                    Opt = Operators.Multi;
                else if (opt == "÷")
                    Opt = Operators.Div;
                else
                    Opt = Operators.None;
                    equalsBtn.Focus();

            }
           
        }

        //Clear(초기화)
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Result = 0;
            Opt = Operators.None;
            isNewNum = true;
            NumScreen.Text = Result.ToString();
            expressionScreen.Text = "";

        }

        //Back(숫자 지움 처리)
        
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (NumScreen.Text.Length > 1)
                NumScreen.Text = NumScreen.Text.Substring(0, NumScreen.Text.Length - 1);
            else //예외처리 : 글자 길이가 1보다 작으면 0으로 변경
                NumScreen.Text = "0";

        }

        // 음수/양수 변환 처리
        private void switchPM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(NumScreen.Text, out double currentNumber))
            {
                currentNumber *= -1;
                NumScreen.Text = currentNumber.ToString("#,##0.############");
                Result = currentNumber; // 연산 결과인 Result도 부호 변경
            }
            else
            {
                NumScreen.Text = "0";
            }
        }


        // 소수점 처리
        private void dotBtn_Click(object sender, EventArgs e)
        {
            if (isNewNum)
            {
                NumScreen.Text = "0.";
                isNewNum = false;
            }
            else if (!NumScreen.Text.Contains("."))
            {
                NumScreen.Text += ".";
            }
        }


        // 역수 처리
        private void OneOverXBtn_Click(object sender, EventArgs e)
        {
            SetExpressionText("1/(");
        }


        //제곱 처리
        private void SqrBtn_Click(object sender, EventArgs e)
        {
            SetExpressionText("²");
           
        }


        //제곱근 계산
        private void rootBtn_Click(object sender, EventArgs e)
        {
            SetExpressionText("²√");

        }

        // % (퍼센트) 연산
        private void PercentBtn_Click(object sender, EventArgs e)
        {
            if (!isNewNum)
            {
                double num = double.Parse(NumScreen.Text);
                double percent = num / 100.0;
                double result = Result + (Result * percent); // 이전 결과에 퍼센트를 더함
                NumScreen.Text = result.ToString("#,##0.############");
                isNewNum = true;
            }
        }


        // CE(현재 입력된 숫자 삭제)
        private void CEBtn_Click(object sender, EventArgs e)
        {
            NumScreen.Text = "0";
            isNewNum = true;
        }



        //천의 자릿 수(,)
       
        private void FormatNumber()
        {
            if (!string.IsNullOrEmpty(NumScreen.Text))
            {
                string[] parts = NumScreen.Text.Split('.');
                if (parts.Length == 2)
                {
                    parts[1] = parts[1].PadRight(1, '0'); // 오른쪽에 추가
                    NumScreen.Text = $"{double.Parse(parts[0]):#,##0}.{parts[1]}";
                }
                else
                {
                    NumScreen.Text = $"{double.Parse(NumScreen.Text):#,##0}";
                }
            }
        }


        //수식 표시
        private void SetExpression(string expression)
        {
            if (expression == "") {
                expressionScreen.Text = Result.ToString();
            }
            else
            {
                expressionScreen.Text += expression;
            }

        }


        private void SetExpressionText(string sign)
        {
            double num = double.Parse(NumScreen.Text);
            double result = 0.0;

            

            // 수식 추가 및 초기화 로직 간소화
            if (!isNewNum)
            {
                string lastExpression = expressionScreen.Text.Substring(expressionScreen.Text.LastIndexOf(' ') + 1);
                if (lastExpression.Contains(sign))
                {
                    expressionScreen.Text = expressionScreen.Text.Substring(0, expressionScreen.Text.LastIndexOf(sign));
                }
                else
                {
                    expressionScreen.Text += " ";
                }
            }
            else
            {
                expressionScreen.Text = "";
            }

            // 연산 로직을 간결하게 표현
            switch (sign)
            {
                case "1/(":
                    result = 1.0 / num;
                    expressionScreen.Text = $"1/({num})";
                    break;
                case
                    "²":
                    result = num * num;
                    expressionScreen.Text = $"{num}²";
                    break;
                case "²√":
                    result = Math.Sqrt(num);
                    expressionScreen.Text = $"²√{num}";
                    break;
               
            }

            result = RoundCustom(result, 12);
            NumScreen.Text = result.ToString("#,##0.############");
            isNewNum = true;
            Opt = Operators.None;
        }


        private double RoundCustom(double value, int decimals)
        {
            string stringValue = value.ToString($"F{decimals}");
            int indexOfDecimal = stringValue.IndexOf('.');

            if (indexOfDecimal != -1)
            {
                string decimalPart = stringValue.Substring(indexOfDecimal + 1);

                // 내림 처리
                if (decimalPart.Contains("0000"))
                {
                    return Math.Floor(value * Math.Pow(10, decimals - 4)) / Math.Pow(10, decimals - 4);
                }

                // 올림 처리
                if (decimalPart.Contains("9999"))
                {
                    return Math.Ceiling(value * Math.Pow(10, decimals - 4)) / Math.Pow(10, decimals - 4);
                }
            }

            // 정수에 대한 올림 처리
            if (value >= 0 && value % 1 == 0 && value.ToString().Length >= 7)
            {
                return Math.Ceiling(value);
            }

            // 정수에 대한 내림 처리
            if (value < 0 && value % 1 == 0 && value.ToString().Length >= 8)
            {
                return Math.Floor(value);
            }

            return Math.Round(value, decimals);
        }


        //키보드 입력 로직 구현
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {

            if (Control.ModifierKeys == Keys.Shift && e.KeyCode == Keys.D8)
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
