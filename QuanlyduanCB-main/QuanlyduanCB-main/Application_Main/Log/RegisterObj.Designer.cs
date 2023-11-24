namespace QuanLyDuAnBDS.Log
{
    partial class RegisterObj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterObj));
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            richTextBox2 = new RichTextBox();
            pictureBox2 = new PictureBox();
            checkBox2 = new CheckBox();
            btn_Next = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(94, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 435);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đối tác";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Linen;
            richTextBox1.Cursor = Cursors.Hand;
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(6, 197);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(285, 108);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "Đối tác có thể mua bán và đăng tin các dự án được công ty xét duyệt trên hệ thống";
            richTextBox1.Click += checkBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(6, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 163);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += checkBox1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoCheck = false;
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.BottomCenter;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(3, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(291, 407);
            checkBox1.TabIndex = 3;
            checkBox1.Tag = "";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(577, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 435);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khách hàng";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Linen;
            richTextBox2.Cursor = Cursors.Hand;
            richTextBox2.Enabled = false;
            richTextBox2.Location = new Point(6, 197);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(285, 108);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "Khách hàng có thể mua sắm các dự án được công ty xét duyệt trên hệ thống";
            richTextBox2.Click += checkBox2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(6, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 163);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += checkBox2_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoCheck = false;
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = ContentAlignment.BottomCenter;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.Dock = DockStyle.Fill;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(3, 25);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(291, 407);
            checkBox2.TabIndex = 3;
            checkBox2.Tag = "";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += checkBox2_Click;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(442, 441);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 32);
            btn_Next.TabIndex = 2;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            // 
            // RegisterObj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.banner;
            ClientSize = new Size(962, 538);
            Controls.Add(btn_Next);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RegisterObj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterObj";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private CheckBox checkBox1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox2;
        private PictureBox pictureBox2;
        private CheckBox checkBox2;
        private Button btn_Next;
    }
}