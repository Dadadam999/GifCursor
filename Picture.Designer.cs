
namespace GifCursor
{
    partial class Picture
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
            this._imageView = new System.Windows.Forms.PictureBox();
            this._timerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // _imageView
            // 
            this._imageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageView.Location = new System.Drawing.Point(0, 0);
            this._imageView.Name = "_imageView";
            this._imageView.Size = new System.Drawing.Size(200, 200);
            this._imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._imageView.TabIndex = 0;
            this._imageView.TabStop = false;
            // 
            // _timerMove
            // 
            this._timerMove.Interval = 25;
            this._timerMove.Tick += new System.EventHandler(this.TimerMoveTick);
            // 
            // Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this._imageView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Picture";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.PictureLoad);
            ((System.ComponentModel.ISupportInitialize)(this._imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _imageView;
        private System.Windows.Forms.Timer _timerMove;
    }
}