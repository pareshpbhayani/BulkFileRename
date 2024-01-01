using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BulkFileRename
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private string _photoFolder;
        private int _totalFiles;

        List<string> _ext = new List<string> { "*.jpeg", "*.jpg", "*.png" };

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (!string.IsNullOrEmpty(_photoFolder))
                {
                    dialog.SelectedPath = _photoFolder;
                }
                dialog.ShowDialog();
                _photoFolder = dialog.SelectedPath;
                _totalFiles = 0;
                if (!string.IsNullOrEmpty(_photoFolder))
                {
                    foreach (var item in _ext)
                    {
                        _totalFiles += Directory.GetFiles(_photoFolder, item, SearchOption.TopDirectoryOnly).Length;
                    }
                    //string[] subdirectoryEntries = Directory.GetFiles(_photoFolder, "*.jpg|*.png", SearchOption.TopDirectoryOnly);
                    //_totalFiles = subdirectoryEntries.Length;
                    txtTotalFiles.Text = _totalFiles.ToString();
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            int counter = 1;
            int renamedFiles = 0;
            if (string.IsNullOrEmpty(txtNewName.Text))
            {
                MessageBox.Show(@"Please enter product SKU/Barcode.", @"Bulk Rename", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(_photoFolder))
            {
                MessageBox.Show(@"Please browse/select a folder.", @"Bulk Rename", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                foreach (var item in _ext)
                {
                    foreach (var item1 in Directory.GetFiles(_photoFolder, item, SearchOption.TopDirectoryOnly))
                    {
                        var newFileName = txtNewName.Text + "_" + counter +
                                          Path.GetExtension(item1);
                        var directoryName = Path.GetDirectoryName(item1);
                        FileInfo fi = new FileInfo(item1);
                        {
                            if (!File.Exists(directoryName + "\\" + newFileName))
                            {
                                fi.MoveTo(directoryName + "\\" + newFileName);
                                renamedFiles++;
                            }
                            counter++;
                        }
                    }
                }
            }

            if (counter > 0)
            {
                MessageBox.Show(renamedFiles + @" Files are renamed.", @"Bulk Rename", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }
    }
}
