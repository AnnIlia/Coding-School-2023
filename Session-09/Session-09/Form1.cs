using CalculatorLib;


// sorry for multiple corry paste in code. I didn't finish raise to power and square root, cause my computer is not cooperating and I'm running late.

namespace Session_09
{
    public partial class Form1 : Form
    {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcOperation _calcOperation;

        enum CalcOperation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            //RaiseToPower,
           // SquareRoot
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 3 ";

            if (_value1 == null)
            {
                _value1 = 3;
            }
            else
            {
                _value2 = 3;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 4 ";

            if (_value1 == null)
            {
                _value1 = 4;
            }
            else
            {
                _value2 = 4;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " ^ ";
            //_calcOperation = CalcOperation.RaiseToPower;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 0 ";

            if (_value1 == null)
            {
                _value1 = 0;
            }
            else
            {
                _value2 = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 7 ";

            if (_value1 == null)
            {
                _value1 = 7;
            }
            else
            {
                _value2 = 7;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {

            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 1 ";

            if (_value1 == null)
            {
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 2 ";

            if (_value1 == null)
            {
                _value1 = 2;
            }
            else
            {
                _value2 = 2;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 5 ";

            if (_value1 == null)
            {
                _value1 = 5;
            }
            else
            {
                _value2 = 5;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 6 ";

            if (_value1 == null)
            {
                _value1 = 6;
            }
            else
            {
                _value2 = 6;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 8 ";

            if (_value1 == null)
            {
                _value1 = 8;
            }
            else
            {
                _value2 = 8;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (_result != null)
            {

                ctrlDisplay.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }

            ctrlDisplay.Text += " 9 ";

            if (_value1 == null)
            {
                _value1 = 9;
            }
            else
            {
                _value2 = 9;
            }
        }

        private void CtrlEqual_Click(object sender, EventArgs e) //TODO: EVALUATION ALL OPERATION'S SYMBOLS
        {
            ctrlDisplay.Text += " = ";

            switch (_calcOperation)
            {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);

                    break;

                case CalcOperation.Subtraction:

                    Subtraction subtraction = new Subtraction();
                    _result = subtraction.Do(_value1, _value2);

                    break;
                case CalcOperation.Multiplication:

                    Miltiplication multiplication = new Miltiplication();
                    _result = multiplication.Do(_value1, _value2);
                    break;

                case CalcOperation.Division:
                    Division division = new Division();
                    _result = division.Do(_value1, _value2);
                    break;
                /*
                case CalcOperation.RaiseToPower();
                    _result = raisetopower.Do(_value1, _value2);
                    break;
                case CalcOperation.squareroot();
                    _result = SquareRoot.Do(_value1, _value2);
                    break; 
                    */

                default:
                    break;
            }
            ctrlDisplay.Text += _result;
        }

        private void CtrlAddition_Click(object sender, EventArgs e)
        {
            {
                ctrlDisplay.Text += " + ";
                _calcOperation = CalcOperation.Addition;
            }
        }

        private void CtrlSubstraction_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " - ";
            _calcOperation = CalcOperation.Subtraction;
        }

        private void CtrlMultiplication_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " * ";
            _calcOperation = CalcOperation.Multiplication;
        }

        private void CtrlDivition_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " / ";
            _calcOperation = CalcOperation.Division;
        }

        private void CtrlSquareRoot_Click(object sender, EventArgs e)
        {
            ctrlDisplay.Text += " (char)0x221A ";
           // _calcOperation = CalcOperation.SquareRoot;
        }
    }
}
    
   
