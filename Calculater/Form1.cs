using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        private char _operation;
        private bool _screenclear;
        private int _firstnumber;



        public Form1()
        {
            InitializeComponent();
        }

        private void la_Click(object sender, EventArgs e)
        {

        }

        private void number1Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "1";
        }

        private void number2Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "2";
        }

        private void number3Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "3";
        }

        private void number4Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "4";
        }

        private void number5Button_Click(object sender, EventArgs e)
        {
            if(_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "5";
        }

        private void number6Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "6";
        }

        private void number7Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "7";
        }

        private void number8Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "8";
        }

        private void number9Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "9";
        }

        private void number0Button_Click(object sender, EventArgs e)
        {
            if (_screenclear)
            {
                screenLabel.Text = "";
                _screenclear = false;
            }
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            _operation= '+';
            _screenclear = true;
            _firstnumber = Convert.ToInt32(screenLabel.Text);  
        }

        private void equal_Click(object sender, EventArgs e)
        {
            int secondnumber = Convert.ToInt32(screenLabel.Text);
            int result;


            switch(_operation)
            {
                case '+':
                    result = _firstnumber + secondnumber;
                    break;

                case '-':
                    result = _firstnumber - secondnumber;
                    break;

                case '*':
                    result = _firstnumber * secondnumber;
                    break;

                case '/':
                    result = _firstnumber / secondnumber;
                    break;

                default:
                    result = 0;
                    break;
            }
            screenLabel.Text = Convert.ToString(result);

        }

        private void extraction_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _screenclear = true;
            _firstnumber = Convert.ToInt32(screenLabel.Text);
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            _operation = '*';
            _screenclear = true;
            _firstnumber = Convert.ToInt32(screenLabel.Text);
        }

        private void devide_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _screenclear = true;
            _firstnumber = Convert.ToInt32(screenLabel.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }
    }
}
