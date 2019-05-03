using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPS.View
{
    public partial class ACPopup : Form
    {
        public double Fs { get; set; }
        public int B { get; set; }

        public ACPopup() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBoxfs.Text) || string.IsNullOrWhiteSpace(textBoxb.Text)) {
                MessageBox.Show("Parametry 'fs' i 'b' nie moga być puste!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                Fs = Convert.ToDouble(textBoxfs.Text);
                B = Convert.ToInt32(textBoxb.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
    }
}
