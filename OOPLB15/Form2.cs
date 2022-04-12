using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLB15
{
    public partial class Form2 : Form
    {
        public Form2(string img, string text, bool linker)
        {
            InitializeComponent();
            label1.Text = text;
            if (linker) pictureBox1.Load(img);
            else
            {
                System.Resources.ResourceManager resursesImg = Properties.Resources.ResourceManager;
                pictureBox1.Image = (Image)resursesImg.GetObject(img);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
