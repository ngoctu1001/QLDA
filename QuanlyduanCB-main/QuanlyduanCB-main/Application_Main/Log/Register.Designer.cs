namespace Application
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lb_TenDn = new Label();
            txt_TenDn = new TextBox();
            lb_Mk = new Label();
            txt_Mk = new TextBox();
            lb_XnMk = new Label();
            txt_XnMk = new TextBox();
            btn_Dk = new Button();
            btn_Dn = new Button();
            lb_ThongBao = new Label();
            SuspendLayout();
            // 
            // lb_TenDn
            // 
            resources.ApplyResources(lb_TenDn, "lb_TenDn");
            lb_TenDn.BackColor = Color.Linen;
            lb_TenDn.Name = "lb_TenDn";
            // 
            // txt_TenDn
            // 
            resources.ApplyResources(txt_TenDn, "txt_TenDn");
            txt_TenDn.Name = "txt_TenDn";
            // 
            // lb_Mk
            // 
            resources.ApplyResources(lb_Mk, "lb_Mk");
            lb_Mk.BackColor = Color.Linen;
            lb_Mk.Name = "lb_Mk";
            // 
            // txt_Mk
            // 
            resources.ApplyResources(txt_Mk, "txt_Mk");
            txt_Mk.Name = "txt_Mk";
            // 
            // lb_XnMk
            // 
            resources.ApplyResources(lb_XnMk, "lb_XnMk");
            lb_XnMk.BackColor = Color.Linen;
            lb_XnMk.Name = "lb_XnMk";
            // 
            // txt_XnMk
            // 
            resources.ApplyResources(txt_XnMk, "txt_XnMk");
            txt_XnMk.Name = "txt_XnMk";
            // 
            // btn_Dk
            // 
            resources.ApplyResources(btn_Dk, "btn_Dk");
            btn_Dk.Name = "btn_Dk";
            btn_Dk.UseVisualStyleBackColor = true;
            btn_Dk.Click += btn_Dk_Click;
            // 
            // btn_Dn
            // 
            resources.ApplyResources(btn_Dn, "btn_Dn");
            btn_Dn.Name = "btn_Dn";
            btn_Dn.UseVisualStyleBackColor = true;
            btn_Dn.Click += btn_Dn_Click;
            // 
            // lb_ThongBao
            // 
            resources.ApplyResources(lb_ThongBao, "lb_ThongBao");
            lb_ThongBao.BackColor = Color.Linen;
            lb_ThongBao.Name = "lb_ThongBao";
            // 
            // Register
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = QuanLyDuAnBDS.Properties.Resources.banner;
            Controls.Add(lb_ThongBao);
            Controls.Add(btn_Dn);
            Controls.Add(btn_Dk);
            Controls.Add(txt_XnMk);
            Controls.Add(lb_XnMk);
            Controls.Add(txt_Mk);
            Controls.Add(lb_Mk);
            Controls.Add(txt_TenDn);
            Controls.Add(lb_TenDn);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Register";
            ShowIcon = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_TenDn;
        private TextBox txt_TenDn;
        private Label lb_Mk;
        private TextBox txt_Mk;
        private Label lb_XnMk;
        private TextBox txt_XnMk;
        private Button btn_Dk;
        private Button btn_Dn;
        private Label lb_ThongBao;
    }
}