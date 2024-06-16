namespace FinalHomework
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
            draw_button = new Button();
            SuspendLayout();
            // 
            // draw_button
            // 
            draw_button.Font = new Font("Segoe UI", 18F);
            draw_button.Location = new Point(934, 626);
            draw_button.Name = "draw_button";
            draw_button.Size = new Size(169, 52);
            draw_button.TabIndex = 0;
            draw_button.Text = "დახატე";
            draw_button.UseVisualStyleBackColor = true;
            draw_button.Click += draw_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 710);
            Controls.Add(draw_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button draw_button;
    }
}
