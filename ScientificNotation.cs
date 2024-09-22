using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_LAB3
{
    public partial class ScientificNotation : Form
    {
        public ScientificNotation()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Number", "Scientific Notation");
            dataGridView1.Rows.Add("8e4");
            dataGridView1.Rows.Add("5e-2");
            dataGridView1.Rows.Add("6e9");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[0].Style.BackColor = System.Drawing.Color.White;
            }

           string pattern = @"^[+-]?\d+(\.\d+)?[eE][+-]?\d+$";
            Regex regex = new Regex(pattern);

            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string input = row.Cells[0].Value.ToString();
                    if (regex.IsMatch(input))
                    {
                        row.Cells[0].Style.BackColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        row.Cells[0].Style.BackColor = System.Drawing.Color.Red; 
                    }
                }
            }
        }
    
    }
    
}
