namespace Application
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lb_MK = new Label();
            txt_TenDn = new TextBox();
            btn_DN = new Button();
            lb_TenDN = new Label();
            btn_DK = new Button();
            txt_Mk = new TextBox();
            lb_TB = new Label();
            SuspendLayout();
            // 
            // lb_MK
            // 
            resources.ApplyResources(lb_MK, "lb_MK");
            lb_MK.BackColor = Color.Linen;
            lb_MK.Name = "lb_MK";
            // 
            // txt_TenDn
            // 
            resources.ApplyResources(txt_TenDn, "txt_TenDn");
            txt_TenDn.Name = "txt_TenDn";
            // 
            // btn_DN
            // 
            resources.ApplyResources(btn_DN, "btn_DN");
            btn_DN.Name = "btn_DN";
            btn_DN.UseVisualStyleBackColor = true;
            btn_DN.Click += btn_DN_Click;
            // 
            // lb_TenDN
            // 
            resources.ApplyResources(lb_TenDN, "lb_TenDN");
            lb_TenDN.BackColor = Color.Linen;
            lb_TenDN.Name = "lb_TenDN";
            // 
            // btn_DK
            // 
            resources.ApplyResources(btn_DK, "btn_DK");
            btn_DK.Name = "btn_DK";
            btn_DK.UseVisualStyleBackColor = true;
            btn_DK.Click += btn_DK_Click;
            // 
            // txt_Mk
            // 
            resources.ApplyResources(txt_Mk, "txt_Mk");
            txt_Mk.Name = "txt_Mk";
            // 
            // lb_TB
            // 
            resources.ApplyResources(lb_TB, "lb_TB");
            lb_TB.ForeColor = Color.OrangeRed;
            lb_TB.Image = QuanLyDuAnBDS.Properties.Resources.banner2;
            lb_TB.Name = "lb_TB";
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner;
            Controls.Add(lb_TB);
            Controls.Add(txt_Mk);
            Controls.Add(lb_MK);
            Controls.Add(txt_TenDn);
            Controls.Add(btn_DN);
            Controls.Add(lb_TenDN);
            Controls.Add(btn_DK);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Login";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_MK;
        private TextBox txt_TenDn;
        private Button btn_DN;
        private Label lb_TenDN;
        private Button btn_DK;
        private TextBox txt_Mk;
        private Label lb_TB;
    }
}