using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
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
    }
}
