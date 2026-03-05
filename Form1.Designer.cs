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
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(30, 229);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 0;
            label1.Text = "민승호";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Phodopus_sungorus__agouti_pearl;
            pictureBox1.Location = new Point(30, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(443, 240);
            button1.Name = "button1";
            button1.Size = new Size(157, 68);
            button1.TabIndex = 2;
            button1.Text = "배경색　바꾸기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 71, 171);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "힘들어요";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
    }
}
