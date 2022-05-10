namespace WindowsFormsApp1
{
    partial class signin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regTName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regTAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regTPass = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.regLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "SignUp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // regTName
            // 
            this.regTName.Location = new System.Drawing.Point(239, 147);
            this.regTName.Name = "regTName";
            this.regTName.Size = new System.Drawing.Size(115, 22);
            this.regTName.TabIndex = 2;
            this.regTName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Age";
            // 
            // regTAge
            // 
            this.regTAge.Location = new System.Drawing.Point(239, 187);
            this.regTAge.Name = "regTAge";
            this.regTAge.Size = new System.Drawing.Size(115, 22);
            this.regTAge.TabIndex = 2;
            this.regTAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password";
            // 
            // regTPass
            // 
            this.regTPass.Location = new System.Drawing.Point(239, 230);
            this.regTPass.Name = "regTPass";
            this.regTPass.Size = new System.Drawing.Size(115, 22);
            this.regTPass.TabIndex = 2;
            this.regTPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(307, 282);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 31);
            this.regBtn.TabIndex = 3;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // regLoginBtn
            // 
            this.regLoginBtn.Location = new System.Drawing.Point(472, 359);
            this.regLoginBtn.Name = "regLoginBtn";
            this.regLoginBtn.Size = new System.Drawing.Size(75, 29);
            this.regLoginBtn.TabIndex = 4;
            this.regLoginBtn.Text = "Login";
            this.regLoginBtn.UseVisualStyleBackColor = true;
            this.regLoginBtn.Click += new System.EventHandler(this.regLoginBtn_Click);
            // 
            // signin
            // 
            this.ClientSize = new System.Drawing.Size(571, 410);
            this.Controls.Add(this.regLoginBtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.regTPass);
            this.Controls.Add(this.regTAge);
            this.Controls.Add(this.regTName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regTName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regTAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regTPass;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button regLoginBtn;
    }
}

