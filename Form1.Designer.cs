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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 426);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 119);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(228, 228, 200);
            label2.Font = new Font("Noto Sans KR", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 63);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 2);
            label2.Size = new Size(63, 29);
            label2.TabIndex = 2;
            label2.Text = "민승호";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(228, 228, 200);
            label1.Font = new Font("Noto Sans KR", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.FromArgb(31, 41, 55);
            label1.Location = new Point(13, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 40, 2);
            label1.Size = new Size(207, 41);
            label1.TabIndex = 1;
            label1.Text = "영미언어문화";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 239, 214);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(335, 12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(394, 248);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Phodopus_sungorus__agouti_pearl;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(374, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(240, 239, 214);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Location = new Point(335, 291);
            panel3.Name = "panel3";
            panel3.Size = new Size(44, 95);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 239, 214);
            panel4.Location = new Point(2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 95);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(240, 239, 214);
            panel5.Location = new Point(385, 291);
            panel5.Name = "panel5";
            panel5.Size = new Size(44, 95);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
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
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 68, 152);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 450);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "힘들어요";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
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
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
