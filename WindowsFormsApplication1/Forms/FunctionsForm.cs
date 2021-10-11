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
using System.Windows.Forms.DataVisualization.Charting;

namespace FuncOperationsApplication
{
    public partial class FunctionsForm : Form
    {
        private List<Function> _functions;
        private readonly AddPointForm AddPointForm;

        public FunctionsForm()
        {
            InitializeComponent();
        }

        public FunctionsForm(List<Function> functions, StartForm ownerForm) : this()
        {
            Owner = ownerForm;
            _functions = functions;
            RefreshValues();

            listBox1.SelectedIndex = 1;
            listBox1.Select();

            AddPointForm = new AddPointForm(this);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index < 0) return;
            var f = _functions[index];
            textBox2.Text = FuncOpParser.GetFunctionText(f);
            ShowChart(f.Points);
        }
        private void ShowChart(IEnumerable<PointF> fpoints)
        {
            ChartManager.ShowChart(chart1, fpoints);
        }

        private void RefreshList()
        {
            string[] functions = FuncOpParser.GetFunctionsText(_functions);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(functions);
        }

        private void RefreshValues()
        {
            RefreshList();
            var owner = (StartForm)Owner;
            owner.RefreshFuncs(_functions);
        }

        private void AddFuncbtn_Click(object sender, EventArgs e)
        {


        }

        private void DeleteFuncbtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            _functions.RemoveAt(index);
            RefreshValues();
        }


        private void newbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Function f;
                try
                {
                    f = FuncOpParser.ParseFunction(textBox2.Text);
                }
                catch (Exception)
                {
                    f = new Function(new PointF[] { new PointF(0, 0), new PointF(1, 0), new PointF(2, 0) });
                }
                _functions.Add(f);
                RefreshValues();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                var f = FuncOpParser.ParseFunction(textBox2.Text);
                int index = listBox1.SelectedIndex;
                _functions[index] = f;
                RefreshValues();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }

        }

        public void Log(string msg)
        {
            ((StartForm)Owner).LogForm.AddLogMsgLine(msg);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void SaveFile()
        {
            var r = saveFileDialog1.ShowDialog();
            if (r != DialogResult.OK) return;
            var file = saveFileDialog1.FileName;
            string[] functions = FuncOpParser.GetFunctionsText(_functions);
            File.WriteAllLines(file, functions);
        }

        private void LoadFile()
        {
            var r = openFileDialog1.ShowDialog();
            if (r != DialogResult.OK) return;
            var file = openFileDialog1.FileName;
            string[] functions = File.ReadAllLines(file);
            _functions.Clear();
            _functions.AddRange(FuncOpParser.ParseFunctions(functions));
            RefreshList();
        }

        private void FunctionsForm_Load(object sender, EventArgs e)
        {

        }

        public void AddPoint(PointF point)
        {
            textBox2.AppendText((string.IsNullOrEmpty(textBox2.Text) ? "" : ";") + point.X + " " + point.Y);
        }

    }
}
