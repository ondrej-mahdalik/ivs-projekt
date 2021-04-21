
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnOpening = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnClosing = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtResult.Location = new System.Drawing.Point(12, 27);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(320, 44);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.WordWrap = false;
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.Color.White;
            this.btnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum1.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum1.Location = new System.Drawing.Point(3, 215);
            this.btnNum1.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(58, 47);
            this.btnNum1.TabIndex = 11;
            this.btnNum1.TabStop = false;
            this.btnNum1.Tag = "1";
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.White;
            this.btnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum3.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum3.Location = new System.Drawing.Point(131, 215);
            this.btnNum3.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(58, 47);
            this.btnNum3.TabIndex = 13;
            this.btnNum3.TabStop = false;
            this.btnNum3.Tag = "3";
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.Color.White;
            this.btnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum2.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum2.Location = new System.Drawing.Point(67, 215);
            this.btnNum2.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(58, 47);
            this.btnNum2.TabIndex = 12;
            this.btnNum2.TabStop = false;
            this.btnNum2.Tag = "2";
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.BtnClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnPi, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPaste, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFactorial, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPower, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnBackspace, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNum0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnEnter, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNum1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSub, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnComma, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnRoot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOpening, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnLog, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClosing, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAbs, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 322);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.White;
            this.btnPi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPi.ForeColor = System.Drawing.Color.DimGray;
            this.btnPi.Location = new System.Drawing.Point(3, 3);
            this.btnPi.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(58, 47);
            this.btnPi.TabIndex = 24;
            this.btnPi.TabStop = false;
            this.btnPi.Tag = "π";
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.LightGray;
            this.btnPaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPaste.ForeColor = System.Drawing.Color.DimGray;
            this.btnPaste.Location = new System.Drawing.Point(131, 3);
            this.btnPaste.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(58, 47);
            this.btnPaste.TabIndex = 23;
            this.btnPaste.TabStop = false;
            this.btnPaste.Tag = "";
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.LightGray;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCopy.ForeColor = System.Drawing.Color.DimGray;
            this.btnCopy.Location = new System.Drawing.Point(67, 3);
            this.btnCopy.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(58, 47);
            this.btnCopy.TabIndex = 22;
            this.btnCopy.TabStop = false;
            this.btnCopy.Tag = "";
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.LightCyan;
            this.btnFactorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFactorial.ForeColor = System.Drawing.Color.Teal;
            this.btnFactorial.Location = new System.Drawing.Point(259, 56);
            this.btnFactorial.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(58, 47);
            this.btnFactorial.TabIndex = 21;
            this.btnFactorial.TabStop = false;
            this.btnFactorial.Tag = "!";
            this.btnFactorial.Text = "x!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.LightCyan;
            this.btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPower.ForeColor = System.Drawing.Color.Teal;
            this.btnPower.Location = new System.Drawing.Point(195, 56);
            this.btnPower.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(58, 47);
            this.btnPower.TabIndex = 20;
            this.btnPower.TabStop = false;
            this.btnPower.Tag = "^";
            this.btnPower.Text = "x^y";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.MistyRose;
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBackspace.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBackspace.Location = new System.Drawing.Point(195, 3);
            this.btnBackspace.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(58, 47);
            this.btnBackspace.TabIndex = 6;
            this.btnBackspace.TabStop = false;
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.BtnBackspaceClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MistyRose;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClear.Location = new System.Drawing.Point(259, 3);
            this.btnClear.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 47);
            this.btnClear.TabIndex = 6;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.Color.White;
            this.btnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum0.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum0.Location = new System.Drawing.Point(67, 268);
            this.btnNum0.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(58, 51);
            this.btnNum0.TabIndex = 10;
            this.btnNum0.TabStop = false;
            this.btnNum0.Tag = "0";
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.LightGray;
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDecimal.ForeColor = System.Drawing.Color.DimGray;
            this.btnDecimal.Location = new System.Drawing.Point(131, 268);
            this.btnDecimal.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(58, 51);
            this.btnDecimal.TabIndex = 8;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Tag = ".";
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.btnEnter, 2);
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEnter.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEnter.Location = new System.Drawing.Point(195, 268);
            this.btnEnter.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(122, 51);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.TabStop = false;
            this.btnEnter.Tag = "";
            this.btnEnter.Text = "=";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Bisque;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAdd.Location = new System.Drawing.Point(195, 215);
            this.btnAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 47);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TabStop = false;
            this.btnAdd.Tag = "+";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.Color.White;
            this.btnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum4.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum4.Location = new System.Drawing.Point(3, 162);
            this.btnNum4.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(58, 47);
            this.btnNum4.TabIndex = 14;
            this.btnNum4.TabStop = false;
            this.btnNum4.Tag = "4";
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.Color.White;
            this.btnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum5.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum5.Location = new System.Drawing.Point(67, 162);
            this.btnNum5.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(58, 47);
            this.btnNum5.TabIndex = 15;
            this.btnNum5.TabStop = false;
            this.btnNum5.Tag = "5";
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.Color.White;
            this.btnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum6.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum6.Location = new System.Drawing.Point(131, 162);
            this.btnNum6.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(58, 47);
            this.btnNum6.TabIndex = 16;
            this.btnNum6.TabStop = false;
            this.btnNum6.Tag = "6";
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Bisque;
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSub.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSub.Location = new System.Drawing.Point(259, 215);
            this.btnSub.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(58, 47);
            this.btnSub.TabIndex = 6;
            this.btnSub.TabStop = false;
            this.btnSub.Tag = "-";
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.Color.White;
            this.btnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum7.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum7.Location = new System.Drawing.Point(3, 109);
            this.btnNum7.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(58, 47);
            this.btnNum7.TabIndex = 17;
            this.btnNum7.TabStop = false;
            this.btnNum7.Tag = "7";
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.Color.White;
            this.btnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum8.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum8.Location = new System.Drawing.Point(67, 109);
            this.btnNum8.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(58, 47);
            this.btnNum8.TabIndex = 18;
            this.btnNum8.TabStop = false;
            this.btnNum8.Tag = "8";
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.Color.White;
            this.btnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNum9.ForeColor = System.Drawing.Color.DimGray;
            this.btnNum9.Location = new System.Drawing.Point(131, 109);
            this.btnNum9.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(58, 47);
            this.btnNum9.TabIndex = 19;
            this.btnNum9.TabStop = false;
            this.btnNum9.Tag = "9";
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Bisque;
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMultiply.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMultiply.Location = new System.Drawing.Point(195, 162);
            this.btnMultiply.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(58, 47);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Tag = "*";
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Bisque;
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDivide.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDivide.Location = new System.Drawing.Point(259, 162);
            this.btnDivide.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(58, 47);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.TabStop = false;
            this.btnDivide.Tag = "/";
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.LightGray;
            this.btnComma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnComma.ForeColor = System.Drawing.Color.DimGray;
            this.btnComma.Location = new System.Drawing.Point(3, 268);
            this.btnComma.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(58, 51);
            this.btnComma.TabIndex = 6;
            this.btnComma.TabStop = false;
            this.btnComma.Tag = ",";
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            this.btnComma.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.LightCyan;
            this.btnRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRoot.ForeColor = System.Drawing.Color.Teal;
            this.btnRoot.Location = new System.Drawing.Point(3, 56);
            this.btnRoot.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(58, 47);
            this.btnRoot.TabIndex = 1;
            this.btnRoot.TabStop = false;
            this.btnRoot.Tag = "Root(";
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnOpening
            // 
            this.btnOpening.BackColor = System.Drawing.Color.LightGray;
            this.btnOpening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpening.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnOpening.ForeColor = System.Drawing.Color.DimGray;
            this.btnOpening.Location = new System.Drawing.Point(195, 109);
            this.btnOpening.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnOpening.Name = "btnOpening";
            this.btnOpening.Size = new System.Drawing.Size(58, 47);
            this.btnOpening.TabIndex = 6;
            this.btnOpening.TabStop = false;
            this.btnOpening.Tag = "(";
            this.btnOpening.Text = "(";
            this.btnOpening.UseVisualStyleBackColor = false;
            this.btnOpening.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.LightCyan;
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLog.ForeColor = System.Drawing.Color.Teal;
            this.btnLog.Location = new System.Drawing.Point(67, 56);
            this.btnLog.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(58, 47);
            this.btnLog.TabIndex = 2;
            this.btnLog.TabStop = false;
            this.btnLog.Tag = "Log(";
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnClosing
            // 
            this.btnClosing.BackColor = System.Drawing.Color.LightGray;
            this.btnClosing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClosing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClosing.ForeColor = System.Drawing.Color.DimGray;
            this.btnClosing.Location = new System.Drawing.Point(259, 109);
            this.btnClosing.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnClosing.Name = "btnClosing";
            this.btnClosing.Size = new System.Drawing.Size(58, 47);
            this.btnClosing.TabIndex = 3;
            this.btnClosing.TabStop = false;
            this.btnClosing.Tag = ")";
            this.btnClosing.Text = ")";
            this.btnClosing.UseVisualStyleBackColor = false;
            this.btnClosing.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.LightCyan;
            this.btnAbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAbs.ForeColor = System.Drawing.Color.Teal;
            this.btnAbs.Location = new System.Drawing.Point(131, 56);
            this.btnAbs.MinimumSize = new System.Drawing.Size(30, 30);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(58, 47);
            this.btnAbs.TabIndex = 6;
            this.btnAbs.TabStop = false;
            this.btnAbs.Tag = "Abs(";
            this.btnAbs.Text = "Abs";
            this.btnAbs.UseVisualStyleBackColor = false;
            this.btnAbs.Click += new System.EventHandler(this.BtnClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(228, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(104, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "Help";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 411);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(360, 450);
            this.Name = "MainWindow";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleKeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnClosing;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnOpening;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnPower;
    }
}

