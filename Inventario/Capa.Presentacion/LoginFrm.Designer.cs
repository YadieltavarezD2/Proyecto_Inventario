namespace Capa.Presentacion
{
    partial class LoginFrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.btnIngresar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.txtUsername = new AltoControls.AltoTextBox();
            this.txtpassword = new AltoControls.AltoTextBox();
            this.altoGroupBox1 = new AltoControls.AltoGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.altoGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIngresar.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIngresar.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnIngresar.BorderRadius = 40;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(533, 319);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(281, 45);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(533, 174);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Placeholder = "👤 Username";
            this.txtUsername.PlaceholderColor = System.Drawing.Color.Black;
            this.txtUsername.Radius = 20;
            this.txtUsername.Size = new System.Drawing.Size(281, 42);
            this.txtUsername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpassword.Location = new System.Drawing.Point(533, 246);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Placeholder = "🔒 Password";
            this.txtpassword.PlaceholderColor = System.Drawing.Color.Black;
            this.txtpassword.Radius = 20;
            this.txtpassword.Size = new System.Drawing.Size(281, 40);
            this.txtpassword.TabIndex = 2;
            // 
            // altoGroupBox1
            // 
            this.altoGroupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.altoGroupBox1.BackgroundColor = System.Drawing.Color.White;
            this.altoGroupBox1.Controls.Add(this.pictureBox1);
            this.altoGroupBox1.Controls.Add(this.label1);
            this.altoGroupBox1.Controls.Add(this.txtUsername);
            this.altoGroupBox1.Controls.Add(this.txtpassword);
            this.altoGroupBox1.Controls.Add(this.btnIngresar);
            this.altoGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox1.Location = new System.Drawing.Point(69, 63);
            this.altoGroupBox1.Name = "altoGroupBox1";
            this.altoGroupBox1.Radius = 15;
            this.altoGroupBox1.Size = new System.Drawing.Size(887, 425);
            this.altoGroupBox1.TabIndex = 0;
            this.altoGroupBox1.TitleColor = System.Drawing.Color.Black;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 270);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(522, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 529);
            this.Controls.Add(this.altoGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginFrm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginFrm_Load_1);
            this.altoGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private CapaPresentacion.Buttons_Style.ButtonRound btnIngresar;
        private AltoControls.AltoTextBox txtUsername;
        private AltoControls.AltoTextBox txtpassword;
        private AltoControls.AltoGroupBox altoGroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}