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
        public string Fs { get; set; }
        public string B { get; set; }

        public ACPopup() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBoxfs.Text) || string.IsNullOrWhiteSpace(textBoxb.Text)) {
                MessageBox.Show("Parametry 'fs' i 'b' nie moga być puste!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                Fs = textBoxfs.Text;
                B = textBoxb.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
    }
}
