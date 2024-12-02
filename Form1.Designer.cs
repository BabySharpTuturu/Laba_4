namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBresenham = new System.Windows.Forms.Panel();
            this.pDDA = new System.Windows.Forms.Panel();
            this.pCircle = new System.Windows.Forms.Panel();
            this.pNaive = new System.Windows.Forms.Panel();
            this.nYa = new System.Windows.Forms.NumericUpDown();
            this.nXa = new System.Windows.Forms.NumericUpDown();
            this.nXb = new System.Windows.Forms.NumericUpDown();
            this.nYb = new System.Windows.Forms.NumericUpDown();
            this.bLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCircle = new System.Windows.Forms.Button();
            this.nCenterX = new System.Windows.Forms.NumericUpDown();
            this.nRadius = new System.Windows.Forms.NumericUpDown();
            this.nScale = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bScale = new System.Windows.Forms.Button();
            this.nCenterY = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.vsbCircle = new System.Windows.Forms.VScrollBar();
            this.vsbBreseham = new System.Windows.Forms.VScrollBar();
            this.vsbNaive = new System.Windows.Forms.VScrollBar();
            this.vsbDDA = new System.Windows.Forms.VScrollBar();
            this.hsbBresenham = new System.Windows.Forms.HScrollBar();
            this.hsbDDA = new System.Windows.Forms.HScrollBar();
            this.hsbNaive = new System.Windows.Forms.HScrollBar();
            this.hsbCircle = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nYa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterY)).BeginInit();
            this.SuspendLayout();
            // 
            // pBresenham
            // 
            this.pBresenham.BackColor = System.Drawing.Color.SeaShell;
            this.pBresenham.Location = new System.Drawing.Point(25, 38);
            this.pBresenham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBresenham.Name = "pBresenham";
            this.pBresenham.Size = new System.Drawing.Size(333, 265);
            this.pBresenham.TabIndex = 0;
            this.pBresenham.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pDDA
            // 
            this.pDDA.BackColor = System.Drawing.Color.SeaShell;
            this.pDDA.Location = new System.Drawing.Point(420, 353);
            this.pDDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDDA.Name = "pDDA";
            this.pDDA.Size = new System.Drawing.Size(320, 261);
            this.pDDA.TabIndex = 1;
            this.pDDA.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pCircle
            // 
            this.pCircle.BackColor = System.Drawing.Color.SeaShell;
            this.pCircle.Location = new System.Drawing.Point(420, 38);
            this.pCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pCircle.Name = "pCircle";
            this.pCircle.Size = new System.Drawing.Size(320, 267);
            this.pCircle.TabIndex = 3;
            this.pCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pNaive
            // 
            this.pNaive.BackColor = System.Drawing.Color.SeaShell;
            this.pNaive.Location = new System.Drawing.Point(32, 352);
            this.pNaive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pNaive.Name = "pNaive";
            this.pNaive.Size = new System.Drawing.Size(326, 262);
            this.pNaive.TabIndex = 4;
            this.pNaive.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // nYa
            // 
            this.nYa.Location = new System.Drawing.Point(135, 683);
            this.nYa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nYa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nYa.Name = "nYa";
            this.nYa.Size = new System.Drawing.Size(70, 22);
            this.nYa.TabIndex = 6;
            // 
            // nXa
            // 
            this.nXa.Location = new System.Drawing.Point(135, 645);
            this.nXa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nXa.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nXa.Name = "nXa";
            this.nXa.Size = new System.Drawing.Size(70, 22);
            this.nXa.TabIndex = 7;
            // 
            // nXb
            // 
            this.nXb.Location = new System.Drawing.Point(253, 644);
            this.nXb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nXb.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nXb.Name = "nXb";
            this.nXb.Size = new System.Drawing.Size(70, 22);
            this.nXb.TabIndex = 8;
            // 
            // nYb
            // 
            this.nYb.Location = new System.Drawing.Point(253, 683);
            this.nYb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nYb.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nYb.Name = "nYb";
            this.nYb.Size = new System.Drawing.Size(70, 22);
            this.nYb.TabIndex = 9;
            // 
            // bLine
            // 
            this.bLine.Location = new System.Drawing.Point(9, 643);
            this.bLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(88, 49);
            this.bLine.TabIndex = 10;
            this.bLine.Text = "Rasterize line";
            this.bLine.UseVisualStyleBackColor = true;
            this.bLine.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bresenham Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 12;
            // 
            // bCircle
            // 
            this.bCircle.Location = new System.Drawing.Point(794, 130);
            this.bCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCircle.Name = "bCircle";
            this.bCircle.Size = new System.Drawing.Size(94, 46);
            this.bCircle.TabIndex = 21;
            this.bCircle.Text = "Rasterize circle";
            this.bCircle.UseVisualStyleBackColor = true;
            this.bCircle.Click += new System.EventHandler(this.button2_Click);
            // 
            // nCenterX
            // 
            this.nCenterX.Location = new System.Drawing.Point(806, 40);
            this.nCenterX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nCenterX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nCenterX.Name = "nCenterX";
            this.nCenterX.Size = new System.Drawing.Size(63, 22);
            this.nCenterX.TabIndex = 18;
            // 
            // nRadius
            // 
            this.nRadius.Location = new System.Drawing.Point(806, 92);
            this.nRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nRadius.Name = "nRadius";
            this.nRadius.Size = new System.Drawing.Size(63, 22);
            this.nRadius.TabIndex = 17;
            // 
            // nScale
            // 
            this.nScale.Location = new System.Drawing.Point(361, 657);
            this.nScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nScale.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nScale.Name = "nScale";
            this.nScale.Size = new System.Drawing.Size(109, 22);
            this.nScale.TabIndex = 22;
            this.nScale.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1000, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Circle center";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1153, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Radius";
            // 
            // bScale
            // 
            this.bScale.Location = new System.Drawing.Point(487, 656);
            this.bScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bScale.Name = "bScale";
            this.bScale.Size = new System.Drawing.Size(109, 23);
            this.bScale.TabIndex = 30;
            this.bScale.Text = "Change scale";
            this.bScale.UseVisualStyleBackColor = true;
            this.bScale.Click += new System.EventHandler(this.button3_Click);
            // 
            // nCenterY
            // 
            this.nCenterY.Location = new System.Drawing.Point(806, 66);
            this.nCenterY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nCenterY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nCenterY.Name = "nCenterY";
            this.nCenterY.Size = new System.Drawing.Size(63, 22);
            this.nCenterY.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(998, 607);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Y0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(997, 580);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 16);
            this.label18.TabIndex = 36;
            this.label18.Text = "X0";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 726);
            this.splitter1.TabIndex = 50;
            this.splitter1.TabStop = false;
            // 
            // vsbCircle
            // 
            this.vsbCircle.Location = new System.Drawing.Point(743, 40);
            this.vsbCircle.Maximum = 50;
            this.vsbCircle.Minimum = -50;
            this.vsbCircle.Name = "vsbCircle";
            this.vsbCircle.Size = new System.Drawing.Size(16, 267);
            this.vsbCircle.TabIndex = 51;
            this.vsbCircle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollCircle_Scroll);
            // 
            // vsbBreseham
            // 
            this.vsbBreseham.Location = new System.Drawing.Point(361, 38);
            this.vsbBreseham.Maximum = 50;
            this.vsbBreseham.Minimum = -50;
            this.vsbBreseham.Name = "vsbBreseham";
            this.vsbBreseham.Size = new System.Drawing.Size(16, 267);
            this.vsbBreseham.TabIndex = 52;
            this.vsbBreseham.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbBreseham_Scroll);
            // 
            // vsbNaive
            // 
            this.vsbNaive.Location = new System.Drawing.Point(361, 353);
            this.vsbNaive.Maximum = 50;
            this.vsbNaive.Minimum = -50;
            this.vsbNaive.Name = "vsbNaive";
            this.vsbNaive.Size = new System.Drawing.Size(16, 261);
            this.vsbNaive.TabIndex = 53;
            this.vsbNaive.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbNaive_Scroll);
            // 
            // vsbDDA
            // 
            this.vsbDDA.Location = new System.Drawing.Point(743, 353);
            this.vsbDDA.Maximum = 50;
            this.vsbDDA.Minimum = -50;
            this.vsbDDA.Name = "vsbDDA";
            this.vsbDDA.Size = new System.Drawing.Size(16, 261);
            this.vsbDDA.TabIndex = 55;
            this.vsbDDA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDDA_Scroll);
            // 
            // hsbBresenham
            // 
            this.hsbBresenham.Location = new System.Drawing.Point(28, 305);
            this.hsbBresenham.Maximum = 50;
            this.hsbBresenham.Minimum = -50;
            this.hsbBresenham.Name = "hsbBresenham";
            this.hsbBresenham.Size = new System.Drawing.Size(330, 12);
            this.hsbBresenham.TabIndex = 56;
            this.hsbBresenham.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbBreseham_Scroll);
            // 
            // hsbDDA
            // 
            this.hsbDDA.Location = new System.Drawing.Point(420, 616);
            this.hsbDDA.Maximum = 50;
            this.hsbDDA.Minimum = -50;
            this.hsbDDA.Name = "hsbDDA";
            this.hsbDDA.Size = new System.Drawing.Size(320, 12);
            this.hsbDDA.TabIndex = 57;
            this.hsbDDA.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDDA_Scroll);
            // 
            // hsbNaive
            // 
            this.hsbNaive.Location = new System.Drawing.Point(32, 616);
            this.hsbNaive.Maximum = 50;
            this.hsbNaive.Minimum = -50;
            this.hsbNaive.Name = "hsbNaive";
            this.hsbNaive.Size = new System.Drawing.Size(326, 12);
            this.hsbNaive.TabIndex = 58;
            this.hsbNaive.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbNaive_Scroll);
            // 
            // hsbCircle
            // 
            this.hsbCircle.Location = new System.Drawing.Point(420, 307);
            this.hsbCircle.Maximum = 50;
            this.hsbCircle.Minimum = -50;
            this.hsbCircle.Name = "hsbCircle";
            this.hsbCircle.Size = new System.Drawing.Size(320, 12);
            this.hsbCircle.TabIndex = 60;
            this.hsbCircle.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollCircle_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(555, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 61;
            this.label3.Text = "DDA";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(415, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(330, 30);
            this.label17.TabIndex = 62;
            this.label17.Text = "Bresenham Algorithm For Circle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(112, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 30);
            this.label6.TabIndex = 63;
            this.label6.Text = "Naive Algorithm";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(103, 643);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 22);
            this.textBox1.TabIndex = 64;
            this.textBox1.Text = "Х1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(103, 682);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 22);
            this.textBox2.TabIndex = 65;
            this.textBox2.Text = "Y1";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(221, 644);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 22);
            this.textBox3.TabIndex = 66;
            this.textBox3.Text = "Х2";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Location = new System.Drawing.Point(221, 681);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(26, 22);
            this.textBox4.TabIndex = 67;
            this.textBox4.Text = "Y2";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.Location = new System.Drawing.Point(774, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(26, 22);
            this.textBox5.TabIndex = 68;
            this.textBox5.Text = "Х0";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.Location = new System.Drawing.Point(774, 65);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(26, 22);
            this.textBox6.TabIndex = 69;
            this.textBox6.Text = "Y0";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.Location = new System.Drawing.Point(774, 91);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(26, 22);
            this.textBox7.TabIndex = 70;
            this.textBox7.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(911, 726);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hsbCircle);
            this.Controls.Add(this.hsbNaive);
            this.Controls.Add(this.hsbDDA);
            this.Controls.Add(this.hsbBresenham);
            this.Controls.Add(this.vsbDDA);
            this.Controls.Add(this.vsbNaive);
            this.Controls.Add(this.vsbBreseham);
            this.Controls.Add(this.vsbCircle);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.nCenterY);
            this.Controls.Add(this.bScale);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nScale);
            this.Controls.Add(this.bCircle);
            this.Controls.Add(this.nCenterX);
            this.Controls.Add(this.nRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLine);
            this.Controls.Add(this.nYb);
            this.Controls.Add(this.nXb);
            this.Controls.Add(this.nXa);
            this.Controls.Add(this.nYa);
            this.Controls.Add(this.pNaive);
            this.Controls.Add(this.pCircle);
            this.Controls.Add(this.pDDA);
            this.Controls.Add(this.pBresenham);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Rasterizer Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nYa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCenterY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBresenham;
        private System.Windows.Forms.Panel pDDA;
        private System.Windows.Forms.Panel pCircle;
        private System.Windows.Forms.Panel pNaive;
        private System.Windows.Forms.NumericUpDown nYa;
        private System.Windows.Forms.NumericUpDown nXa;
        private System.Windows.Forms.NumericUpDown nXb;
        private System.Windows.Forms.NumericUpDown nYb;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCircle;
        private System.Windows.Forms.NumericUpDown nCenterX;
        private System.Windows.Forms.NumericUpDown nRadius;
        private System.Windows.Forms.NumericUpDown nScale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bScale;
        private System.Windows.Forms.NumericUpDown nCenterY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.VScrollBar vsbCircle;
        private System.Windows.Forms.VScrollBar vsbBreseham;
        private System.Windows.Forms.VScrollBar vsbNaive;
        private System.Windows.Forms.VScrollBar vsbDDA;
        private System.Windows.Forms.HScrollBar hsbBresenham;
        private System.Windows.Forms.HScrollBar hsbDDA;
        private System.Windows.Forms.HScrollBar hsbNaive;
        private System.Windows.Forms.HScrollBar hsbCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}
