namespace WindowsFormsApp4
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.v1 = new System.Windows.Forms.RadioButton();
            this.v2 = new System.Windows.Forms.RadioButton();
            this.v3 = new System.Windows.Forms.RadioButton();
            this.btnVerification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(746, 54);
            this.textBox1.TabIndex = 0;
            // 
            // v1
            // 
            this.v1.AutoSize = true;
            this.v1.Location = new System.Drawing.Point(32, 104);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(14, 13);
            this.v1.TabIndex = 1;
            this.v1.TabStop = true;
            this.v1.UseVisualStyleBackColor = true;
            this.v1.CheckedChanged += new System.EventHandler(this.v1_CheckedChanged);
            // 
            // v2
            // 
            this.v2.AutoSize = true;
            this.v2.Location = new System.Drawing.Point(32, 141);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(14, 13);
            this.v2.TabIndex = 2;
            this.v2.TabStop = true;
            this.v2.UseVisualStyleBackColor = true;
            this.v2.CheckedChanged += new System.EventHandler(this.v2_CheckedChanged);
            // 
            // v3
            // 
            this.v3.AutoSize = true;
            this.v3.Location = new System.Drawing.Point(32, 186);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(14, 13);
            this.v3.TabIndex = 3;
            this.v3.TabStop = true;
            this.v3.UseVisualStyleBackColor = true;
            this.v3.CheckedChanged += new System.EventHandler(this.v3_CheckedChanged);
            // 
            // btnVerification
            // 
            this.btnVerification.Location = new System.Drawing.Point(32, 243);
            this.btnVerification.Name = "btnVerification";
            this.btnVerification.Size = new System.Drawing.Size(78, 41);
            this.btnVerification.TabIndex = 4;
            this.btnVerification.Text = "Проверка";
            this.btnVerification.UseVisualStyleBackColor = true;
            this.btnVerification.Click += new System.EventHandler(this.btnVerification_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerification);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton v1;
        private System.Windows.Forms.RadioButton v2;
        private System.Windows.Forms.RadioButton v3;
        private System.Windows.Forms.Button btnVerification;
    }
}