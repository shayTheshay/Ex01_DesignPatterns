namespace BasicFacebookFeatures.Subforms
{
    partial class FormAlbumView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbumView));
            this.listBoxAlbumsShow = new System.Windows.Forms.ListBox();
            this.listBoxImageAlbum = new System.Windows.Forms.ListBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.pictureBoxPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbumsShow
            // 
            this.listBoxAlbumsShow.FormattingEnabled = true;
            this.listBoxAlbumsShow.ItemHeight = 20;
            this.listBoxAlbumsShow.Location = new System.Drawing.Point(12, 25);
            this.listBoxAlbumsShow.Name = "listBoxAlbumsShow";
            this.listBoxAlbumsShow.Size = new System.Drawing.Size(153, 184);
            this.listBoxAlbumsShow.TabIndex = 0;
            this.listBoxAlbumsShow.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumsShow_SelectedIndexChanged);
            // 
            // listBoxImageAlbum
            // 
            this.listBoxImageAlbum.FormattingEnabled = true;
            this.listBoxImageAlbum.ItemHeight = 20;
            this.listBoxImageAlbum.Location = new System.Drawing.Point(12, 212);
            this.listBoxImageAlbum.Name = "listBoxImageAlbum";
            this.listBoxImageAlbum.Size = new System.Drawing.Size(153, 184);
            this.listBoxImageAlbum.TabIndex = 2;
            this.listBoxImageAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxImageAlbum_SelectedIndexChanged);
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Location = new System.Drawing.Point(225, 28);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(252, 181);
            this.pictureBoxAlbum.TabIndex = 3;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.Location = new System.Drawing.Point(225, 212);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.Size = new System.Drawing.Size(252, 181);
            this.pictureBoxPicture.TabIndex = 4;
            this.pictureBoxPicture.TabStop = false;
            // 
            // FormAlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPicture);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxImageAlbum);
            this.Controls.Add(this.listBoxAlbumsShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlbumView";
            this.Text = "Facebook - Albums";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbumsShow;
        private System.Windows.Forms.ListBox listBoxImageAlbum;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.PictureBox pictureBoxPicture;
    }
}