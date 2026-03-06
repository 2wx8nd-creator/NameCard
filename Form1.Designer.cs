namespace WinFormsApp3
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel4 = new Panel();
            textBox3 = new TextBox();
            panel5 = new Panel();
            textBox2 = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button1
            // 
            button1.Font = new Font("Noto Sans KR Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(545, 318);
            button1.Name = "button1";
            button1.Padding = new Padding(2, 0, 0, 2);
            button1.Size = new Size(157, 68);
            button1.TabIndex = 2;
            button1.Text = "배경색　바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 239, 214);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 426);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(228, 228, 200);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.FromArgb(31, 41, 55);
            label1.Location = new Point(13, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 112, 2);
            label1.Size = new Size(206, 43);
            label1.TabIndex = 1;
            label1.Text = "민승호";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 239, 214);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(2, 2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(400, 250);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Phodopus_sungorus__agouti_pearl;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(240, 239, 214);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(335, 291);
            panel3.Name = "panel3";
            panel3.Size = new Size(44, 95);
            panel3.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 239, 214);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.Location = new Point(1, 38);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(41, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "음영1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 239, 214);
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 95);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(240, 239, 214);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.CharacterCasing = CharacterCasing.Lower;
            textBox3.Location = new Point(2, 37);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(41, 16);
            textBox3.TabIndex = 1;
            textBox3.Text = "음영3";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 239, 214);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(385, 291);
            panel5.Name = "panel5";
            panel5.Size = new Size(44, 95);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(240, 239, 214);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.CharacterCasing = CharacterCasing.Lower;
            textBox2.Location = new Point(2, 39);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(41, 16);
            textBox2.TabIndex = 1;
            textBox2.Text = "음영2";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(185, 184, 160);
            panel6.Controls.Add(panel4);
            panel6.Location = new Point(435, 291);
            panel6.Name = "panel6";
            panel6.Size = new Size(46, 97);
            panel6.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(185, 184, 160);
            panel7.Controls.Add(panel1);
            panel7.Location = new Point(12, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(235, 428);
            panel7.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(185, 184, 160);
            panel8.Controls.Add(panel2);
            panel8.Location = new Point(335, 14);
            panel8.Name = "panel8";
            panel8.Size = new Size(402, 252);
            panel8.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(228, 228, 200);
            textBox4.Location = new Point(13, 56);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 356);
            textBox4.TabIndex = 3;
            textBox4.Text = "\r\n학번 : 25081092\r\n영미언어문화 전공\r\n컴퓨터SW 복수전공\r\n\r\n10년 후 민승호(32세)의 결혼 및 마이하우스 장만을 위해 나름 열심히 사는 중입니다.\r\n\r\n증명사진의 스캔본이 없어 대신 귀여운 햄스터의 이미지를 삽입했습니다.";
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 68, 152);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 450);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(12, 12);
            Name = "Form1";
            Text = "힘들어요";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel8;
        private TextBox textBox4;
    }
}
