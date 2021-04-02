
namespace GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelResult = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.panelResult.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelResult.Controls.Add(this.txtResult);
            this.panelResult.Location = new System.Drawing.Point(12, 12);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(260, 58);
            this.panelResult.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(260, 56);
            this.txtResult.TabIndex = 0;
            this.txtResult.WordWrap = false;
            // 
            // btnNum1
            // 
            this.btnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum1.Location = new System.Drawing.Point(3, 183);
            this.btnNum1.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(59, 54);
            this.btnNum1.TabIndex = 11;
            this.btnNum1.TabStop = false;
            this.btnNum1.Tag = "num";
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum3
            // 
            this.btnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum3.Location = new System.Drawing.Point(133, 183);
            this.btnNum3.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(59, 54);
            this.btnNum3.TabIndex = 13;
            this.btnNum3.TabStop = false;
            this.btnNum3.Tag = "num";
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum2
            // 
            this.btnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum2.Location = new System.Drawing.Point(68, 183);
            this.btnNum2.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(59, 54);
            this.btnNum2.TabIndex = 12;
            this.btnNum2.TabStop = false;
            this.btnNum2.Tag = "num";
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.BtnClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNum8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNum9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSub, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEnter, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimal, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 303);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(3, 243);
            this.btnClear.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 57);
            this.btnClear.TabIndex = 10;
            this.btnClear.TabStop = false;
            this.btnClear.Tag = "";
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear);
            // 
            // btnNum0
            // 
            this.btnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum0.Location = new System.Drawing.Point(68, 243);
            this.btnNum0.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(59, 57);
            this.btnNum0.TabIndex = 10;
            this.btnNum0.TabStop = false;
            this.btnNum0.Tag = "num";
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum4
            // 
            this.btnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum4.Location = new System.Drawing.Point(3, 123);
            this.btnNum4.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(59, 54);
            this.btnNum4.TabIndex = 14;
            this.btnNum4.TabStop = false;
            this.btnNum4.Tag = "num";
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum5
            // 
            this.btnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum5.Location = new System.Drawing.Point(68, 123);
            this.btnNum5.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(59, 54);
            this.btnNum5.TabIndex = 15;
            this.btnNum5.TabStop = false;
            this.btnNum5.Tag = "num";
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum6
            // 
            this.btnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum6.Location = new System.Drawing.Point(133, 123);
            this.btnNum6.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(59, 54);
            this.btnNum6.TabIndex = 16;
            this.btnNum6.TabStop = false;
            this.btnNum6.Tag = "num";
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum7
            // 
            this.btnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum7.Location = new System.Drawing.Point(3, 63);
            this.btnNum7.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(59, 54);
            this.btnNum7.TabIndex = 17;
            this.btnNum7.TabStop = false;
            this.btnNum7.Tag = "num";
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum8
            // 
            this.btnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum8.Location = new System.Drawing.Point(68, 63);
            this.btnNum8.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(59, 54);
            this.btnNum8.TabIndex = 18;
            this.btnNum8.TabStop = false;
            this.btnNum8.Tag = "num";
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum9
            // 
            this.btnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum9.Location = new System.Drawing.Point(133, 63);
            this.btnNum9.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(59, 54);
            this.btnNum9.TabIndex = 19;
            this.btnNum9.TabStop = false;
            this.btnNum9.Tag = "num";
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.BtnClick);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.MinimumSize = new System.Drawing.Size(30, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 54);
            this.button8.TabIndex = 1;
            this.button8.Text = "TODO";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Enabled = false;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(68, 3);
            this.button9.MinimumSize = new System.Drawing.Size(30, 30);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 54);
            this.button9.TabIndex = 2;
            this.button9.Text = "TODO";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(133, 3);
            this.button10.MinimumSize = new System.Drawing.Size(30, 30);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(59, 54);
            this.button10.TabIndex = 3;
            this.button10.Text = "TODO";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDivide.Location = new System.Drawing.Point(198, 3);
            this.btnDivide.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(59, 54);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Tag = "fncDivide";
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMultiply.Location = new System.Drawing.Point(198, 63);
            this.btnMultiply.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(59, 54);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Tag = "fncMultiply";
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnSub
            // 
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSub.Location = new System.Drawing.Point(198, 123);
            this.btnSub.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(59, 54);
            this.btnSub.TabIndex = 6;
            this.btnSub.Tag = "fncSub";
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(198, 183);
            this.btnAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 54);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Tag = "fncAdd";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnEnter
            // 
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnter.Location = new System.Drawing.Point(198, 243);
            this.btnEnter.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(59, 57);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Tag = "";
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDecimal.Location = new System.Drawing.Point(133, 243);
            this.btnDecimal.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(59, 57);
            this.btnDecimal.TabIndex = 8;
            this.btnDecimal.Tag = "decimal";
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.BtnClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelResult);
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 430);
            this.Name = "MainWindow";
            this.Text = "Kalkulačka";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyPress);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
    }
}

