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
    }
}
