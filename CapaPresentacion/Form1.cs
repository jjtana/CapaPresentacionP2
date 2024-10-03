using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Visible = false;
            panelPaint.Visible = false;
            panelCalculadora.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                ReleaseCapture();

                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Guardar archivo de texto";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == false)
            {
                richTextBox1.Visible = true;  // Mostrar el editor de texto
                panelPaint.Visible = false;   // Ocultar el area de paint
                panelCalculadora.Visible = false; // Ocultar la calculadora
            }
            else
            {
                richTextBox1.Visible = false;  // Ocultar el editor de texto si ya estaba visible
            }
        }

        private void btnpaint_Click(object sender, EventArgs e)
        {
            if (panelPaint.Visible == false)
            {
                panelPaint.Visible = true;  
                richTextBox1.Visible = false;   
                panelCalculadora.Visible = false; 
            }
            else
            {
                panelPaint.Visible = false;  
            }


            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelPaint.BackColor = colorDialog.Color;
            }
        }



        private void btncalculadora_Click(object sender, EventArgs e)
        {
            if (panelCalculadora.Visible == false)
            {
                panelCalculadora.Visible = true;  // Mostrar la calculadora
                richTextBox1.Visible = false;   // Ocultar el editor de texto
                panelPaint.Visible = false;     // Ocultar el área de paint
            }
            else
            {
                panelCalculadora.Visible = false;  // Ocultar la calculadora si ya estaba visible
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panelPaint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File|*.txt";
            openFileDialog.Title = "Abrir archivo de texto";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = panelPaint.CreateGraphics();
                g.FillEllipse(new SolidBrush(panelPaint.BackColor), e.X, e.Y, 5, 5);
            }
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "2";
        }

        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btnBA_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 1) textBox1.Text = "0";

            else textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "1";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "7";
        }

        private void btni8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";

            textBox1.Text = textBox1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox1.Text);

            switch (operador)
            {
                case "+":
                    textBox1.Text = $"{num1 + num2}";
                break;

                case "-":
                    textBox1.Text = $"{num1 - num2}";
                break;

                case "*":
                    textBox1.Text = $"{num1 * num2}";
                break;

                case "/":
                    textBox1.Text = $"{num1 / num2}";
                break;



            }
        }
    }
}
