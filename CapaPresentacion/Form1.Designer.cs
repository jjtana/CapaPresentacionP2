namespace CapaPresentacion
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
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            pictureBox3 = new PictureBox();
            btncalculadora = new Button();
            btnpaint = new Button();
            btntxt = new Button();
            panelPaint = new Panel();
            panelCalculadora = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            btn0 = new Button();
            btnPunto = new Button();
            btnIgual = new Button();
            btnCE = new Button();
            btnBA = new Button();
            btnDiv = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btnMulti = new Button();
            btni8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btnResta = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btnSuma = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelCalculadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 68, 140);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btncalculadora);
            panel1.Controls.Add(btnpaint);
            panel1.Controls.Add(btntxt);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 579);
            panel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(12, 555);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(165, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Jostin Wilmer Perez 2022-1096";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.channels4_profile;
            pictureBox3.Location = new Point(-3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(203, 135);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btncalculadora
            // 
            btncalculadora.BackColor = Color.LightGray;
            btncalculadora.FlatAppearance.BorderSize = 0;
            btncalculadora.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btncalculadora.FlatStyle = FlatStyle.Flat;
            btncalculadora.Location = new Point(-3, 261);
            btncalculadora.Name = "btncalculadora";
            btncalculadora.Size = new Size(200, 46);
            btncalculadora.TabIndex = 2;
            btncalculadora.Text = "Calculadora";
            btncalculadora.UseVisualStyleBackColor = false;
            btncalculadora.Click += btncalculadora_Click;
            // 
            // btnpaint
            // 
            btnpaint.BackColor = Color.LightGray;
            btnpaint.FlatAppearance.BorderSize = 0;
            btnpaint.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnpaint.FlatStyle = FlatStyle.Flat;
            btnpaint.Location = new Point(0, 208);
            btnpaint.Name = "btnpaint";
            btnpaint.Size = new Size(197, 47);
            btnpaint.TabIndex = 1;
            btnpaint.Text = "Paint";
            btnpaint.UseVisualStyleBackColor = false;
            btnpaint.Click += btnpaint_Click;
            // 
            // btntxt
            // 
            btntxt.BackColor = Color.LightGray;
            btntxt.FlatAppearance.BorderSize = 0;
            btntxt.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btntxt.FlatStyle = FlatStyle.Flat;
            btntxt.Location = new Point(0, 155);
            btntxt.Name = "btntxt";
            btntxt.Size = new Size(197, 47);
            btntxt.TabIndex = 0;
            btntxt.Text = "Editor Texto";
            btntxt.UseVisualStyleBackColor = false;
            btntxt.Click += button1_Click;
            // 
            // panelPaint
            // 
            panelPaint.BackColor = Color.IndianRed;
            panelPaint.Location = new Point(200, 120);
            panelPaint.Name = "panelPaint";
            panelPaint.Size = new Size(906, 459);
            panelPaint.TabIndex = 4;
            panelPaint.Paint += panelPaint_Paint;
            panelPaint.MouseMove += panelPaint_MouseMove;
            // 
            // panelCalculadora
            // 
            panelCalculadora.BackColor = Color.MistyRose;
            panelCalculadora.BorderStyle = BorderStyle.FixedSingle;
            panelCalculadora.Controls.Add(pictureBox5);
            panelCalculadora.Controls.Add(pictureBox4);
            panelCalculadora.Controls.Add(textBox1);
            panelCalculadora.Controls.Add(btn0);
            panelCalculadora.Controls.Add(btnPunto);
            panelCalculadora.Controls.Add(btnIgual);
            panelCalculadora.Controls.Add(btnCE);
            panelCalculadora.Controls.Add(btnBA);
            panelCalculadora.Controls.Add(btnDiv);
            panelCalculadora.Controls.Add(btn9);
            panelCalculadora.Controls.Add(btn6);
            panelCalculadora.Controls.Add(btn3);
            panelCalculadora.Controls.Add(btnMulti);
            panelCalculadora.Controls.Add(btni8);
            panelCalculadora.Controls.Add(btn5);
            panelCalculadora.Controls.Add(btn2);
            panelCalculadora.Controls.Add(btnResta);
            panelCalculadora.Controls.Add(btn7);
            panelCalculadora.Controls.Add(btn4);
            panelCalculadora.Controls.Add(btn1);
            panelCalculadora.Controls.Add(btnSuma);
            panelCalculadora.Location = new Point(460, 88);
            panelCalculadora.Name = "panelCalculadora";
            panelCalculadora.Size = new Size(263, 424);
            panelCalculadora.TabIndex = 5;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Snow;
            pictureBox5.Location = new Point(-1, 21);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(261, 5);
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Snow;
            pictureBox4.Location = new Point(3, 115);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(261, 5);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 51);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // btn0
            // 
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Location = new Point(13, 370);
            btn0.Name = "btn0";
            btn0.Size = new Size(116, 41);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPunto
            // 
            btnPunto.FlatStyle = FlatStyle.Flat;
            btnPunto.Location = new Point(135, 370);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(55, 41);
            btnPunto.TabIndex = 16;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.CornflowerBlue;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(196, 323);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(55, 88);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.CornflowerBlue;
            btnCE.FlatStyle = FlatStyle.Flat;
            btnCE.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCE.Location = new Point(196, 263);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(55, 41);
            btnCE.TabIndex = 14;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnBA
            // 
            btnBA.BackColor = Color.CornflowerBlue;
            btnBA.FlatStyle = FlatStyle.Flat;
            btnBA.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBA.Location = new Point(196, 201);
            btnBA.Name = "btnBA";
            btnBA.Size = new Size(55, 41);
            btnBA.TabIndex = 13;
            btnBA.Text = "BA";
            btnBA.UseVisualStyleBackColor = false;
            btnBA.Click += btnBA_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.CornflowerBlue;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(196, 137);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(55, 41);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btn9
            // 
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Location = new Point(135, 323);
            btn9.Name = "btn9";
            btn9.Size = new Size(55, 41);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Location = new Point(135, 263);
            btn6.Name = "btn6";
            btn6.Size = new Size(55, 41);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Location = new Point(135, 201);
            btn3.Name = "btn3";
            btn3.Size = new Size(55, 41);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.CornflowerBlue;
            btnMulti.FlatStyle = FlatStyle.Flat;
            btnMulti.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(135, 137);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(55, 41);
            btnMulti.TabIndex = 8;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btni8
            // 
            btni8.FlatStyle = FlatStyle.Flat;
            btni8.Location = new Point(74, 323);
            btni8.Name = "btni8";
            btni8.Size = new Size(55, 41);
            btni8.TabIndex = 7;
            btni8.Text = "8";
            btni8.UseVisualStyleBackColor = true;
            btni8.Click += btni8_Click;
            // 
            // btn5
            // 
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Location = new Point(74, 263);
            btn5.Name = "btn5";
            btn5.Size = new Size(55, 41);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(74, 201);
            btn2.Name = "btn2";
            btn2.Size = new Size(55, 41);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button7_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.CornflowerBlue;
            btnResta.FlatStyle = FlatStyle.Flat;
            btnResta.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResta.Location = new Point(74, 137);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(55, 41);
            btnResta.TabIndex = 4;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btn7
            // 
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Location = new Point(13, 323);
            btn7.Name = "btn7";
            btn7.Size = new Size(55, 41);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Location = new Point(13, 263);
            btn4.Name = "btn4";
            btn4.Size = new Size(55, 41);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(13, 201);
            btn1.Name = "btn1";
            btn1.Size = new Size(55, 41);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.CornflowerBlue;
            btnSuma.FlatStyle = FlatStyle.Flat;
            btnSuma.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuma.Location = new Point(13, 137);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(55, 41);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(200, 120);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(906, 456);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.iconmonstr_line_one_horizontal_lined_240;
            pictureBox1.Location = new Point(827, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.iconmonstr_x_mark_lined_240;
            pictureBox2.Location = new Point(868, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 68, 140);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 32);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(20, 68, 140);
            panel3.Controls.Add(menuStrip1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(906, 32);
            panel3.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(906, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guardarToolStripMenuItem, abrirToolStripMenuItem, nuevoToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(116, 22);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(116, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(116, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1106, 579);
            Controls.Add(panelCalculadora);
            Controls.Add(panelPaint);
            Controls.Add(richTextBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelCalculadora.ResumeLayout(false);
            panelCalculadora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btncalculadora;
        private Button btnpaint;
        private Button btntxt;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RichTextBox richTextBox1;
        private Panel panel2;
        private Panel panel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private Panel panelPaint;
        private Panel panelCalculadora;
        private Button btn0;
        private Button btnPunto;
        private Button btnIgual;
        private Button btnCE;
        private Button btnBA;
        private Button btnDiv;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btnMulti;
        private Button btni8;
        private Button btn5;
        private Button btn2;
        private Button btnResta;
        private Button btn7;
        private Button btn4;
        private Button btn1;
        private Button btnSuma;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private PictureBox pictureBox5;
        private LinkLabel linkLabel2;
    }
}
