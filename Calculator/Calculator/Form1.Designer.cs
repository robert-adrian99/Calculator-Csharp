namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rezultat = new System.Windows.Forms.TextBox();
            this.sapte = new System.Windows.Forms.Button();
            this.opt = new System.Windows.Forms.Button();
            this.noua = new System.Windows.Forms.Button();
            this.patru = new System.Windows.Forms.Button();
            this.cinci = new System.Windows.Forms.Button();
            this.sase = new System.Windows.Forms.Button();
            this.unu = new System.Windows.Forms.Button();
            this.doi = new System.Windows.Forms.Button();
            this.trei = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.mplus = new System.Windows.Forms.Button();
            this.mminus = new System.Windows.Forms.Button();
            this.mview = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.semn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rezultat
            // 
            this.rezultat.BackColor = System.Drawing.Color.Silver;
            this.rezultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezultat.Cursor = System.Windows.Forms.Cursors.Default;
            this.rezultat.Enabled = false;
            this.rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rezultat.Location = new System.Drawing.Point(13, 19);
            this.rezultat.Margin = new System.Windows.Forms.Padding(4);
            this.rezultat.MaxLength = 2000000000;
            this.rezultat.Name = "rezultat";
            this.rezultat.ReadOnly = true;
            this.rezultat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.rezultat.Size = new System.Drawing.Size(630, 42);
            this.rezultat.TabIndex = 0;
            this.rezultat.Text = "0";
            this.rezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sapte
            // 
            this.sapte.BackColor = System.Drawing.Color.Silver;
            this.sapte.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sapte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sapte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sapte.Location = new System.Drawing.Point(13, 229);
            this.sapte.Margin = new System.Windows.Forms.Padding(4);
            this.sapte.Name = "sapte";
            this.sapte.Size = new System.Drawing.Size(151, 62);
            this.sapte.TabIndex = 4;
            this.sapte.Text = "7";
            this.sapte.UseVisualStyleBackColor = false;
            this.sapte.Click += new System.EventHandler(this.Numere);
            // 
            // opt
            // 
            this.opt.BackColor = System.Drawing.Color.Silver;
            this.opt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opt.Location = new System.Drawing.Point(173, 229);
            this.opt.Margin = new System.Windows.Forms.Padding(4);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(151, 62);
            this.opt.TabIndex = 5;
            this.opt.Text = "8";
            this.opt.UseVisualStyleBackColor = false;
            this.opt.Click += new System.EventHandler(this.Numere);
            // 
            // noua
            // 
            this.noua.BackColor = System.Drawing.Color.Silver;
            this.noua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noua.Location = new System.Drawing.Point(333, 229);
            this.noua.Margin = new System.Windows.Forms.Padding(4);
            this.noua.Name = "noua";
            this.noua.Size = new System.Drawing.Size(151, 62);
            this.noua.TabIndex = 6;
            this.noua.Text = "9";
            this.noua.UseVisualStyleBackColor = false;
            this.noua.Click += new System.EventHandler(this.Numere);
            // 
            // patru
            // 
            this.patru.BackColor = System.Drawing.Color.Silver;
            this.patru.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.patru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patru.ForeColor = System.Drawing.SystemColors.ControlText;
            this.patru.Location = new System.Drawing.Point(13, 299);
            this.patru.Margin = new System.Windows.Forms.Padding(4);
            this.patru.Name = "patru";
            this.patru.Size = new System.Drawing.Size(151, 62);
            this.patru.TabIndex = 7;
            this.patru.Text = "4";
            this.patru.UseVisualStyleBackColor = false;
            this.patru.Click += new System.EventHandler(this.Numere);
            // 
            // cinci
            // 
            this.cinci.BackColor = System.Drawing.Color.Silver;
            this.cinci.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cinci.Location = new System.Drawing.Point(173, 299);
            this.cinci.Margin = new System.Windows.Forms.Padding(4);
            this.cinci.Name = "cinci";
            this.cinci.Size = new System.Drawing.Size(151, 62);
            this.cinci.TabIndex = 8;
            this.cinci.Text = "5";
            this.cinci.UseVisualStyleBackColor = false;
            this.cinci.Click += new System.EventHandler(this.Numere);
            // 
            // sase
            // 
            this.sase.BackColor = System.Drawing.Color.Silver;
            this.sase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sase.Location = new System.Drawing.Point(333, 299);
            this.sase.Margin = new System.Windows.Forms.Padding(4);
            this.sase.Name = "sase";
            this.sase.Size = new System.Drawing.Size(151, 62);
            this.sase.TabIndex = 9;
            this.sase.Text = "6";
            this.sase.UseVisualStyleBackColor = false;
            this.sase.Click += new System.EventHandler(this.Numere);
            // 
            // unu
            // 
            this.unu.BackColor = System.Drawing.Color.Silver;
            this.unu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.unu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unu.Location = new System.Drawing.Point(13, 369);
            this.unu.Margin = new System.Windows.Forms.Padding(4);
            this.unu.Name = "unu";
            this.unu.Size = new System.Drawing.Size(151, 62);
            this.unu.TabIndex = 10;
            this.unu.Text = "1";
            this.unu.UseVisualStyleBackColor = false;
            this.unu.Click += new System.EventHandler(this.Numere);
            // 
            // doi
            // 
            this.doi.BackColor = System.Drawing.Color.Silver;
            this.doi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.doi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.doi.Location = new System.Drawing.Point(173, 369);
            this.doi.Margin = new System.Windows.Forms.Padding(4);
            this.doi.Name = "doi";
            this.doi.Size = new System.Drawing.Size(151, 62);
            this.doi.TabIndex = 11;
            this.doi.Text = "2";
            this.doi.UseVisualStyleBackColor = false;
            this.doi.Click += new System.EventHandler(this.Numere);
            // 
            // trei
            // 
            this.trei.BackColor = System.Drawing.Color.Silver;
            this.trei.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.trei.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trei.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trei.Location = new System.Drawing.Point(333, 369);
            this.trei.Margin = new System.Windows.Forms.Padding(4);
            this.trei.Name = "trei";
            this.trei.Size = new System.Drawing.Size(151, 62);
            this.trei.TabIndex = 12;
            this.trei.Text = "3";
            this.trei.UseVisualStyleBackColor = false;
            this.trei.Click += new System.EventHandler(this.Numere);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Silver;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zero.Location = new System.Drawing.Point(13, 439);
            this.zero.Margin = new System.Windows.Forms.Padding(4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(311, 62);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Numere);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.Color.Silver;
            this.virgula.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.ForeColor = System.Drawing.SystemColors.ControlText;
            this.virgula.Location = new System.Drawing.Point(333, 439);
            this.virgula.Margin = new System.Windows.Forms.Padding(4);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(151, 62);
            this.virgula.TabIndex = 14;
            this.virgula.Text = ".";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.virgula_click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.Color.Gray;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.Color.Black;
            this.C.Location = new System.Drawing.Point(174, 160);
            this.C.Margin = new System.Windows.Forms.Padding(4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(151, 62);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(333, 160);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "Backspace";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.backspace);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.Gray;
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.ForeColor = System.Drawing.Color.Black;
            this.CE.Location = new System.Drawing.Point(14, 159);
            this.CE.Margin = new System.Windows.Forms.Padding(4);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(151, 62);
            this.CE.TabIndex = 1;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(14, 89);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 62);
            this.button7.TabIndex = 20;
            this.button7.Text = "MR";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.mem);
            // 
            // mplus
            // 
            this.mplus.BackColor = System.Drawing.Color.Gray;
            this.mplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mplus.ForeColor = System.Drawing.Color.Black;
            this.mplus.Location = new System.Drawing.Point(173, 90);
            this.mplus.Margin = new System.Windows.Forms.Padding(4);
            this.mplus.Name = "mplus";
            this.mplus.Size = new System.Drawing.Size(151, 62);
            this.mplus.TabIndex = 25;
            this.mplus.Text = "M+";
            this.mplus.UseVisualStyleBackColor = false;
            this.mplus.Click += new System.EventHandler(this.mplus_Click);
            // 
            // mminus
            // 
            this.mminus.BackColor = System.Drawing.Color.Gray;
            this.mminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mminus.ForeColor = System.Drawing.Color.Black;
            this.mminus.Location = new System.Drawing.Point(333, 90);
            this.mminus.Margin = new System.Windows.Forms.Padding(4);
            this.mminus.Name = "mminus";
            this.mminus.Size = new System.Drawing.Size(151, 62);
            this.mminus.TabIndex = 26;
            this.mminus.Text = "M-";
            this.mminus.UseVisualStyleBackColor = false;
            this.mminus.Click += new System.EventHandler(this.mminus_Click);
            // 
            // mview
            // 
            this.mview.BackColor = System.Drawing.Color.Gray;
            this.mview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mview.ForeColor = System.Drawing.Color.Black;
            this.mview.Location = new System.Drawing.Point(492, 90);
            this.mview.Margin = new System.Windows.Forms.Padding(4);
            this.mview.Name = "mview";
            this.mview.Size = new System.Drawing.Size(151, 62);
            this.mview.TabIndex = 27;
            this.mview.Text = "M Clear";
            this.mview.UseVisualStyleBackColor = false;
            this.mview.Click += new System.EventHandler(this.mclear);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(651, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 62);
            this.button2.TabIndex = 15;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Egal);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(492, 369);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 132);
            this.button3.TabIndex = 16;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.operatii);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gray;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(651, 369);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(151, 62);
            this.button11.TabIndex = 17;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.operatii);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gray;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(492, 299);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(151, 62);
            this.button12.TabIndex = 18;
            this.button12.Text = "x";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.operatii);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gray;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(651, 299);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(151, 62);
            this.button13.TabIndex = 19;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.operatii);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(492, 159);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(151, 62);
            this.button14.TabIndex = 21;
            this.button14.Text = "+/-";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.plus_minus_click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gray;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(492, 229);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(151, 62);
            this.button15.TabIndex = 23;
            this.button15.Text = "%";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.procent_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gray;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(651, 159);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(151, 62);
            this.button16.TabIndex = 22;
            this.button16.Text = "sqrt";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.sqrt_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gray;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Location = new System.Drawing.Point(651, 229);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(151, 62);
            this.button17.TabIndex = 24;
            this.button17.Text = "1/x";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.invers);
            // 
            // semn
            // 
            this.semn.BackColor = System.Drawing.Color.Black;
            this.semn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.semn.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semn.ForeColor = System.Drawing.Color.White;
            this.semn.Location = new System.Drawing.Point(651, 19);
            this.semn.Multiline = true;
            this.semn.Name = "semn";
            this.semn.Size = new System.Drawing.Size(151, 132);
            this.semn.TabIndex = 30;
            this.semn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(817, 515);
            this.Controls.Add(this.semn);
            this.Controls.Add(this.mview);
            this.Controls.Add(this.mminus);
            this.Controls.Add(this.mplus);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.trei);
            this.Controls.Add(this.doi);
            this.Controls.Add(this.unu);
            this.Controls.Add(this.sase);
            this.Controls.Add(this.cinci);
            this.Controls.Add(this.patru);
            this.Controls.Add(this.noua);
            this.Controls.Add(this.opt);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.sapte);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.C);
            this.Controls.Add(this.rezultat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Button sapte;
        private System.Windows.Forms.Button opt;
        private System.Windows.Forms.Button noua;
        private System.Windows.Forms.Button patru;
        private System.Windows.Forms.Button cinci;
        private System.Windows.Forms.Button sase;
        private System.Windows.Forms.Button unu;
        private System.Windows.Forms.Button doi;
        private System.Windows.Forms.Button trei;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button mplus;
        private System.Windows.Forms.Button mminus;
        private System.Windows.Forms.Button mview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox semn;
    }
}

