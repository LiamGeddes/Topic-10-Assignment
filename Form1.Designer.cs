namespace Topic_10_Assignment
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
            this.picComponent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // picComponent
            // 
            this.picComponent.Location = new System.Drawing.Point(350, 104);
            this.picComponent.Name = "picComponent";
            this.picComponent.Size = new System.Drawing.Size(100, 50);
            this.picComponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComponent.TabIndex = 0;
            this.picComponent.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 312);
            this.Controls.Add(this.picComponent);
            this.Name = "Form1";
            this.Text = "Computer Components";
            ((System.ComponentModel.ISupportInitialize)(this.picComponent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picComponent;
    }
}

