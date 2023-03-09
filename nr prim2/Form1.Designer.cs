namespace nr_prim2
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
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(269, 111);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 27);
            textBox6.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(295, 192);
            button1.Name = "button1";
            button1.Size = new Size(211, 138);
            button1.TabIndex = 6;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private Button button1;
    }
}