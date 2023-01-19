using CalculatorLib;

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
            Addition
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
                _value1 = 1;
            }
            else
            {
                _value2 = 1;
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
           // _calcOperation = CalcOperation.Subtractions;
        }
    }
}
    
   
