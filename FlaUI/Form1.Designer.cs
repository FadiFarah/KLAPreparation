
namespace FlaUI
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
            this.test1Button = new System.Windows.Forms.Button();
            this.test2Button = new System.Windows.Forms.Button();
            this.test3Button = new System.Windows.Forms.Button();
            this.test5Button = new System.Windows.Forms.Button();
            this.test4Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1Button
            // 
            this.test1Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test1Button.Location = new System.Drawing.Point(98, 164);
            this.test1Button.Name = "test1Button";
            this.test1Button.Size = new System.Drawing.Size(122, 50);
            this.test1Button.TabIndex = 0;
            this.test1Button.Text = "TEST1";
            this.test1Button.UseVisualStyleBackColor = true;
            this.test1Button.Click += new System.EventHandler(this.test1Button_Click);
            // 
            // test2Button
            // 
            this.test2Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test2Button.Location = new System.Drawing.Point(334, 164);
            this.test2Button.Name = "test2Button";
            this.test2Button.Size = new System.Drawing.Size(122, 50);
            this.test2Button.TabIndex = 1;
            this.test2Button.Text = "TEST2";
            this.test2Button.UseVisualStyleBackColor = true;
            this.test2Button.Click += new System.EventHandler(this.test2Button_Click);
            // 
            // test3Button
            // 
            this.test3Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test3Button.Location = new System.Drawing.Point(577, 164);
            this.test3Button.Name = "test3Button";
            this.test3Button.Size = new System.Drawing.Size(122, 50);
            this.test3Button.TabIndex = 2;
            this.test3Button.Text = "TEST3";
            this.test3Button.UseVisualStyleBackColor = true;
            this.test3Button.Click += new System.EventHandler(this.test3Button_Click);
            // 
            // test5Button
            // 
            this.test5Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test5Button.Location = new System.Drawing.Point(457, 283);
            this.test5Button.Name = "test5Button";
            this.test5Button.Size = new System.Drawing.Size(122, 50);
            this.test5Button.TabIndex = 4;
            this.test5Button.Text = "TEST5";
            this.test5Button.UseVisualStyleBackColor = true;
            this.test5Button.Click += new System.EventHandler(this.test5Button_Click);
            // 
            // test4Button
            // 
            this.test4Button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test4Button.Location = new System.Drawing.Point(214, 283);
            this.test4Button.Name = "test4Button";
            this.test4Button.Size = new System.Drawing.Size(122, 50);
            this.test4Button.TabIndex = 3;
            this.test4Button.Text = "TEST4";
            this.test4Button.UseVisualStyleBackColor = true;
            this.test4Button.Click += new System.EventHandler(this.test4Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test5Button);
            this.Controls.Add(this.test4Button);
            this.Controls.Add(this.test3Button);
            this.Controls.Add(this.test2Button);
            this.Controls.Add(this.test1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test1Button;
        private System.Windows.Forms.Button test2Button;
        private System.Windows.Forms.Button test3Button;
        private System.Windows.Forms.Button test5Button;
        private System.Windows.Forms.Button test4Button;
    }
}

