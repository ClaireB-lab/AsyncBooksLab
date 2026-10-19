namespace AsyncBooksLab
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
            label1 = new Label();
            txtFile = new TextBox();
            lstReport = new ListBox();
            btnBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnExit = new Button();
            btnSubmit = new Button();
            label2 = new Label();
            txtFile2 = new TextBox();
            btnBrowse2 = new Button();
            lstReport2 = new ListBox();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "File";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(64, 53);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(190, 27);
            txtFile.TabIndex = 1;
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.Location = new Point(26, 159);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(337, 264);
            lstReport.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(260, 51);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(393, 107);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(260, 107);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "File 2";
            // 
            // txtFile2
            // 
            txtFile2.Location = new Point(470, 50);
            txtFile2.Name = "txtFile2";
            txtFile2.Size = new Size(168, 27);
            txtFile2.TabIndex = 7;
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(658, 53);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(94, 29);
            btnBrowse2.TabIndex = 8;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // lstReport2
            // 
            lstReport2.FormattingEnabled = true;
            lstReport2.Location = new Point(411, 159);
            lstReport2.Name = "lstReport2";
            lstReport2.Size = new Size(341, 264);
            lstReport2.TabIndex = 9;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstReport2);
            Controls.Add(btnBrowse2);
            Controls.Add(txtFile2);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(btnBrowse);
            Controls.Add(lstReport);
            Controls.Add(txtFile);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFile;
        private ListBox lstReport;
        private Button btnBrowse;
        private OpenFileDialog openFileDialog1;
        private Button btnExit;
        private Button btnSubmit;
        private Label label2;
        private TextBox txtFile2;
        private Button btnBrowse2;
        private ListBox lstReport2;
        private OpenFileDialog openFileDialog2;
    }
}
