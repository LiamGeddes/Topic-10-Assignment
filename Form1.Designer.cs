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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picComponent)).BeginInit();
            this.SuspendLayout();
            // 
            // picComponent
            // 
            this.picComponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picComponent.Location = new System.Drawing.Point(188, 69);
            this.picComponent.Name = "picComponent";
            this.picComponent.Size = new System.Drawing.Size(264, 173);
            this.picComponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComponent.TabIndex = 0;
            this.picComponent.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDescription.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescription.Location = new System.Drawing.Point(188, 245);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(264, 66);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Select a component to learn more.";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Location = new System.Drawing.Point(117, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Select a component to learn more.";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCPU.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPU.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCPU.Location = new System.Drawing.Point(42, 40);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(75, 23);
            this.btnCPU.TabIndex = 3;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = false;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRAM.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAM.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRAM.Location = new System.Drawing.Point(42, 69);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(75, 23);
            this.btnRAM.TabIndex = 4;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = false;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // btnSSD
            // 
            this.btnSSD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSSD.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSSD.Location = new System.Drawing.Point(42, 98);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(75, 23);
            this.btnSSD.TabIndex = 5;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = false;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPower.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPower.Location = new System.Drawing.Point(42, 127);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(75, 41);
            this.btnPower.TabIndex = 6;
            this.btnPower.Text = "Power Supply";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInput.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInput.Location = new System.Drawing.Point(42, 174);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 47);
            this.btnInput.TabIndex = 7;
            this.btnInput.Text = "Input Peripheral";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOutput.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOutput.Location = new System.Drawing.Point(42, 227);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 43);
            this.btnOutput.TabIndex = 8;
            this.btnOutput.Text = "Output Peripheral";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 307);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picComponent);
            this.Name = "Form1";
            this.Text = "Computer Components";
            ((System.ComponentModel.ISupportInitialize)(this.picComponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picComponent;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnOutput;
    }
}

