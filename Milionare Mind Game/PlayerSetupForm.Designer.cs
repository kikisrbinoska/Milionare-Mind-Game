namespace Milionare_Mind_Game
{
    partial class PlayerSetupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ButtonUploadPhoto = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonSumbit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Внеси го твоето име:";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(116, 159);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(376, 35);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Додади слика:";
            // 
            // guna2ButtonUploadPhoto
            // 
            this.guna2ButtonUploadPhoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUploadPhoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUploadPhoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonUploadPhoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonUploadPhoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonUploadPhoto.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonUploadPhoto.Location = new System.Drawing.Point(116, 266);
            this.guna2ButtonUploadPhoto.Name = "guna2ButtonUploadPhoto";
            this.guna2ButtonUploadPhoto.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonUploadPhoto.TabIndex = 4;
            this.guna2ButtonUploadPhoto.Text = "Upload";
            this.guna2ButtonUploadPhoto.Click += new System.EventHandler(this.guna2ButtonUploadPhoto_Click_1);
            // 
            // guna2ButtonSumbit
            // 
            this.guna2ButtonSumbit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSumbit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonSumbit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonSumbit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonSumbit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonSumbit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSumbit.Location = new System.Drawing.Point(116, 342);
            this.guna2ButtonSumbit.Name = "guna2ButtonSumbit";
            this.guna2ButtonSumbit.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonSumbit.TabIndex = 5;
            this.guna2ButtonSumbit.Text = "Submit";
            this.guna2ButtonSumbit.Click += new System.EventHandler(this.guna2ButtonSumbit_Click);
            // 
            // PlayerSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ButtonSumbit);
            this.Controls.Add(this.guna2ButtonUploadPhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label1);
            this.Name = "PlayerSetupForm";
            this.Text = "PlayerSetupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUploadPhoto;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSumbit;
    }
}