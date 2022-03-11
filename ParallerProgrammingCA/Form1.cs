using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallerProgrammingCA
{
    public partial class Form1 : Form
    {
        private PrimeNumbers _primeNumbers { get; set; }
        public Form1()
        {
            _primeNumbers = new PrimeNumbers();
            InitializeComponent();
        }

        async void button1_Click(object sender, EventArgs e)
        {
            Results.DataSource = new List<long>();
            if (minNum.Value == 0 || maxNum.Value == 0 || (minNum.Value >= maxNum.Value))
            {
                return;
            }
            
            var src = await Task.Run(() => _primeNumbers.GetPrimesParallely((long)minNum.Value, (long)maxNum.Value));
            var list = src.list.ToList();
            list.Sort();
            Results.DataSource = list ;
            timerBox.Text = $"Execution ms: {src.elapsed.TotalMilliseconds}";
            historyLog.AppendText($"Paralel: {minNum.Value}-{maxNum.Value}, ms: {src.elapsed.TotalMilliseconds} \n" + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Results.DataSource = new List<long>();
            if (minNum.Value == 0 || maxNum.Value == 0 || (minNum.Value >= maxNum.Value))
            {
                return;
            }
            var elapsed = new TimeSpan();
            Results.DataSource = PrimeNumbers.GetPrimesSequentially((long)minNum.Value, (long)maxNum.Value, out elapsed);
            timerBox.Text = $"Execution ms: {elapsed.TotalMilliseconds}";
            historyLog.AppendText($"Seq: {minNum.Value}-{maxNum.Value}, ms: {elapsed.TotalMilliseconds} \n" + Environment.NewLine);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
