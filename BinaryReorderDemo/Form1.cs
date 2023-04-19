using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryReorderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFileName.Text = String.Empty;
        }

        string fileName;
        byte[] fileBytes;
        StringBuilder stringBuilder = new StringBuilder();

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            RefreshApp();
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
                lblFileName.Text = fileName;

                fileBytes = File.ReadAllBytes(fileName);
                Array.Reverse(fileBytes, 0, fileBytes.Length);

                MessageBox.Show("Use save buttons If you want the file to be saved.", "Reorder is succeed");
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save reordered binary into an existing file?", "Save into an existing file", MessageBoxButtons.YesNo);
            if (fileName != null && dialogResult == DialogResult.Yes)
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(fileName, FileMode.Truncate, FileAccess.Write)))
                {
                    binaryWriter.Write(fileBytes);
                    //binaryWriter.Flush();
                    MessageBox.Show("Saved!");
                    RefreshApp();
                }
            }
            else if (fileName == null && dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Choose file first!", "Exception");
            }
        }
        private void btnSaveIntoTextFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save into a text file the reordered binary?", "Save into a new file", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && fileBytes != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\txt";
                saveFileDialog.Filter = "Text Files Only (*.txt) | *.txt";
                saveFileDialog.DefaultExt = "txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                    using (StreamWriter streamWriter = new StreamWriter(stream))
                    {
                        foreach (byte b in fileBytes)
                        {
                            stringBuilder.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                        }
                        streamWriter.Write(stringBuilder.ToString());
                        MessageBox.Show("Saved!");
                        RefreshApp();
                    }
                }
            }
            else if (dialogResult == DialogResult.Yes && fileBytes == null)
            {
                MessageBox.Show("Choose file first!", "Exception");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void RefreshApp()
        {
            lblFileName.Text = String.Empty;
            fileName = null;
            fileBytes = null;
            stringBuilder = new StringBuilder();

        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fileName, "Reordered file");
        }
    }
}
