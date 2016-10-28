using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_text_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try{
                int txtno = int.Parse(textBox1.Text);
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                for (int i = 0; i < txtno; i++)
                {
                    TextBox a = new TextBox();
                    a.Text = (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);
                    panel2.Controls.Add(a);
                    panel2.Show();
                    pointY += 20;
                }
            }
catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
