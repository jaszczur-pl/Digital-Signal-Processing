namespace CPS.View
{
    partial class FilteringPopup
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
            this.textBoxFilterLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWindowType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCutFrequency = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFilterLevel
            // 
            this.textBoxFilterLevel.Location = new System.Drawing.Point(144, 12);
            this.textBoxFilterLevel.Name = "textBoxFilterLevel";
            this.textBoxFilterLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterLevel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rząd filtru:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(26, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Items.AddRange(new object[] {
            "Dolnoprzepustowy",
            "Górnoprzepustowy"});
            this.comboBoxFilterType.Location = new System.Drawing.Point(144, 83);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rodzaj filtru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rodzaj okna:";
            // 
            // comboBoxWindowType
            // 
            this.comboBoxWindowType.FormattingEnabled = true;
            this.comboBoxWindowType.Items.AddRange(new object[] {
            "Prostokątny",
            "Hanninga"});
            this.comboBoxWindowType.Location = new System.Drawing.Point(144, 120);
            this.comboBoxWindowType.Name = "comboBoxWindowType";
            this.comboBoxWindowType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWindowType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Częstotliwość odcięcia:";
            // 
            // textBoxCutFrequency
            // 
            this.textBoxCutFrequency.Location = new System.Drawing.Point(144, 47);
            this.textBoxCutFrequency.Name = "textBoxCutFrequency";
            this.textBoxCutFrequency.Size = new System.Drawing.Size(100, 20);
            this.textBoxCutFrequency.TabIndex = 7;
            // 
            // FilteringPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCutFrequency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxWindowType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFilterType);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilterLevel);
            this.Name = "FilteringPopup";
            this.Text = "FilteringPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilterLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWindowType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCutFrequency;
    }
}