using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace taxcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int oc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int porno = new int();
            foreach (DataGridViewRow Datarow in dataGridView1.Rows)
            {
                int i = 0;
                if (Datarow.Cells[i].Value != null)
                {
                    porno = Convert.ToInt32(Datarow.Cells[i].Value);
                    i++;
                    listBox1.Items.Add(porno);
                }        
            }

            int sum = 0;
            int y = -1;
            foreach (var item in listBox1.Items)
            {
                
                int x;
                if (int.TryParse(item.ToString(), out x))
                {
                    sum += x;
                }
                y++;
                dataGridView1.Rows[y].Cells[1].Value = Math.Ceiling(Int32.Parse(item.ToString()) / 0.7);
            }

            listBox1.Items.Clear();
            label1.Text = "TOTAL R$: " + (Math.Ceiling(sum / 0.7)).ToString();
            this.Text = "TOTAL R$: " + (Math.Ceiling(sum / 0.7)).ToString();
            label1.ForeColor = Color.Red;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int y = -1;
            int x = -1;
            listBox1.Items.Clear();
            label1.Text = "TOTAL R$: 0" ;
            this.Text = "TOTAL R$: 0" ;
            label1.ForeColor = SystemColors.ControlText;

            while (true)
            {
                try
                {
                    x++;
                    dataGridView1.Rows[x].Cells[0].Value = null;
                }
                catch
                {
                    break;
                }
            }

            while (true)
            {
                try
                {
                    y++;
                    dataGridView1.Rows[y].Cells[1].Value = "";
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
