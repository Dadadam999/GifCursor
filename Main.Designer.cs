
namespace GifCursor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._previewImage = new System.Windows.Forms.PictureBox();
            this._apply = new System.Windows.Forms.Button();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._labelDoubleClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._previewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // _previewImage
            // 
            this._previewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previewImage.Location = new System.Drawing.Point(0, 0);
            this._previewImage.Name = "_previewImage";
            this._previewImage.Size = new System.Drawing.Size(284, 208);
            this._previewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._previewImage.TabIndex = 0;
            this._previewImage.TabStop = false;
            this._previewImage.DoubleClick += new System.EventHandler(this.ImagePreviewDoubleClick);
            // 
            // _apply
            // 
            this._apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._apply.Location = new System.Drawing.Point(0, 208);
            this._apply.Name = "_apply";
            this._apply.Size = new System.Drawing.Size(284, 23);
            this._apply.TabIndex = 1;
            this._apply.Text = "Установить";
            this._apply.UseVisualStyleBackColor = true;
            this._apply.Click += new System.EventHandler(this.ApplyClick);
            // 
            // _labelDoubleClick
            // 
            this._labelDoubleClick.BackColor = System.Drawing.Color.Transparent;
            this._labelDoubleClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelDoubleClick.ForeColor = System.Drawing.SystemColors.ControlDark;
            this._labelDoubleClick.Location = new System.Drawing.Point(0, 0);
            this._labelDoubleClick.Name = "_labelDoubleClick";
            this._labelDoubleClick.Size = new System.Drawing.Size(284, 208);
            this._labelDoubleClick.TabIndex = 2;
            this._labelDoubleClick.Text = "Нажмите 2 раза на меня";
            this._labelDoubleClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._labelDoubleClick.DoubleClick += new System.EventHandler(this.ImagePreviewDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this._labelDoubleClick);
            this.Controls.Add(this._previewImage);
            this.Controls.Add(this._apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this._previewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _previewImage;
        private System.Windows.Forms.Button _apply;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.Label _labelDoubleClick;
    }
}

