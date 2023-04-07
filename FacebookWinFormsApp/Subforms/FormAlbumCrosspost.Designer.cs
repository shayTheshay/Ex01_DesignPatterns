namespace BasicFacebookFeatures.Subforms
{
    partial class FormAlbumCrosspost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbumCrosspost));
            this.listBoxSelectedFromAlbum = new System.Windows.Forms.ListBox();
            this.listBoxSelectedPicture = new System.Windows.Forms.ListBox();
            this.pictureBoxShowAlbumPictureAdd = new System.Windows.Forms.PictureBox();
            this.ListBoxSelectedToAlbum = new System.Windows.Forms.ListBox();
            this.buttonAddPictureTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowAlbumPictureAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxSelectedFromAlbum
            // 
            this.listBoxSelectedFromAlbum.FormattingEnabled = true;
            this.listBoxSelectedFromAlbum.ItemHeight = 20;
            this.listBoxSelectedFromAlbum.Location = new System.Drawing.Point(26, 32);
            this.listBoxSelectedFromAlbum.Name = "listBoxSelectedFromAlbum";
            this.listBoxSelectedFromAlbum.Size = new System.Drawing.Size(125, 184);
            this.listBoxSelectedFromAlbum.TabIndex = 0;
            this.listBoxSelectedFromAlbum.SelectedIndexChanged += new System.EventHandler(this.listBoxFromAlbum_SelectedIndexChanged);
            // 
            // listBoxSelectedPicture
            // 
            this.listBoxSelectedPicture.FormattingEnabled = true;
            this.listBoxSelectedPicture.ItemHeight = 20;
            this.listBoxSelectedPicture.Location = new System.Drawing.Point(225, 32);
            this.listBoxSelectedPicture.Name = "listBoxSelectedPicture";
            this.listBoxSelectedPicture.Size = new System.Drawing.Size(125, 184);
            this.listBoxSelectedPicture.TabIndex = 1;
            this.listBoxSelectedPicture.SelectedIndexChanged += new System.EventHandler(this.listBoxSelectedPicture_SelectedIndexChanged);
            // 
            // pictureBoxShowAlbumPictureAdd
            // 
            this.pictureBoxShowAlbumPictureAdd.Location = new System.Drawing.Point(82, 248);
            this.pictureBoxShowAlbumPictureAdd.Name = "pictureBoxShowAlbumPictureAdd";
            this.pictureBoxShowAlbumPictureAdd.Size = new System.Drawing.Size(211, 184);
            this.pictureBoxShowAlbumPictureAdd.TabIndex = 2;
            this.pictureBoxShowAlbumPictureAdd.TabStop = false;
            // 
            // ListBoxSelectedToAlbum
            // 
            this.ListBoxSelectedToAlbum.Enabled = false;
            this.ListBoxSelectedToAlbum.FormattingEnabled = true;
            this.ListBoxSelectedToAlbum.ItemHeight = 20;
            this.ListBoxSelectedToAlbum.Location = new System.Drawing.Point(419, 32);
            this.ListBoxSelectedToAlbum.Name = "ListBoxSelectedToAlbum";
            this.ListBoxSelectedToAlbum.Size = new System.Drawing.Size(125, 184);
            this.ListBoxSelectedToAlbum.TabIndex = 5;
            // 
            // buttonAddPictureTo
            // 
            this.buttonAddPictureTo.Enabled = false;
            this.buttonAddPictureTo.Location = new System.Drawing.Point(419, 248);
            this.buttonAddPictureTo.Name = "buttonAddPictureTo";
            this.buttonAddPictureTo.Size = new System.Drawing.Size(125, 51);
            this.buttonAddPictureTo.TabIndex = 6;
            this.buttonAddPictureTo.Text = "Add Picture";
            this.buttonAddPictureTo.UseVisualStyleBackColor = true;
            this.buttonAddPictureTo.Click += new System.EventHandler(this.buttonAddPictureTo_Click);
            // 
            // FormAddPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.buttonAddPictureTo);
            this.Controls.Add(this.ListBoxSelectedToAlbum);
            this.Controls.Add(this.pictureBoxShowAlbumPictureAdd);
            this.Controls.Add(this.listBoxSelectedPicture);
            this.Controls.Add(this.listBoxSelectedFromAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddPicture";
            this.Text = "Facebook - Add Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowAlbumPictureAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelectedFromAlbum;
        private System.Windows.Forms.ListBox listBoxSelectedPicture;
        private System.Windows.Forms.PictureBox pictureBoxShowAlbumPictureAdd;
        private System.Windows.Forms.ListBox ListBoxSelectedToAlbum;
        private System.Windows.Forms.Button buttonAddPictureTo;
    }
}