using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if(number.Text == ")")
            {
                if(console.Text.Contains("("))
                {
                    text_result += number.Text;
                    console.Text = text_result;
                }
            }
            else
            {
                text_result += number.Text;
                console.Text = text_result;
            }
        }

        private void arithmetic_operations_Click(object sender, EventArgs e)
        {
            Button operationSymbol = (Button)sender;
            if (text_result != "")
            {
                previousChar = text_result[text_result.Length - 1];
            }
            if(char.GetNumericValue(previousChar) >= 0 && char.GetNumericValue(previousChar) <= 9 || previousChar == ')')
            {
                text_result += operationSymbol.Text;
            }
            console.Text = text_result;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Button removeSymbol = (Button)sender;
            if(removeSymbol.Text == "CE")
            {
                text_result = "";
            }
            else
            {
                if(text_result.Length > 0)
                {
                    text_result = text_result.Remove(text_result.Length - 1);
                }
            }
            console.Text = text_result;
        }

        private void calculate_result_Click(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();
            try
            {
                var result = dataTable.Compute(text_result, "");
                text_result = "";
                for (int i = 0; i < result.ToString().Length; i++)
                {
                    if (result.ToString()[i] == ',')
                    {
                        text_result += ".";
                    }
                    else
                    {
                        text_result += result.ToString()[i];
                    }
                }
                console.Text = text_result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.digital_clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setButtonsColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.button1.BackColor = this.button2.BackColor = this.button3.BackColor = this.button4.BackColor =
            this.button5.BackColor = this.button6.BackColor = this.button7.BackColor = this.button8.BackColor =
            this.button9.BackColor = this.button10.BackColor = this.button11.BackColor = this.button12.BackColor =
            this.button13.BackColor = this.button14.BackColor = this.button15.BackColor = this.button16.BackColor =
            this.button17.BackColor = this.button18.BackColor = this.button19.BackColor = this.button20.BackColor =
            this.button21.BackColor = this.colorDialog1.Color;
        }

        private void changeBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is a calculator that allows you to perfom the following calculations:" +
                            "\n-addition\n-subtraction\n-multiplication\n-division\n-modulo operations\nIt is also a clock that display the current time.");
        }

        private void numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            MouseEventArgs arg = new MouseEventArgs((MouseButtons)Left, 0, 0, 0, 0);

            char[] keyCharTable = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                '(', ')', '%', '.', '*', '/', '+', '-', '=', '\b', 'c'};
            char[] numbers = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '(', ')' };
            char[] operations = { '%', '.', '*', '/', '+', '-'};
            char[] delete = { '\b', 'c' };


            Button[] buttons = {button7, button8, button9, button4, button5, button6,
                button1, button2, button3, button10, button17, button18, button19, button11, 
                button15, button16, button14, button13, button12, button21, button20 };

            for (int i = 0; i < keyCharTable.Length; i++)
            {
                if (e.KeyChar == keyCharTable[i])
                {
                    if(numbers.Contains(e.KeyChar))
                    {
                        numbers_Click(buttons[i], arg);
                        break;
                    }
                    else if (operations.Contains(e.KeyChar))
                    {
                        arithmetic_operations_Click(buttons[i], arg);
                        break;
                    }
                    else if(delete.Contains(e.KeyChar))
                    {
                        delete_Click(buttons[i], arg);
                        break;
                    }
                    else if(e.KeyChar == '=')
                    {
                        calculate_result_Click(buttons[i], arg);
                        break;
                    }
                    
                }
            }
        }

    }
}
