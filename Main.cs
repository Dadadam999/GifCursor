using System;
using System.Drawing;
using System.Windows.Forms;

namespace GifCursor
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();
        private void ApplyClick(object sender, EventArgs e) => new Picture(_previewImage.Image).Show();

        private void ImagePreviewDoubleClick(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _previewImage.Image = Image.FromFile(_openFileDialog.FileName);
                _labelDoubleClick.Visible = false;
            }
        }
    }
}