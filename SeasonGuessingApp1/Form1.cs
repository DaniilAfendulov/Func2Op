using FuncOperationsApplication.Analys;
using FuncOperationsApplication.SeasonAnalitics;
using FuncOperationsApplication.SeasonAnalitics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeasonGuessingApp1
{
    public partial class Form1 : Form
    {
        private ParamData<Season>[] _paramDatas;
        private SeasonDataParser _dataParser;
        public Form1()
        {
            InitializeComponent();
            _dataParser = new SeasonDataParser();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void getGuessBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoadFile()
        {
            var r = openFileDialog1.ShowDialog();
            if (r != DialogResult.OK) return;
            var file = openFileDialog1.FileName;
            string[] lines = File.ReadAllLines(file);
            _paramDatas = _dataParser.Parse(lines);
        }
    }
}
