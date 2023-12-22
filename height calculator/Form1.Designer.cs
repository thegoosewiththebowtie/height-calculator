namespace height_calculator
{
    partial class f1
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
            pb1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // pb1
            // 
            pb1.BackColor = SystemColors.Control;
            pb1.Location = new Point(9, 70);
            pb1.Margin = new Padding(0);
            pb1.MarqueeAnimationSpeed = 1000;
            pb1.Name = "pb1";
            pb1.Size = new Size(366, 32);
            pb1.Step = 5;
            pb1.Style = ProgressBarStyle.Continuous;
            pb1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(9, 0);
            label1.Margin = new Padding(0, 30, 0, 30);
            label1.Name = "label1";
            label1.Size = new Size(366, 32);
            label1.TabIndex = 1;
            label1.Text = "Please, wait...";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(9, 38);
            label2.Name = "label2";
            label2.Size = new Size(366, 32);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(9, 70);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(366, 32);
            button1.TabIndex = 3;
            button1.Text = "Yes!";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // f1
            // 
            AccessibleName = "Loading...";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 111);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pb1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "f1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading...";
            Shown += f1_Shown;
            ResumeLayout(false);
        }

        #endregion

        public ProgressBar pb1;
        public Label label1;
        private Label label2;
        private Button button1;
    }
}