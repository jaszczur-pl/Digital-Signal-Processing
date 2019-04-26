using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS
{
    public partial class btnDoubleSingals : Form
    {

        private Operator operat = new Operator();

        public btnDoubleSingals() {
            InitializeComponent();
        }

        private void comboBoxSignal_SelectedIndexChanged(object sender, EventArgs e) {

            if (comboBoxSignal.SelectedIndex == 0 || comboBoxSignal.SelectedIndex == 1) {
                textBoxA.ReadOnly = false;
                textBoxt1.ReadOnly = false;
                textBoxd.ReadOnly = false;

                textBoxT.ReadOnly = true;
                textBoxkw.ReadOnly = true;
                textBoxts.ReadOnly = true;
                textBoxn1.ReadOnly = true;
                textBoxns.ReadOnly = true;
                textBoxf.ReadOnly = true;
                textBoxp.ReadOnly = true;
            }
            else if (comboBoxSignal.SelectedIndex == 2 || comboBoxSignal.SelectedIndex == 3 || comboBoxSignal.SelectedIndex == 4) {
                textBoxA.ReadOnly = false;
                textBoxt1.ReadOnly = false;
                textBoxd.ReadOnly = false;
                textBoxT.ReadOnly = false;

                textBoxkw.ReadOnly = true;
                textBoxts.ReadOnly = true;
                textBoxn1.ReadOnly = true;
                textBoxns.ReadOnly = true;
                textBoxf.ReadOnly = true;
                textBoxp.ReadOnly = true;
            }
            else if (comboBoxSignal.SelectedIndex == 5 || comboBoxSignal.SelectedIndex == 6 || comboBoxSignal.SelectedIndex == 7) {
                textBoxA.ReadOnly = false;
                textBoxt1.ReadOnly = false;
                textBoxd.ReadOnly = false;
                textBoxT.ReadOnly = false;
                textBoxkw.ReadOnly = false;

                textBoxts.ReadOnly = true;
                textBoxn1.ReadOnly = true;
                textBoxns.ReadOnly = true;
                textBoxf.ReadOnly = true;
                textBoxp.ReadOnly = true;
            }
            else if (comboBoxSignal.SelectedIndex == 8) {
                textBoxA.ReadOnly = false;
                textBoxt1.ReadOnly = false;
                textBoxd.ReadOnly = false;
                textBoxts.ReadOnly = false;

                textBoxT.ReadOnly = true;
                textBoxkw.ReadOnly = true;
                textBoxn1.ReadOnly = true;
                textBoxns.ReadOnly = true;
                textBoxf.ReadOnly = true;
                textBoxp.ReadOnly = true;

            }
            else if (comboBoxSignal.SelectedIndex == 9) {
                textBoxA.ReadOnly = false;
                textBoxns.ReadOnly = false;
                textBoxn1.ReadOnly = false;
                textBoxd.ReadOnly = false;
                textBoxf.ReadOnly = false;

                textBoxt1.ReadOnly = true;
                textBoxT.ReadOnly = true;
                textBoxkw.ReadOnly = true;
                textBoxts.ReadOnly = true;
                textBoxp.ReadOnly = true;
            }
            else if (comboBoxSignal.SelectedIndex == 10) {
                textBoxA.ReadOnly = false;
                textBoxt1.ReadOnly = false;
                textBoxd.ReadOnly = false;
                textBoxf.ReadOnly = false;
                textBoxp.ReadOnly = false;

                textBoxT.ReadOnly = true;
                textBoxkw.ReadOnly = true;
                textBoxts.ReadOnly = true;
                textBoxn1.ReadOnly = true;
                textBoxns.ReadOnly = true;
            }
        }

        private void btnAddSignal1_Click(object sender, EventArgs e) {

            Sygnal signal;

            switch (comboBoxSignal.SelectedIndex) {
                case 0:
                    signal = new SzumJednostajny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
                case 1:
                    signal = new SzumGaussowski(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
                case 2:
                    signal = new SygnalSin(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxt1.Text), 
                        Convert.ToDouble(textBoxd.Text));
                    break;
                case 3:
                    signal = new SygnalSinWyprostowanyJednoPolowkowo(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxt1.Text),
                        Convert.ToDouble(textBoxd.Text));
                    break;
                case 4:
                    signal = new SygnalSinWyprostowanyDwuPolowkowo(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxt1.Text),
                        Convert.ToDouble(textBoxd.Text));
                    break;
                case 5:
                    signal = new SygnalProstokatny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxkw.Text),
                        Convert.ToDouble(textBoxd.Text), Convert.ToDouble(textBoxt1.Text));
                    break;
                case 6:
                    signal = new SygnalProstokatnySymetryczny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxkw.Text),
                        Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
                case 7:
                    signal = new SygnalTrojkatny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxkw.Text),
                        Convert.ToDouble(textBoxd.Text), Convert.ToDouble(textBoxt1.Text));
                    break;
                case 8:
                    signal = new SkokJednostkowy(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text),
                        Convert.ToDouble(textBoxts.Text));
                    break;
                case 9:
                    signal = new ImpulsJednostkowy(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxn1.Text), Convert.ToDouble(textBoxns.Text),
                        Convert.ToDouble(textBoxd.Text), Convert.ToDouble(textBoxf.Text));
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case 10:
                    signal = new ImpulsJednostkowy(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text),
                        Convert.ToDouble(textBoxf.Text), Convert.ToDouble(textBoxp.Text));
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                default:
                    signal = new SzumJednostajny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
            }

            operat.Signal1 = signal;
            signal.CalculateXYPoints();
            PrintPlot(signal);

            checkBox1.Checked = true;
        }

        private void btnAddSignal2_Click(object sender, EventArgs e) {
            Sygnal signal;

            switch (comboBoxSignal.SelectedIndex) {
                case 0:
                    signal = new SzumJednostajny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
                case 1:
                    signal = new SzumGaussowski(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
                case 2:
                    signal = new SygnalSin(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxt1.Text),
                        Convert.ToDouble(textBoxd.Text));
                    break;
                case 3:
                    signal = new SygnalSinWyprostowanyJednoPolowkowo(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxt1.Text),
                        Convert.ToDouble(textBoxd.Text));
                    break;
                case 4:
                    signal = new SygnalSinWyprostowanyDwuPolowkowo(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxt1.Text),
                        Convert.ToDouble(textBoxd.Text));
                    break;
                case 5:
                    signal = new SygnalProstokatny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxkw.Text),
                        Convert.ToDouble(textBoxd.Text), Convert.ToDouble(textBoxt1.Text));
                    break;
                case 6:
                    signal = new SygnalProstokatnySymetryczny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxkw.Text),
                        Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
                case 7:
                    signal = new SygnalTrojkatny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxT.Text), Convert.ToDouble(textBoxkw.Text),
                        Convert.ToDouble(textBoxd.Text), Convert.ToDouble(textBoxt1.Text));
                    break;
                case 8:
                    signal = new SkokJednostkowy(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text),
                        Convert.ToDouble(textBoxts.Text));
                    break;
                case 9:
                    signal = new ImpulsJednostkowy(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxn1.Text), Convert.ToDouble(textBoxns.Text),
                        Convert.ToDouble(textBoxd.Text), Convert.ToDouble(textBoxf.Text));
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case 10:
                    signal = new ImpulsJednostkowy(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text),
                        Convert.ToDouble(textBoxf.Text), Convert.ToDouble(textBoxp.Text));
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                default:
                    signal = new SzumJednostajny(Convert.ToDouble(textBoxA.Text), Convert.ToDouble(textBoxt1.Text), Convert.ToDouble(textBoxd.Text));
                    break;
            }

            operat.Signal2 = signal;
            signal.CalculateXYPoints();
            PrintPlot(signal);

            checkBox2.Checked = true;
        }

        private void btnDoubleSingals_Load(object sender, EventArgs e) {

        }

        private void btnPrintSingleSignal_Click(object sender, EventArgs e) {

            string chartName;
            

            if (comboBoxSignal.SelectedIndex == 0) {
                chartName = "Szum Jednostajny";

            }
        }

        private void PrintPlot(Sygnal signal) {
            
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.Series[0].Points.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add(signal.signalName);
            chart1.ChartAreas[0].AxisY.Minimum = signal.axisY.Min();
            chart1.ChartAreas[0].AxisY.Maximum = signal.axisY.Max();
            chart1.Series[0].Points.DataBindXY(signal.axisX, signal.axisY);
            chart1.Series[0].MarkerSize = 3;
        }
    }
}
