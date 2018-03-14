namespace hashingTesting
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
            this.hashSomeShit = new System.Windows.Forms.Button();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.outputHashed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hashSomeShit
            // 
            this.hashSomeShit.Location = new System.Drawing.Point(12, 53);
            this.hashSomeShit.Name = "hashSomeShit";
            this.hashSomeShit.Size = new System.Drawing.Size(356, 389);
            this.hashSomeShit.TabIndex = 0;
            this.hashSomeShit.Text = "Let\'s Hash Some S***";
            this.hashSomeShit.UseVisualStyleBackColor = true;
            this.hashSomeShit.Click += new System.EventHandler(this.hashSomeShit_Click);
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(12, 27);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(356, 20);
            this.inputTxt.TabIndex = 1;
            this.inputTxt.Text = "What S*** are we Hashing";
            this.inputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputHashed
            // 
            this.outputHashed.AutoSize = true;
            this.outputHashed.Location = new System.Drawing.Point(12, 445);
            this.outputHashed.Name = "outputHashed";
            this.outputHashed.Size = new System.Drawing.Size(0, 13);
            this.outputHashed.TabIndex = 2;
            this.outputHashed.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 483);
            this.Controls.Add(this.outputHashed);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.hashSomeShit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hashSomeShit;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Label outputHashed;
    }
}

