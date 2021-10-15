using System;
using System.Drawing;
using System.Windows.Forms;

namespace GifCursor
{
    public partial class Picture : Form
    {
        public Picture(Image image)
        {
            InitializeComponent();
            _imageView.Image = image;
        }

        private void PictureLoad(object sender, EventArgs e) => _timerMove.Start();

        private void TimerMoveTick(object sender, EventArgs e) => Invoke((MethodInvoker)delegate
        {
            Left = Cursor.Position.X - Width - 10;
            Top = Cursor.Position.Y - Height - 10;
        });
    }
}