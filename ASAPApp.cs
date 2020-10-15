using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASAPApp
{
    public partial class Form1 : Form
    {
        double i1 = 0;
        double i2y = 0;
        double i2n = 0;
        double i3 = 0;
        double i4 = 0;
        double i5 = 0;
        double i6y = 0;
        double i6n = 0;
        int errors = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void q1_TextChanged(object sender, EventArgs e)
        {

        }
        private void q2_TextChanged(object sender, EventArgs e)
        {

        }

        private void q3_TextChanged(object sender, EventArgs e)
        {

        }

        private void q4_TextChanged(object sender, EventArgs e)
        {

        }

        private void q5_TextChanged(object sender, EventArgs e)
        {

        }

        private void q6_TextChanged(object sender, EventArgs e)
        {

        }


        public void bttnCalculate_Click(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrWhiteSpace(q1.Text))
                {
                    if (double.TryParse(q1.Text, out var value))
                    {
                        int que1 = int.Parse(q1.Text);
                        double indexq1 = (que1 + 0.5) * que1;
                        i1 = indexq1;
                        //displayWRPRIndex.Text = indexq1.ToString("n2");
                    }
                    else
                    {
                        displayWRPRIndex.Text = "";
                        MessageBox.Show($"Your answer for question #1 is '{q1.Text}'. This is not a number. Please enter a number!");
                    errors = errors+1;
                    }
                }
                else
                {
                    displayWRPRIndex.Text = "";
                    MessageBox.Show("Please answer at question #1 with a number!");
                errors = errors+1;
            }




                if (!string.IsNullOrWhiteSpace(q3.Text))
                {
                    if (double.TryParse(q3.Text, out var value))
                    {
                        int que3 = int.Parse(q3.Text);
                        double indexq3 = (que3 + 0.9) * que3;
                        i3 = indexq3;
                        //displayWRPRIndex.Text = indexq3.ToString("n2");
                    }
                    else
                    {
                        displayWRPRIndex.Text = "";
                        MessageBox.Show($"Your answer for question #3 is '{q3.Text}'. This is not a number. Please enter a number!");
                    errors = errors+1;
                }
                }
                else
                {
                    displayWRPRIndex.Text = "";
                    MessageBox.Show("Please answer at question #3 with a number!");
                errors = errors+1;
            }

                if (!string.IsNullOrWhiteSpace(q4.Text))
                {
                    if (double.TryParse(q4.Text, out var value))
                    {
                        int que4 = int.Parse(q4.Text);
                        double indexq4 = (que4 + 0.7) * que4;
                        i4 = indexq4;
                        //displayWRPRIndex.Text = indexq4.ToString("n2");
                    }
                    else
                    {
                        displayWRPRIndex.Text = "";
                        MessageBox.Show($"Your answer for question #4 is '{q4.Text}'. This is not a number. Please enter a number!");
                    errors = errors+1;
                }
                }
                else
                {
                    displayWRPRIndex.Text = "";
                    MessageBox.Show("Please answer at question #4 with a number!");
                errors = errors+1;
            }


                if (!string.IsNullOrWhiteSpace(q5.Text))
                {
                    if (double.TryParse(q5.Text, out var value))
                    {
                        int que5 = int.Parse(q5.Text);
                        double indexq5 = -(que5 + 0.1) * que5;
                        i5 = indexq5;
                        //displayWRPRIndex.Text = indexq5.ToString("n2");
                    }
                    else
                    {
                        displayWRPRIndex.Text = "";
                        MessageBox.Show($"Your answer for question #5 is '{q5.Text}'. This is not a number. Please enter a number!");
                    errors = errors+1;
                }
                }
                else
                {
                    displayWRPRIndex.Text = "";
                    MessageBox.Show("Please answer at question #5 with a number!");
                errors = errors+1;
            }

                if (!string.IsNullOrWhiteSpace(q2.Text))
                {

                    string que2str = q2.Text;

                    if (que2str == "y")
                    {
                        double indexq2y = -2;
                        i2y = indexq2y;
                        //displayWRPRIndex.Text = indexq2y.ToString("n2");
                    }
                    else if (que2str == "n")
                    {
                        double indexq2n = 3;
                        i2n = indexq2n;
                        //displayWRPRIndex.Text = indexq2n.ToString("n2");
                    }


                    else
                    {
                        displayWRPRIndex.Text = "";
                        MessageBox.Show($"Your answer for question #2 is '{q2.Text}'. This is not y or n. Please enter y for a 'YES' and n for a 'NO'!");
                    errors = errors+1;
                }
                }
                else
                {
                    displayWRPRIndex.Text = "";
                    MessageBox.Show("Please answer at question #2 with y for a 'YES' and n for a 'NO'!");
                errors = errors+1;
            }



                if (!string.IsNullOrWhiteSpace(q6.Text))
                {

                    string que6str = q6.Text;

                    if (que6str == "y")
                    {
                        double indexq6y = -3;
                        i6y = indexq6y;
                        //displayWRPRIndex.Text = indexq6y.ToString("n2");
                    }
                    else if (que6str == "n")
                    {
                        double indexq6n = 2;
                        i6n = indexq6n;
                        //displayWRPRIndex.Text = indexq6n.ToString("n2");
                    }


                    else
                    {
                        displayWRPRIndex.Text = "";
                        MessageBox.Show($"Your answer for question #6 is '{q6.Text}'. This is not y or n. Please enter y for a 'YES' and n for a 'NO'!");
                    errors = errors+1;
                }
                }
                else
                {
                    displayWRPRIndex.Text = "";
                    MessageBox.Show("Please answer at question #6 with y for a 'YES' and n for a 'NO'!");
                errors = errors+1;
                
            }
            if (errors == 0)
            {
                double WRPRIndex = i1 + i2n + i2y + i3 + i4 + i5 + i6n + i6y;
                //displayWRPRIndex.Text = errors.ToString();
                displayWRPRIndex.Text = WRPRIndex.ToString("n2");

            } else
            {
                //displayWRPRIndex.Text = errors.ToString();
                errors = 0;

            }

                //Application.Restart(500ms);
                //bttnCalculate.Enabled = false;


        }

        private void displayWRPRIndex_Click(object sender, EventArgs e)
        {

        }

        private void bttnYesTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttnNoTwo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            displayWRPRIndex.Text = "";
            q1.Text = "";
            q2.Text = "";
            q3.Text = "";
            q4.Text = "";
            q5.Text = "";
            q6.Text = "";
        }



    }
}

