using System.Text.RegularExpressions;

namespace Regex_LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            ValidateInput(textBox1.Text);
        }

        
        private void ValidateInput(string input)
        {
            //for floating point numbers of length not greater than 6
            string pattern = @"^\d{1,6}(\.\d{1,5})?$";
            Regex regex = new Regex(pattern);

            
            if (regex.IsMatch(input) && input.Length <= 6)
            {
                label1.Text = "Valid input.";
                label1.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                label1.Text = "Invalid input. Ensure the length is not greater than 6.";
                label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
        }

       
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
