using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Math;

namespace GUI
{
    /// <summary>
    ///     Main window of the application.
    ///     Contains the interface to control all calculator functions.
    /// </summary>
    public partial class MainWindow : Form
    {
        private bool writeEnabled = true;

        /// <summary>
        ///     Constructor, initializes form components.
        ///     Use .Show() to display the form.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Function that handles all "generic" button clicks.
        ///     Called by the OnClick event of the respective buttons.
        /// </summary>
        private void BtnClick(object sender, EventArgs e)
        {
            if (writeEnabled)
                txtResult.Text += (sender as Button)?.Tag;

            // Focus on result key to enable calculating result with Enter key
            btnEnter.Focus();
        }

        /// <summary>
        ///     Function for cleaning the expression box.
        ///     Called by the OnClick event of the btnClear button.
        /// </summary>
        private void BtnClearClick(object sender, EventArgs e)
        {
            txtResult.Text = "";
            writeEnabled = true;

            // Focus on result key to enable calculating result with Enter key
            btnEnter.Focus();
        }

        /// <summary>
        ///     Function for sending the current expression to the Math library.
        ///     Called by the OnClick event of the btnEnter button.
        /// </summary>
        private void BtnEnterClick(object sender, EventArgs e)
        {
            // To only calculate result when there is an expression to be calculated.
            if (string.IsNullOrWhiteSpace(txtResult.Text))
                return;

            string result = "";
            try {
                result = MathClass.FromString(txtResult.Text).ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception ex) {
                result = ex.Message;
                writeEnabled = false;
            }
            finally {
                txtResult.Text = result;
            }

            // Focus on result key to enable calculating result with Enter key
            btnEnter.Focus();
        }

        /// <summary>
        ///     Function for copying the expression to clipboard.
        ///     Called by the OnClick event of the btnCopy button.
        /// </summary>
        private void BtnCopyClick(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
                Clipboard.SetText(txtResult.Text);

            // Focus on result key to enable calculating result with Enter key
            btnEnter.Focus();
        }

        /// <summary>
        ///     Function for pasting expression from clipboard.
        ///     Called by the OnClick event of the btnPaste button.
        /// </summary>
        private void BtnPasteClick(object sender, EventArgs e)
        {
            if (writeEnabled)
                txtResult.Text += Clipboard.GetText();

            // Focus on result key to enable calculating result with Enter key
            btnEnter.Focus();
        }

        /// <summary>
        ///     Function for removing last character in the expression.
        ///     Called by the OnClick event of btnBackspace button.
        /// </summary>
        private void BtnBackspaceClick(object sender, EventArgs e)
        {
            if (writeEnabled && txtResult.Text.Length > 0)
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);

            // Focus on result key to enable calculating result with Enter key
            btnEnter.Focus();
        }

        /// <summary>
        ///     Opens new Help window.
        ///     Does not check if there is a Help Window already opened,
        ///     therefore it's possible to have multiple Help windows opened.
        ///     Called by the OnClick event of the btnHelp button.
        /// </summary>
        private void BtnHelpClick(object sender, EventArgs e)
        {
            new HelpWindow().Show();
        }

        /// <summary>
        ///     Opens new About window.
        ///     Does not check if there is an About window already opened,
        ///     therefore it's possible to have multiple About windows opened.
        ///     Called by the OnClick event of the btnAbout button.
        /// </summary>
        private void BtnAboutClick(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }

        /// <summary>
        ///     Stay on top switch
        ///     When called, checks for the btnStayOnTop button's Checked status
        ///     and sets the TopMost feature's value accordingly.
        /// </summary>
        private void BtnStayOnTopCheckedChanged(object sender, EventArgs e)
        {
            TopMost = btnStayOnTop.Checked;

            if (btnStayOnTop.Checked)
                btnStayOnTop.ForeColor = Color.ForestGreen;
            else
                btnStayOnTop.ForeColor = default;
        }

        /// <summary>
        ///     Function for handling key presses.
        ///     Provides keyboard support for the UI.
        /// </summary>
        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            // Ctrl + C
            if (e.Control && e.KeyCode == Keys.C) {
                btnCopy.PerformClick();
                return;
            }

            // Ctrl + V
            if (e.Control && e.KeyCode == Keys.V) {
                btnPaste.PerformClick();
                return;
            }

            switch (e.KeyCode) {
                // Brackets
                case Keys.OemOpenBrackets:
                    btnOpening.PerformClick();
                    break;

                case Keys.OemCloseBrackets:
                    btnClosing.PerformClick();
                    break;

                // Dash and dot
                case Keys.Decimal:
                case Keys.OemPeriod:
                    btnDecimal.PerformClick();
                    break;

                case Keys.Oemcomma:
                    btnComma.PerformClick();
                    break;

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
                    btnBackspace.PerformClick();
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
