namespace AutoKey
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Show1 = new System.Windows.Forms.Label();
            this.lbl_Show2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(70, 12);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(144, 20);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt_UserName_TextChanged);
            // 
            // lbl_Show1
            // 
            this.lbl_Show1.AutoSize = true;
            this.lbl_Show1.Location = new System.Drawing.Point(12, 15);
            this.lbl_Show1.Name = "lbl_Show1";
            this.lbl_Show1.Size = new System.Drawing.Size(58, 13);
            this.lbl_Show1.TabIndex = 1;
            this.lbl_Show1.Text = "Username:";
            // 
            // lbl_Show2
            // 
            this.lbl_Show2.AutoSize = true;
            this.lbl_Show2.Location = new System.Drawing.Point(12, 43);
            this.lbl_Show2.Name = "lbl_Show2";
            this.lbl_Show2.Size = new System.Drawing.Size(56, 13);
            this.lbl_Show2.TabIndex = 2;
            this.lbl_Show2.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(70, 40);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(144, 20);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 66);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(202, 23);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Confirm";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "label1";
            this.lbl.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 97);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Show2);
            this.Controls.Add(this.lbl_Show1);
            this.Controls.Add(this.txt_UserName);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_Show1;
        private System.Windows.Forms.Label lbl_Show2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl;
    }
}