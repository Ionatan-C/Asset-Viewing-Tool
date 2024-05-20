namespace Asset_Viewing_Tool
{
    partial class AssetViewingTool
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
            MainCloseBtn = new Button();
            textBox1 = new TextBox();
            LibraryBtn = new Button();
            MinimizeBtn = new Button();
            SuspendLayout();
            // 
            // MainCloseBtn
            // 
            MainCloseBtn.BackColor = Color.FromArgb(192, 0, 0);
            MainCloseBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainCloseBtn.ForeColor = SystemColors.Desktop;
            MainCloseBtn.Location = new Point(752, 12);
            MainCloseBtn.Name = "MainCloseBtn";
            MainCloseBtn.Size = new Size(36, 40);
            MainCloseBtn.TabIndex = 0;
            MainCloseBtn.Text = "X";
            MainCloseBtn.UseVisualStyleBackColor = false;
            MainCloseBtn.Click += MainCloseBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuHighlight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Times New Roman", 24F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(268, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 37);
            textBox1.TabIndex = 1;
            textBox1.Text = "Asset Viewing Tool";
            // 
            // LibraryBtn
            // 
            LibraryBtn.Location = new Point(268, 327);
            LibraryBtn.Name = "LibraryBtn";
            LibraryBtn.Size = new Size(259, 27);
            LibraryBtn.TabIndex = 2;
            LibraryBtn.Text = "Library";
            LibraryBtn.UseVisualStyleBackColor = true;
            LibraryBtn.Click += LibraryBtn_Click;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.BackColor = Color.Gray;
            MinimizeBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimizeBtn.ForeColor = SystemColors.Desktop;
            MinimizeBtn.Location = new Point(12, 12);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(36, 40);
            MinimizeBtn.TabIndex = 3;
            MinimizeBtn.Text = "-";
            MinimizeBtn.UseVisualStyleBackColor = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // AssetViewingTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(MinimizeBtn);
            Controls.Add(LibraryBtn);
            Controls.Add(textBox1);
            Controls.Add(MainCloseBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AssetViewingTool";
            Text = "AssetViewingTool";
            MouseDown += AssetViewingTool_MouseDown;
            MouseMove += AssetViewingTool_MouseMove;
            MouseUp += AssetViewingTool_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainCloseBtn;
        private TextBox textBox1;
        private Button LibraryBtn;
        private Button MinimizeBtn;
    }
}