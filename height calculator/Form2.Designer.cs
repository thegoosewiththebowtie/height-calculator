namespace height_calculator
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 30);
            label1.TabIndex = 0;
            label1.Text = "Your height is";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(12, 126);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Yes";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Location = new Point(197, 126);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Yes";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(260, 21);
            label2.TabIndex = 3;
            label2.Text = "somewhere in between of";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(260, 63);
            label3.TabIndex = 4;
            label3.Text = "0000";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(93, 126);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 5;
            label4.Text = "are we right?";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(284, 161);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Results";
            TopMost = true;
            Shown += Form2_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}