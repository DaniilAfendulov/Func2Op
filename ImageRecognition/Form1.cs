using FuncOperationsApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lf = System.Func<float, float>;

namespace ImageRecognition
{
    public partial class Form1 : Form
    {
        private Bitmap _image;
        private int[][] _imagePixels;
        private lf[][] _membershipFunctions;
        private ImageRecognizer _imageRecognizer;
        public Form1()
        {
            InitializeComponent();
            _imageRecognizer = new ImageRecognizer();
            var image = new Bitmap("D:/20490 Афендулов/AI/-.png");
            var pixels = _imageRecognizer.GetImagePixels(image);
            _membershipFunctions = _imageRecognizer.GetMembershipFunctions(pixels);

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void recognizebtn_Click(object sender, EventArgs e)
        {
            
            label1.Text = _imageRecognizer.CheckWithImage(_membershipFunctions, _imagePixels).ToString();
        }

        private void LoadFile()
        {
            var r = openFileDialog1.ShowDialog();
            if (r != DialogResult.OK) return;
            var file = openFileDialog1.FileName;
            _image = new Bitmap(file);
            _imagePixels = _imageRecognizer.GetImagePixels(_image);
            pictureBox1.Image = _image;
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
