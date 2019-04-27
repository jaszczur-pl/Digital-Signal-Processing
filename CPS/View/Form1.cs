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
        private Sygnal lastAffectedSignal;

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

            GenerateSignal(sender);
        }

        private void btnAddSignal2_Click(object sender, EventArgs e) {
            GenerateSignal(sender);
        }

        private void GenerateSignal(object sender) {
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

            if (sender.Equals(btnAddSignal1)) {
                operat.Signal1 = signal;
                checkBox1.Checked = true;
                btnSaveFile1.Enabled = true;
            } else if (sender.Equals(btnAddSignal2)) {
                operat.Signal2 = signal;
                checkBox2.Checked = true;
                btnSaveFile2.Enabled = true;
            }

            signal.CalculateXYPoints();
            signal.AverageValue = operat.CalculateAverageValue(signal);
            signal.AbsAverageValue = operat.CalculateAbsAverage(signal);
            signal.AveragePower = operat.CalculateAveragePower(signal);
            signal.Variance = operat.CalculateVariance(signal);
            signal.RMS = operat.CalculateRMS(signal);

            PrintStats(signal);
            PrintPlot(signal);
            lastAffectedSignal = signal;

            CheckBtnPrintDoubleSignals();
            CheckBtnPrintHistogram();
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

        private void PrintHistogram(Sygnal signal) {
            
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart2.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart2.Series[0].Points.Clear();
            chart2.Titles.Clear();

            chart2.Titles.Add("Histogram");
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = signal.axisY.Max();
            chart2.ChartAreas[0].AxisX.Maximum = signal.axisX.Max() + operat.partOfRange * 0.5;
            chart2.Series[0].Points.DataBindXY(signal.axisX, signal.axisY);
        }

        private void PrintStats(Sygnal signal) {
            textBoxAvg.Text = signal.AverageValue.ToString();
            textBoxAbsAvg.Text = signal.AbsAverageValue.ToString();
            textBoxAvgPow.Text = signal.AveragePower.ToString();
            textBoxVar.Text = signal.Variance.ToString();
            textBoxRMS.Text = signal.RMS.ToString();
        }

        private void btnPrintDoubleSingals_Click(object sender, EventArgs e) {

            Sygnal signal = new Sygnal();

            if (comboBoxMathOperation.SelectedIndex == 0) {
                signal = operat.AddSignals();
                PrintPlot(signal);
            }
            else if (comboBoxMathOperation.SelectedIndex == 1) {
                signal = operat.SubtractSignals();
                PrintPlot(signal);
            }
            else if (comboBoxMathOperation.SelectedIndex == 2) {
                signal = operat.MultiplySignals();
                PrintPlot(signal);
            }
            else if (comboBoxMathOperation.SelectedIndex == 3) {
                signal = operat.DivideSignals();
                PrintPlot(signal);
            }

            lastAffectedSignal = signal;
        }

        private void btnPrintHistogram_Click(object sender, EventArgs e) {

            if (IsTextBoxHistogramValid()) {
                int histValue = Convert.ToInt32(textBoxHistogram.Text);

                Sygnal signal = new Sygnal();

                signal = operat.CalculateHistogram(lastAffectedSignal, histValue);
                PrintHistogram(signal);
            }
            else {
                MessageBox.Show("Dopuszczalne wartości przedziałów dla histogramu: 5-20");
            }


        }

        private void btnSaveFile1_Click(object sender, EventArgs e) {
            SaveFile(sender);
        }

        private void btnSaveFile2_Click(object sender, EventArgs e) {
            SaveFile(sender);
        }

        private void SaveFile(object sender) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"e:\";
            sfd.Filter = "bin files (*.bin)|*.bin";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK) {
                FileHandler fileHandler = new FileHandler();

                if (sender.Equals(btnSaveFile1)) {
                    fileHandler.Serialize(operat.Signal1, sfd.FileName);
                } else if (sender.Equals(btnSaveFile2)) {
                    fileHandler.Serialize(operat.Signal2, sfd.FileName);
                }
                
                MessageBox.Show("Sygnał został zapisany!", "OK");
            }
        }

        private void btnLoadFile1_Click(object sender, EventArgs e) {
            LoadFile(sender);
        }

        private void btnLoadFile2_Click(object sender, EventArgs e) {
            LoadFile(sender);
        }

        private void LoadFile(object sender) {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"e:\";
            ofd.Filter = "bin files (*.bin)|*.bin";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK) {

                FileHandler fileHandler = new FileHandler();
                Sygnal signal = fileHandler.Deserialize(ofd.FileName);

                if (sender.Equals(btnLoadFile1)) {
                    operat.Signal1 = signal;
                    checkBox1.Checked = true;
                    btnSaveFile1.Enabled = true;
                } else if (sender.Equals(btnLoadFile2)) {
                    operat.Signal2 = signal;
                    checkBox2.Checked = true;
                    btnSaveFile2.Enabled = true;
                }

                PrintStats(signal);
                PrintPlot(signal);
                lastAffectedSignal = signal;

                CheckBtnPrintDoubleSignals();
            }
        }

        private void CheckBtnPrintDoubleSignals() {
            if (checkBox1.Checked && checkBox2.Checked && comboBoxMathOperation.SelectedIndex > -1) {
                btnPrintDoubleSingals.Enabled = true;
            }
        }

        private void CheckBtnPrintHistogram() {
            if ((checkBox1.Checked || checkBox2.Checked) && !string.IsNullOrWhiteSpace(textBoxHistogram.Text)) {
                btnPrintHistogram.Enabled = true;
            }
        }

        private bool IsTextBoxHistogramValid() {
            int value = Convert.ToInt32(textBoxHistogram.Text);

            if (value < 5 || value > 20) {
                return false;
            }
            else {
                return true;
            }
        }

        private void comboBoxMathOperation_SelectedIndexChanged(object sender, EventArgs e) {
            CheckBtnPrintDoubleSignals();
        }

        private void textBoxHistogram_TextChanged(object sender, EventArgs e) {
            CheckBtnPrintHistogram();
        }

        private void textBoxHistogram_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar < '0' || e.KeyChar > '9') {
                e.Handled = true;
            }
        }
    }
}
