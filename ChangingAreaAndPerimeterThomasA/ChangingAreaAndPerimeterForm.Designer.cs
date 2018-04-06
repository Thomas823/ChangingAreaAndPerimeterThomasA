namespace ChangingAreaAndPerimeterThomasA
{
    partial class frmChangingAreaAndPerimeter
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimeterAnswer = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.txtLengthInput = new System.Windows.Forms.TextBox();
            this.txtWidthInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeterPrompt = new System.Windows.Forms.Label();
            this.lblAreaPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(61, 64);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(101, 24);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(61, 115);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(91, 24);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (m)";
            // 
            // lblPerimeterAnswer
            // 
            this.lblPerimeterAnswer.AutoSize = true;
            this.lblPerimeterAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterAnswer.Location = new System.Drawing.Point(238, 187);
            this.lblPerimeterAnswer.Name = "lblPerimeterAnswer";
            this.lblPerimeterAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblPerimeterAnswer.TabIndex = 2;
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAnswer.Location = new System.Drawing.Point(238, 223);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblAreaAnswer.TabIndex = 3;
            // 
            // txtLengthInput
            // 
            this.txtLengthInput.Location = new System.Drawing.Point(255, 69);
            this.txtLengthInput.Name = "txtLengthInput";
            this.txtLengthInput.Size = new System.Drawing.Size(100, 20);
            this.txtLengthInput.TabIndex = 4;
            // 
            // txtWidthInput
            // 
            this.txtWidthInput.Location = new System.Drawing.Point(255, 120);
            this.txtWidthInput.Name = "txtWidthInput";
            this.txtWidthInput.Size = new System.Drawing.Size(100, 20);
            this.txtWidthInput.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(436, 85);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 43);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPerimeterPrompt
            // 
            this.lblPerimeterPrompt.AutoSize = true;
            this.lblPerimeterPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterPrompt.Location = new System.Drawing.Point(61, 187);
            this.lblPerimeterPrompt.Name = "lblPerimeterPrompt";
            this.lblPerimeterPrompt.Size = new System.Drawing.Size(158, 24);
            this.lblPerimeterPrompt.TabIndex = 7;
            this.lblPerimeterPrompt.Text = "The Perimeter is :";
            // 
            // lblAreaPrompt
            // 
            this.lblAreaPrompt.AutoSize = true;
            this.lblAreaPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaPrompt.Location = new System.Drawing.Point(61, 223);
            this.lblAreaPrompt.Name = "lblAreaPrompt";
            this.lblAreaPrompt.Size = new System.Drawing.Size(117, 24);
            this.lblAreaPrompt.TabIndex = 8;
            this.lblAreaPrompt.Text = "The Area is :";
            // 
            // frmChangingAreaAndPerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 288);
            this.Controls.Add(this.lblAreaPrompt);
            this.Controls.Add(this.lblPerimeterPrompt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWidthInput);
            this.Controls.Add(this.txtLengthInput);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblPerimeterAnswer);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmChangingAreaAndPerimeter";
            this.Text = "Changing Area and Perimeter By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimeterAnswer;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.TextBox txtLengthInput;
        private System.Windows.Forms.TextBox txtWidthInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerimeterPrompt;
        private System.Windows.Forms.Label lblAreaPrompt;
    }
}

