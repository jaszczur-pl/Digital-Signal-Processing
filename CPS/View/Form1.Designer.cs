namespace CPS
{
    partial class btnDoubleSingals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFile1 = new System.Windows.Forms.Button();
            this.btnLoadFile1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxt1 = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxd = new System.Windows.Forms.TextBox();
            this.textBoxn1 = new System.Windows.Forms.TextBox();
            this.textBoxkw = new System.Windows.Forms.TextBox();
            this.textBoxts = new System.Windows.Forms.TextBox();
            this.textBoxns = new System.Windows.Forms.TextBox();
            this.textBoxp = new System.Windows.Forms.TextBox();
            this.textBoxf = new System.Windows.Forms.TextBox();
            this.btnAddSignal1 = new System.Windows.Forms.Button();
            this.comboBoxMathOperation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAvgPow = new System.Windows.Forms.TextBox();
            this.textBoxVar = new System.Windows.Forms.TextBox();
            this.textBoxRMS = new System.Windows.Forms.TextBox();
            this.textBoxAbsAvg = new System.Windows.Forms.TextBox();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnAddSignal2 = new System.Windows.Forms.Button();
            this.btnPrintDoubleSingals = new System.Windows.Forms.Button();
            this.btnLoadFile2 = new System.Windows.Forms.Button();
            this.btnSaveFile2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxHistogram = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnPrintHistogram = new System.Windows.Forms.Button();
            this.btnSaveCalculatedSignal = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Items.AddRange(new object[] {
            "szum o rozkładzie jednostajnym",
            "szum gaussowski",
            "sygnał sinusoidalny",
            "sygnał sinusoidalny wyprostowany jednopołówkowo",
            "sygnał sinusoidalny wyprostowany dwupołówkowo",
            "sygnał prostokatny",
            "sygnał prostokatny symetryczny",
            "sygnał trójkatny",
            "skok jednostkowy",
            "impuls jednostkowy",
            "szum impulsowy"});
            this.comboBoxSignal.Location = new System.Drawing.Point(5, 25);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(253, 21);
            this.comboBoxSignal.TabIndex = 0;
            this.comboBoxSignal.Tag = "1";
            this.comboBoxSignal.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rodzaj sygnału / szumu";
            // 
            // btnSaveFile1
            // 
            this.btnSaveFile1.Enabled = false;
            this.btnSaveFile1.Location = new System.Drawing.Point(6, 59);
            this.btnSaveFile1.Name = "btnSaveFile1";
            this.btnSaveFile1.Size = new System.Drawing.Size(121, 23);
            this.btnSaveFile1.TabIndex = 4;
            this.btnSaveFile1.Text = "Zapisz do pliku";
            this.btnSaveFile1.UseVisualStyleBackColor = true;
            this.btnSaveFile1.Click += new System.EventHandler(this.btnSaveFile1_Click);
            // 
            // btnLoadFile1
            // 
            this.btnLoadFile1.Location = new System.Drawing.Point(6, 100);
            this.btnLoadFile1.Name = "btnLoadFile1";
            this.btnLoadFile1.Size = new System.Drawing.Size(121, 23);
            this.btnLoadFile1.TabIndex = 5;
            this.btnLoadFile1.Text = "Odczytaj z pliku";
            this.btnLoadFile1.UseVisualStyleBackColor = true;
            this.btnLoadFile1.Click += new System.EventHandler(this.btnLoadFile1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amplituda (A)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Czas początkowy ( t1 )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Czas trwania sygnału (d)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Okres podstawowy (T)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Współczynnik wypełnienia (kw)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Numer pierwszej próbki (n1)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Numer próbki skoku (ns)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Prawdopodobieństwo (p)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Częstotliwość próbkowania (f)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Czas skoku (ts)";
            // 
            // chart1
            // 
            chartArea5.AxisX.Title = "Czas trwania sygnału";
            chartArea5.AxisY.Title = "Amplituda";
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Cursor = System.Windows.Forms.Cursors.No;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(348, 25);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.EmptyPointStyle.MarkerSize = 200;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "signal";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(363, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.AxisX.Title = "Wartość bezwględna sygnału";
            chartArea6.AxisY.Title = "Liczba próbek";
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(765, 26);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(363, 380);
            this.chart2.TabIndex = 31;
            this.chart2.Text = "chart2";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(187, 71);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(71, 20);
            this.textBoxA.TabIndex = 32;
            // 
            // textBoxt1
            // 
            this.textBoxt1.Location = new System.Drawing.Point(187, 104);
            this.textBoxt1.Name = "textBoxt1";
            this.textBoxt1.ReadOnly = true;
            this.textBoxt1.Size = new System.Drawing.Size(71, 20);
            this.textBoxt1.TabIndex = 33;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(187, 173);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.ReadOnly = true;
            this.textBoxT.Size = new System.Drawing.Size(71, 20);
            this.textBoxT.TabIndex = 35;
            // 
            // textBoxd
            // 
            this.textBoxd.Location = new System.Drawing.Point(187, 140);
            this.textBoxd.Name = "textBoxd";
            this.textBoxd.ReadOnly = true;
            this.textBoxd.Size = new System.Drawing.Size(71, 20);
            this.textBoxd.TabIndex = 34;
            // 
            // textBoxn1
            // 
            this.textBoxn1.Location = new System.Drawing.Point(187, 241);
            this.textBoxn1.Name = "textBoxn1";
            this.textBoxn1.ReadOnly = true;
            this.textBoxn1.Size = new System.Drawing.Size(71, 20);
            this.textBoxn1.TabIndex = 37;
            // 
            // textBoxkw
            // 
            this.textBoxkw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxkw.Location = new System.Drawing.Point(187, 208);
            this.textBoxkw.Name = "textBoxkw";
            this.textBoxkw.ReadOnly = true;
            this.textBoxkw.Size = new System.Drawing.Size(71, 20);
            this.textBoxkw.TabIndex = 36;
            // 
            // textBoxts
            // 
            this.textBoxts.Location = new System.Drawing.Point(187, 312);
            this.textBoxts.Name = "textBoxts";
            this.textBoxts.ReadOnly = true;
            this.textBoxts.Size = new System.Drawing.Size(71, 20);
            this.textBoxts.TabIndex = 39;
            // 
            // textBoxns
            // 
            this.textBoxns.Location = new System.Drawing.Point(187, 279);
            this.textBoxns.Name = "textBoxns";
            this.textBoxns.ReadOnly = true;
            this.textBoxns.Size = new System.Drawing.Size(71, 20);
            this.textBoxns.TabIndex = 38;
            // 
            // textBoxp
            // 
            this.textBoxp.Location = new System.Drawing.Point(187, 385);
            this.textBoxp.Name = "textBoxp";
            this.textBoxp.ReadOnly = true;
            this.textBoxp.Size = new System.Drawing.Size(71, 20);
            this.textBoxp.TabIndex = 41;
            // 
            // textBoxf
            // 
            this.textBoxf.Location = new System.Drawing.Point(187, 352);
            this.textBoxf.Name = "textBoxf";
            this.textBoxf.ReadOnly = true;
            this.textBoxf.Size = new System.Drawing.Size(71, 20);
            this.textBoxf.TabIndex = 40;
            // 
            // btnAddSignal1
            // 
            this.btnAddSignal1.Location = new System.Drawing.Point(6, 19);
            this.btnAddSignal1.Name = "btnAddSignal1";
            this.btnAddSignal1.Size = new System.Drawing.Size(121, 23);
            this.btnAddSignal1.TabIndex = 42;
            this.btnAddSignal1.Text = "Dodaj sygnał 1";
            this.btnAddSignal1.UseVisualStyleBackColor = true;
            this.btnAddSignal1.Click += new System.EventHandler(this.btnAddSignal1_Click);
            // 
            // comboBoxMathOperation
            // 
            this.comboBoxMathOperation.FormattingEnabled = true;
            this.comboBoxMathOperation.Items.AddRange(new object[] {
            "Dodawanie",
            "Odejmowanie",
            "Mnożenie",
            "Dzielenie"});
            this.comboBoxMathOperation.Location = new System.Drawing.Point(396, 440);
            this.comboBoxMathOperation.Name = "comboBoxMathOperation";
            this.comboBoxMathOperation.Size = new System.Drawing.Size(133, 21);
            this.comboBoxMathOperation.TabIndex = 43;
            this.comboBoxMathOperation.SelectedIndexChanged += new System.EventHandler(this.comboBoxMathOperation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Operacja matematyczna";
            // 
            // textBoxAvgPow
            // 
            this.textBoxAvgPow.Location = new System.Drawing.Point(947, 567);
            this.textBoxAvgPow.Name = "textBoxAvgPow";
            this.textBoxAvgPow.ReadOnly = true;
            this.textBoxAvgPow.Size = new System.Drawing.Size(71, 20);
            this.textBoxAvgPow.TabIndex = 54;
            // 
            // textBoxVar
            // 
            this.textBoxVar.Location = new System.Drawing.Point(947, 529);
            this.textBoxVar.Name = "textBoxVar";
            this.textBoxVar.ReadOnly = true;
            this.textBoxVar.Size = new System.Drawing.Size(71, 20);
            this.textBoxVar.TabIndex = 53;
            // 
            // textBoxRMS
            // 
            this.textBoxRMS.Location = new System.Drawing.Point(947, 493);
            this.textBoxRMS.Name = "textBoxRMS";
            this.textBoxRMS.ReadOnly = true;
            this.textBoxRMS.Size = new System.Drawing.Size(71, 20);
            this.textBoxRMS.TabIndex = 52;
            // 
            // textBoxAbsAvg
            // 
            this.textBoxAbsAvg.Location = new System.Drawing.Point(947, 457);
            this.textBoxAbsAvg.Name = "textBoxAbsAvg";
            this.textBoxAbsAvg.ReadOnly = true;
            this.textBoxAbsAvg.Size = new System.Drawing.Size(71, 20);
            this.textBoxAbsAvg.TabIndex = 51;
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.Location = new System.Drawing.Point(947, 424);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.ReadOnly = true;
            this.textBoxAvg.Size = new System.Drawing.Size(71, 20);
            this.textBoxAvg.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(762, 496);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Wartość skuteczna";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(762, 532);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Wariancja";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(762, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Moc średnia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(762, 460);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Wartość średnia bezwzględna";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(762, 427);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Wartość średnia";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Dodany";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(6, 153);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 17);
            this.checkBox2.TabIndex = 57;
            this.checkBox2.Text = "Dodany";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnAddSignal2
            // 
            this.btnAddSignal2.Location = new System.Drawing.Point(6, 19);
            this.btnAddSignal2.Name = "btnAddSignal2";
            this.btnAddSignal2.Size = new System.Drawing.Size(121, 23);
            this.btnAddSignal2.TabIndex = 56;
            this.btnAddSignal2.Text = "Dodaj sygnał 2";
            this.btnAddSignal2.UseVisualStyleBackColor = true;
            this.btnAddSignal2.Click += new System.EventHandler(this.btnAddSignal2_Click);
            // 
            // btnPrintDoubleSingals
            // 
            this.btnPrintDoubleSingals.Enabled = false;
            this.btnPrintDoubleSingals.Location = new System.Drawing.Point(396, 482);
            this.btnPrintDoubleSingals.Name = "btnPrintDoubleSingals";
            this.btnPrintDoubleSingals.Size = new System.Drawing.Size(133, 23);
            this.btnPrintDoubleSingals.TabIndex = 59;
            this.btnPrintDoubleSingals.Text = "Rysuj obliczony sygnał";
            this.btnPrintDoubleSingals.UseVisualStyleBackColor = true;
            this.btnPrintDoubleSingals.Click += new System.EventHandler(this.btnPrintDoubleSingals_Click);
            // 
            // btnLoadFile2
            // 
            this.btnLoadFile2.Location = new System.Drawing.Point(6, 100);
            this.btnLoadFile2.Name = "btnLoadFile2";
            this.btnLoadFile2.Size = new System.Drawing.Size(121, 23);
            this.btnLoadFile2.TabIndex = 61;
            this.btnLoadFile2.Text = "Odczytaj z pliku";
            this.btnLoadFile2.UseVisualStyleBackColor = true;
            this.btnLoadFile2.Click += new System.EventHandler(this.btnLoadFile2_Click);
            // 
            // btnSaveFile2
            // 
            this.btnSaveFile2.Enabled = false;
            this.btnSaveFile2.Location = new System.Drawing.Point(6, 59);
            this.btnSaveFile2.Name = "btnSaveFile2";
            this.btnSaveFile2.Size = new System.Drawing.Size(121, 23);
            this.btnSaveFile2.TabIndex = 60;
            this.btnSaveFile2.Text = "Zapisz do pliku";
            this.btnSaveFile2.UseVisualStyleBackColor = true;
            this.btnSaveFile2.Click += new System.EventHandler(this.btnSaveFile2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSignal1);
            this.groupBox1.Controls.Add(this.btnSaveFile1);
            this.groupBox1.Controls.Add(this.btnLoadFile1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 176);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sygnal 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddSignal2);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.btnLoadFile2);
            this.groupBox2.Controls.Add(this.btnSaveFile2);
            this.groupBox2.Location = new System.Drawing.Point(187, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 176);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sygnal 2";
            // 
            // textBoxHistogram
            // 
            this.textBoxHistogram.Location = new System.Drawing.Point(570, 440);
            this.textBoxHistogram.Name = "textBoxHistogram";
            this.textBoxHistogram.Size = new System.Drawing.Size(121, 20);
            this.textBoxHistogram.TabIndex = 64;
            this.textBoxHistogram.TextChanged += new System.EventHandler(this.textBoxHistogram_TextChanged);
            this.textBoxHistogram.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHistogram_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(567, 424);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 13);
            this.label18.TabIndex = 65;
            this.label18.Text = "Przedziały histogramu";
            // 
            // btnPrintHistogram
            // 
            this.btnPrintHistogram.Enabled = false;
            this.btnPrintHistogram.Location = new System.Drawing.Point(570, 482);
            this.btnPrintHistogram.Name = "btnPrintHistogram";
            this.btnPrintHistogram.Size = new System.Drawing.Size(121, 23);
            this.btnPrintHistogram.TabIndex = 66;
            this.btnPrintHistogram.Text = "Rysuj histogram";
            this.btnPrintHistogram.UseVisualStyleBackColor = true;
            this.btnPrintHistogram.Click += new System.EventHandler(this.btnPrintHistogram_Click);
            // 
            // btnSaveCalculatedSignal
            // 
            this.btnSaveCalculatedSignal.Enabled = false;
            this.btnSaveCalculatedSignal.Location = new System.Drawing.Point(396, 524);
            this.btnSaveCalculatedSignal.Name = "btnSaveCalculatedSignal";
            this.btnSaveCalculatedSignal.Size = new System.Drawing.Size(133, 23);
            this.btnSaveCalculatedSignal.TabIndex = 67;
            this.btnSaveCalculatedSignal.Text = "Zapisz obliczony sygnał";
            this.btnSaveCalculatedSignal.UseVisualStyleBackColor = true;
            this.btnSaveCalculatedSignal.Click += new System.EventHandler(this.btnSaveCalculatedSignal_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(1053, 422);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(75, 23);
            this.btnAC.TabIndex = 68;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(1053, 455);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(75, 23);
            this.btnCA.TabIndex = 69;
            this.btnCA.Text = "CA";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // btnDoubleSingals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 612);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnSaveCalculatedSignal);
            this.Controls.Add(this.btnPrintHistogram);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxHistogram);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrintDoubleSingals);
            this.Controls.Add(this.textBoxAvgPow);
            this.Controls.Add(this.textBoxVar);
            this.Controls.Add(this.textBoxRMS);
            this.Controls.Add(this.textBoxAbsAvg);
            this.Controls.Add(this.textBoxAvg);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMathOperation);
            this.Controls.Add(this.textBoxp);
            this.Controls.Add(this.textBoxf);
            this.Controls.Add(this.textBoxts);
            this.Controls.Add(this.textBoxns);
            this.Controls.Add(this.textBoxn1);
            this.Controls.Add(this.textBoxkw);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxd);
            this.Controls.Add(this.textBoxt1);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSignal);
            this.Name = "btnDoubleSingals";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFile1;
        private System.Windows.Forms.Button btnLoadFile1;
        protected System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxt1;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxd;
        private System.Windows.Forms.TextBox textBoxn1;
        private System.Windows.Forms.TextBox textBoxkw;
        private System.Windows.Forms.TextBox textBoxts;
        private System.Windows.Forms.TextBox textBoxns;
        private System.Windows.Forms.TextBox textBoxp;
        private System.Windows.Forms.TextBox textBoxf;
        private System.Windows.Forms.Button btnAddSignal1;
        private System.Windows.Forms.ComboBox comboBoxMathOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAvgPow;
        private System.Windows.Forms.TextBox textBoxVar;
        private System.Windows.Forms.TextBox textBoxRMS;
        private System.Windows.Forms.TextBox textBoxAbsAvg;
        private System.Windows.Forms.TextBox textBoxAvg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnAddSignal2;
        private System.Windows.Forms.Button btnPrintDoubleSingals;
        private System.Windows.Forms.Button btnLoadFile2;
        private System.Windows.Forms.Button btnSaveFile2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxHistogram;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnPrintHistogram;
        private System.Windows.Forms.Button btnSaveCalculatedSignal;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnCA;
    }
}

