using System;
using System.Windows.Forms;

namespace lab3_sharp_GUI
{
    public partial class Form1 : Form
    {
        private Complex_number[] complex_number1 = new Complex_number[3];
        private int counter = 0;
        string[] abc = new string[3];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (counter > 2)
            {
                counter = 0;
            }

            try
            {
                complex_number1[counter] = new Complex_number(Double.Parse(textBox_x.Text), Double.Parse(textBox_y.Text));

                counter++;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            textBox_x.Text = "";
            textBox_y.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

                richTextBox1.Text = $"a = {complex_number1[0].ToString()}\nb = {complex_number1[1].ToString()}"
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                complex_number1[i] = new Complex_number();
                
            }
        }
    }
}
