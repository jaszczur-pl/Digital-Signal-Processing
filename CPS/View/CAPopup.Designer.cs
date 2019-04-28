namespace CPS.View
{
    partial class CAPopup
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxfs = new System.Windows.Forms.TextBox();
            this.textBoxfk = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Częstotliwość próbkowania sygnału (fs)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Częstotliwość konwersji (fk)\r\n";
            // 
            // textBoxfs
            // 
            this.textBoxfs.Location = new System.Drawing.Point(232, 12);
            this.textBoxfs.Name = "textBoxfs";
            this.textBoxfs.Size = new System.Drawing.Size(100, 20);
            this.textBoxfs.TabIndex = 2;
            // 
            // textBoxfk
            // 
            this.textBoxfk.Location = new System.Drawing.Point(232, 53);
            this.textBoxfk.Name = "textBoxfk";
            this.textBoxfk.Size = new System.Drawing.Size(100, 20);
            this.textBoxfk.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(38, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CAPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxfk);
            this.Controls.Add(this.textBoxfs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CAPopup";
            this.Text = "CAPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfs;
        private System.Windows.Forms.TextBox textBoxfk;
        private System.Windows.Forms.Button btnOK;
    }
}