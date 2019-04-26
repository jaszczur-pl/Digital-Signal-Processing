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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
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
            this.textBoxMs = new System.Windows.Forms.TextBox();
            this.textBoxWar = new System.Windows.Forms.TextBox();
            this.textBoxWsk = new System.Windows.Forms.TextBox();
            this.textBoxWsb = new System.Windows.Forms.TextBox();
            this.textBoxWsr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnAddSignal2 = new System.Windows.Forms.Button();
            this.btnPrintSingleSignal = new System.Windows.Forms.Button();
            this.btnPrintDoubleSingals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(12, 493);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(146, 23);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Zapisz do pliku";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 534);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(146, 23);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.Text = "Odczytaj z pliku";
            this.btnLoadFile.UseVisualStyleBackColor = true;
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(347, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(693, 25);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(300, 300);
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
            this.btnAddSignal1.Location = new System.Drawing.Point(187, 449);
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
            this.comboBoxMathOperation.Location = new System.Drawing.Point(402, 451);
            this.comboBoxMathOperation.Name = "comboBoxMathOperation";
            this.comboBoxMathOperation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMathOperation.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Operacja matematyczna";
            // 
            // textBoxMs
            // 
            this.textBoxMs.Location = new System.Drawing.Point(922, 498);
            this.textBoxMs.Name = "textBoxMs";
            this.textBoxMs.ReadOnly = true;
            this.textBoxMs.Size = new System.Drawing.Size(71, 20);
            this.textBoxMs.TabIndex = 54;
            // 
            // textBoxWar
            // 
            this.textBoxWar.Location = new System.Drawing.Point(922, 460);
            this.textBoxWar.Name = "textBoxWar";
            this.textBoxWar.ReadOnly = true;
            this.textBoxWar.Size = new System.Drawing.Size(71, 20);
            this.textBoxWar.TabIndex = 53;
            // 
            // textBoxWsk
            // 
            this.textBoxWsk.Location = new System.Drawing.Point(922, 424);
            this.textBoxWsk.Name = "textBoxWsk";
            this.textBoxWsk.ReadOnly = true;
            this.textBoxWsk.Size = new System.Drawing.Size(71, 20);
            this.textBoxWsk.TabIndex = 52;
            // 
            // textBoxWsb
            // 
            this.textBoxWsb.Location = new System.Drawing.Point(922, 388);
            this.textBoxWsb.Name = "textBoxWsb";
            this.textBoxWsb.ReadOnly = true;
            this.textBoxWsb.Size = new System.Drawing.Size(71, 20);
            this.textBoxWsb.TabIndex = 51;
            // 
            // textBoxWsr
            // 
            this.textBoxWsr.Location = new System.Drawing.Point(922, 355);
            this.textBoxWsr.Name = "textBoxWsr";
            this.textBoxWsr.ReadOnly = true;
            this.textBoxWsr.Size = new System.Drawing.Size(71, 20);
            this.textBoxWsr.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(737, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Wartość skuteczna";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(737, 463);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Wariancja";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(737, 501);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Moc średnia";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(737, 391);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Wartość średnia bezwzględna";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(737, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Wartość średnia";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(315, 455);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Sygnał 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(315, 499);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 57;
            this.checkBox2.Text = "Sygnał 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnAddSignal2
            // 
            this.btnAddSignal2.Location = new System.Drawing.Point(188, 493);
            this.btnAddSignal2.Name = "btnAddSignal2";
            this.btnAddSignal2.Size = new System.Drawing.Size(121, 23);
            this.btnAddSignal2.TabIndex = 56;
            this.btnAddSignal2.Text = "Dodaj sygnał 2";
            this.btnAddSignal2.UseVisualStyleBackColor = true;
            // 
            // btnPrintSingleSignal
            // 
            this.btnPrintSingleSignal.Location = new System.Drawing.Point(12, 449);
            this.btnPrintSingleSignal.Name = "btnPrintSingleSignal";
            this.btnPrintSingleSignal.Size = new System.Drawing.Size(146, 23);
            this.btnPrintSingleSignal.TabIndex = 58;
            this.btnPrintSingleSignal.Text = "Rysuj pojedynczy sygnał";
            this.btnPrintSingleSignal.UseVisualStyleBackColor = true;
            // 
            // btnPrintDoubleSingals
            // 
            this.btnPrintDoubleSingals.Location = new System.Drawing.Point(402, 493);
            this.btnPrintDoubleSingals.Name = "btnPrintDoubleSingals";
            this.btnPrintDoubleSingals.Size = new System.Drawing.Size(121, 23);
            this.btnPrintDoubleSingals.TabIndex = 59;
            this.btnPrintDoubleSingals.Text = "Rysuj sygnały";
            this.btnPrintDoubleSingals.UseVisualStyleBackColor = true;
            // 
            // btnDoubleSingals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 612);
            this.Controls.Add(this.btnPrintDoubleSingals);
            this.Controls.Add(this.btnPrintSingleSignal);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btnAddSignal2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxMs);
            this.Controls.Add(this.textBoxWar);
            this.Controls.Add(this.textBoxWsk);
            this.Controls.Add(this.textBoxWsb);
            this.Controls.Add(this.textBoxWsr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMathOperation);
            this.Controls.Add(this.btnAddSignal1);
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
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSignal);
            this.Name = "btnDoubleSingals";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnLoadFile;
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
        private System.Windows.Forms.TextBox textBoxMs;
        private System.Windows.Forms.TextBox textBoxWar;
        private System.Windows.Forms.TextBox textBoxWsk;
        private System.Windows.Forms.TextBox textBoxWsb;
        private System.Windows.Forms.TextBox textBoxWsr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnAddSignal2;
        private System.Windows.Forms.Button btnPrintSingleSignal;
        private System.Windows.Forms.Button btnPrintDoubleSingals;
    }
}

