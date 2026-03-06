using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Color[] myColors = new Color[] {
            Color.FromArgb(156, 175, 136),
            Color.FromArgb(25, 42, 81),
            Color.FromArgb(210, 201, 175),
            Color.FromArgb(170, 160, 145),
            Color.FromArgb(10, 68, 152)


        };
        int currentColorIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentColorIndex = (currentColorIndex + 1) % myColors.Length;
            this.BackColor = myColors[currentColorIndex];
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(150, 0, 0, 0), 1),
            0, 0, this.panel5.Width - 1, this.panel5.Height - 1);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}