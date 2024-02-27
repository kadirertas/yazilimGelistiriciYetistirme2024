namespace ThreadingDemo1
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
            this.btnProcess2 = new System.Windows.Forms.Button();
            this.btnProcess1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcess2
            // 
            this.btnProcess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcess2.Location = new System.Drawing.Point(405, 43);
            this.btnProcess2.Name = "btnProcess2";
            this.btnProcess2.Size = new System.Drawing.Size(175, 98);
            this.btnProcess2.TabIndex = 0;
            this.btnProcess2.Text = "İşlem 2 ";
            this.btnProcess2.UseVisualStyleBackColor = true;
            this.btnProcess2.Click += new System.EventHandler(this.btnProcess2_Click);
            // 
            // btnProcess1
            // 
            this.btnProcess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcess1.Location = new System.Drawing.Point(130, 43);
            this.btnProcess1.Name = "btnProcess1";
            this.btnProcess1.Size = new System.Drawing.Size(164, 98);
            this.btnProcess1.TabIndex = 1;
            this.btnProcess1.Text = "İşlem 1";
            this.btnProcess1.UseVisualStyleBackColor = true;
            this.btnProcess1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcess1);
            this.Controls.Add(this.btnProcess2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcess2;
        private System.Windows.Forms.Button btnProcess1;
    }
}

