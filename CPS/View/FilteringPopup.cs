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
    public partial class FilteringPopup : Form
    {

        public int FilteringLevel { get; set; }
        public int CutFrequency { get; set; }
        public string FilterType { get; set; }
        public string WindowType { get; set; }

        public FilteringPopup() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBoxFilterLevel.Text) || (comboBoxFilterType.SelectedItem) == null
                || comboBoxWindowType.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxCutFrequency.Text))  {
                MessageBox.Show("Proszę wypełnić wszystkie parametry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                FilteringLevel = Convert.ToInt32(textBoxFilterLevel.Text);
                CutFrequency = Convert.ToInt32(textBoxCutFrequency.Text);
                FilterType = comboBoxFilterType.SelectedText;
                WindowType = comboBoxWindowType.SelectedText;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
