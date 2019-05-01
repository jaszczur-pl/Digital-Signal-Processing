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
    public partial class CAPopup : Form
    {
        public bool Status { get; set; } = false;

        public CAPopup() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBoxfs.Text) || string.IsNullOrWhiteSpace(textBoxfk.Text)) {
                MessageBox.Show("Parametry 'fs' i 'fk' nie moga być puste!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                Status = true;
                this.Close();
            }
        }
    }
}
