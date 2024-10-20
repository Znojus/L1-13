namespace CelsiusClient
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
            FtoC = new RadioButton();
            Convert = new Button();
            CtoF = new RadioButton();
            degrees = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // FtoC
            // 
            FtoC.AutoSize = true;
            FtoC.Location = new Point(99, 182);
            FtoC.Name = "FtoC";
            FtoC.Size = new Size(246, 29);
            FtoC.TabIndex = 0;
            FtoC.TabStop = true;
            FtoC.Text = "From Fahrenheit to Celsius";
            FtoC.TextAlign = ContentAlignment.MiddleCenter;
            FtoC.UseVisualStyleBackColor = true;
            FtoC.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Convert
            // 
            Convert.Location = new Point(468, 130);
            Convert.Name = "Convert";
            Convert.Size = new Size(168, 75);
            Convert.TabIndex = 1;
            Convert.Text = "Convert";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += button1_Click;
            // 
            // CtoF
            // 
            CtoF.AutoSize = true;
            CtoF.Location = new Point(99, 229);
            CtoF.Name = "CtoF";
            CtoF.Size = new Size(246, 29);
            CtoF.TabIndex = 2;
            CtoF.TabStop = true;
            CtoF.Text = "From Celsius to Fahrenheit";
            CtoF.UseVisualStyleBackColor = true;
            CtoF.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // degrees
            // 
            degrees.Location = new Point(99, 130);
            degrees.Name = "degrees";
            degrees.Size = new Size(150, 31);
            degrees.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 83);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 4;
            label1.Text = "Convert ";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 323);
            Controls.Add(label1);
            Controls.Add(degrees);
            Controls.Add(CtoF);
            Controls.Add(Convert);
            Controls.Add(FtoC);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton FtoC;
        private Button Convert;
        private RadioButton CtoF;
        private TextBox degrees;
        private Label label1;
    }
}
