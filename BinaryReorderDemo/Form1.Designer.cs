namespace BinaryReorderDemo
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
            this.components = new System.ComponentModel.Container();
            this.lblFileName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveIntoTextFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(135, 91);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(13, 13);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "--";
            this.toolTip1.SetToolTip(this.lblFileName, "Click to see full file name");
            this.lblFileName.Click += new System.EventHandler(this.lblFileName_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnSaveIntoTextFile);
            this.panel2.Controls.Add(this.btnSaveFile);
            this.panel2.Controls.Add(this.btnOpenFile);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 178);
            this.panel2.TabIndex = 11;
            // 
            // btnSaveIntoTextFile
            // 
            this.btnSaveIntoTextFile.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIntoTextFile.Location = new System.Drawing.Point(12, 130);
            this.btnSaveIntoTextFile.Name = "btnSaveIntoTextFile";
            this.btnSaveIntoTextFile.Size = new System.Drawing.Size(111, 23);
            this.btnSaveIntoTextFile.TabIndex = 6;
            this.btnSaveIntoTextFile.Text = "Save into Text File";
            this.toolTip1.SetToolTip(this.btnSaveIntoTextFile, "Save into text file the reordered binary");
            this.btnSaveIntoTextFile.UseVisualStyleBackColor = true;
            this.btnSaveIntoTextFile.Click += new System.EventHandler(this.btnSaveIntoTextFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Location = new System.Drawing.Point(12, 80);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(111, 23);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "Save File";
            this.toolTip1.SetToolTip(this.btnSaveFile, "Save the file you reorderd");
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(12, 30);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(111, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open File";
            this.toolTip1.SetToolTip(this.btnOpenFile, "Opens the file and automatically reorders the binary in reverse ");
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 51);
            this.panel1.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BinaryReorderDemo.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(315, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnExit, "Exit");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binary Reorder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 229);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveIntoTextFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

