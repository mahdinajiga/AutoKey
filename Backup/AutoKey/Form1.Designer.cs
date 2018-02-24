namespace AutoKey
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LoopTEXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoopNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rb_AN = new System.Windows.Forms.CheckBox();
            this.msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoopNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loop \"";
            // 
            // txt_LoopTEXT
            // 
            this.txt_LoopTEXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_LoopTEXT.Location = new System.Drawing.Point(48, 6);
            this.txt_LoopTEXT.Multiline = true;
            this.txt_LoopTEXT.Name = "txt_LoopTEXT";
            this.txt_LoopTEXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_LoopTEXT.Size = new System.Drawing.Size(369, 55);
            this.txt_LoopTEXT.TabIndex = 1;
            this.txt_LoopTEXT.Text = "Your Spam Text;;;";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "\" For";
            // 
            // LoopNUD
            // 
            this.LoopNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopNUD.Location = new System.Drawing.Point(48, 73);
            this.LoopNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LoopNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoopNUD.Name = "LoopNUD";
            this.LoopNUD.Size = new System.Drawing.Size(67, 20);
            this.LoopNUD.TabIndex = 3;
            this.LoopNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "time(s) every";
            // 
            // intervalNUD
            // 
            this.intervalNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.intervalNUD.Location = new System.Drawing.Point(184, 72);
            this.intervalNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.intervalNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.intervalNUD.Name = "intervalNUD";
            this.intervalNUD.Size = new System.Drawing.Size(63, 20);
            this.intervalNUD.TabIndex = 5;
            this.intervalNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "MS(s).";
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.Location = new System.Drawing.Point(261, 94);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stop.Location = new System.Drawing.Point(342, 94);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 8;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rb_AN
            // 
            this.rb_AN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_AN.AutoSize = true;
            this.rb_AN.Location = new System.Drawing.Point(332, 74);
            this.rb_AN.Name = "rb_AN";
            this.rb_AN.Size = new System.Drawing.Size(85, 17);
            this.rb_AN.TabIndex = 9;
            this.rb_AN.Text = "Add Number";
            this.rb_AN.UseVisualStyleBackColor = true;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Location = new System.Drawing.Point(0, 0);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(50, 13);
            this.msg.TabIndex = 10;
            this.msg.Text = "Message";
            this.msg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 128);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.rb_AN);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intervalNUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoopNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LoopTEXT);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.MinimumSize = new System.Drawing.Size(0, 98);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LoopNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LoopTEXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown LoopNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intervalNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox rb_AN;
        private System.Windows.Forms.Label msg;
    }
}

