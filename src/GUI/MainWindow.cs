using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math;

namespace GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            
            switch (button.Tag) {
                case "num":
                    txtResult.Text += button.Text;
                    break;

                case "decimal":
                    txtResult.Text += ".";
                    break;

                case "fncMultiply":
                    txtResult.Text += "*";
                    break;

                case "fncDivide":
                    txtResult.Text += "/";
                    break;

                case "fncAdd":
                    txtResult.Text += "+";
                    break;

                case "fncSub":
                    txtResult.Text += "-";
                    break;
            }
        }

        private void Backspace()
        {
            if (txtResult.Text.Length > 0)
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }

        private void BtnClear(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void BtnEnter(object sender, EventArgs e)
        {
            string result = "";
            try {
                result = MathClass.FromString(txtResult.Text).ToString();
            }
            catch (Exception ex) {
                result = ex.Message;
            }
            finally {
                txtResult.Text = result;
            }
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            // Ctrl + C
            if (e.Control && e.KeyCode == Keys.C) {
                Clipboard.SetText(txtResult.Text);
                return;
            }

            switch(e.KeyCode) {
                
                // Enter Button
                case Keys.Enter:
                    btnEnter.PerformClick();
                    break;

                // Delete Button
                case Keys.Delete:
                case Keys.Escape:
                    btnClear.PerformClick();
                    break;

                // Backspace Button
                case Keys.Back:
                    Backspace();
                    break;

                // Numbers
                case Keys.D0:
                case Keys.NumPad0:
                    btnNum0.PerformClick();
                    break;

                case Keys.D1:
                case Keys.NumPad1:
                    btnNum1.PerformClick();
                    break;

                case Keys.D2:
                case Keys.NumPad2:
                    btnNum2.PerformClick();
                    break;

                case Keys.D3:
                case Keys.NumPad3:
                    btnNum3.PerformClick();
                    break;

                case Keys.D4:
                case Keys.NumPad4:
                    btnNum4.PerformClick();
                    break;

                case Keys.D5:
                case Keys.NumPad5:
                    btnNum5.PerformClick();
                    break;

                case Keys.D6:
                case Keys.NumPad6:
                    btnNum6.PerformClick();
                    break;

                case Keys.D7:
                case Keys.NumPad7:
                    btnNum7.PerformClick();
                    break;

                case Keys.D8:
                case Keys.NumPad8:
                    btnNum8.PerformClick();
                    break;

                case Keys.D9:
                case Keys.NumPad9:
                    btnNum9.PerformClick();
                    break;

                // Operators
                case Keys.Add:
                    btnAdd.PerformClick();
                    break;

                case Keys.Subtract:
                    btnSub.PerformClick();
                    break;

                case Keys.Multiply:
                    btnMultiply.PerformClick();
                    break;

                case Keys.Divide:
                    btnDivide.PerformClick();
                    break;
            }
        }
    }
}
