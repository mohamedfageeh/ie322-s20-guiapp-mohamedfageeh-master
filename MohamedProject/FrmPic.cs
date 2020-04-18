using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Mohamedfageeh
{
    public partial class FrmPic : Form
    {
        Assembly _assembly;
        Stream _imageStream;

        public FrmPic()
        {
            InitializeComponent();
        }

        private void btnImageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\dell\\Desktop\\Mohamed.jpeg");
            }
            catch
            {
                MessageBox.Show("Can't Find The Image");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void btnImageFromResource_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\Dell\\Desktop\\Mohamed.jpeg");
            }
            catch 
            {
                MessageBox.Show("Error Finding The Image");
                
            }

        }

        private void FrmPic_Load(object sender, EventArgs e)
        {
            _assembly = Assembly.GetExecutingAssembly();
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
