namespace FileCompare3
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
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            panel2 = new Panel();
            txtLeftDir = new TextBox();
            btnLeftDir = new Button();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            lblAppName = new Label();
            panel7 = new Panel();
            lvwRightDir = new ListView();
            panel6 = new Panel();
            txtRightDir = new TextBox();
            btnRightDir = new Button();
            panel4 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(5, 5);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(953, 440);
            splitContainer1.SplitterDistance = 475;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(192, 255, 255);
            panel3.Controls.Add(lvwLeftDir);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 200);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(475, 240);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Dock = DockStyle.Fill;
            lvwLeftDir.Location = new Point(5, 5);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(465, 230);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(txtLeftDir);
            panel2.Controls.Add(btnLeftDir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 10, 0);
            panel2.Size = new Size(475, 100);
            panel2.TabIndex = 1;
            panel2.Paint += panel8_Paint;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Location = new Point(12, 58);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(337, 26);
            txtLeftDir.TabIndex = 2;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(355, 46);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(107, 48);
            btnLeftDir.TabIndex = 1;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(lblAppName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopyFromLeft.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(362, 46);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(97, 48);
            btnCopyFromLeft.TabIndex = 0;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(7, 7);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(317, 65);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 192, 192);
            panel7.Controls.Add(lvwRightDir);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 200);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(468, 240);
            panel7.TabIndex = 0;
            panel7.Paint += panel7_Paint;
            // 
            // lvwRightDir
            // 
            lvwRightDir.Dock = DockStyle.Fill;
            lvwRightDir.Location = new Point(5, 5);
            lvwRightDir.Name = "lvwRightDir";
            lvwRightDir.Size = new Size(458, 230);
            lvwRightDir.TabIndex = 1;
            lvwRightDir.UseCompatibleStateImageBehavior = false;
            lvwRightDir.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 224, 192);
            panel6.Controls.Add(txtRightDir);
            panel6.Controls.Add(btnRightDir);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 100);
            panel6.Name = "panel6";
            panel6.Size = new Size(468, 100);
            panel6.TabIndex = 1;
            panel6.Paint += panel6_Paint;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Location = new Point(12, 62);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(325, 26);
            txtRightDir.TabIndex = 3;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Right;
            btnRightDir.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(345, 46);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(107, 48);
            btnRightDir.TabIndex = 2;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 255);
            panel4.Controls.Add(btnCopyFromRight);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(468, 100);
            panel4.TabIndex = 0;
            panel4.Paint += panel4_Paint;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(15, 46);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(97, 48);
            btnCopyFromRight.TabIndex = 1;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(963, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Label lblAppName;
        private Button btnCopyFromLeft;
        private Button btnCopyFromRight;
        private ListView lvwLeftDir;
        private TextBox txtLeftDir;
        private Button btnLeftDir;
        private ListView lvwRightDir;
        private TextBox txtRightDir;
        private Button btnRightDir;
    }
}
