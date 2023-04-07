namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUserDetails = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonCrossPost = new System.Windows.Forms.Button();
            this.buttonAlbumPhotos = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.buttonSwapAlbumPictures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 14);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 35);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(309, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUserDetails
            // 
            this.buttonUserDetails.Enabled = false;
            this.buttonUserDetails.Location = new System.Drawing.Point(12, 99);
            this.buttonUserDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserDetails.Name = "buttonUserDetails";
            this.buttonUserDetails.Size = new System.Drawing.Size(268, 35);
            this.buttonUserDetails.TabIndex = 59;
            this.buttonUserDetails.Text = "User Details";
            this.buttonUserDetails.UseVisualStyleBackColor = true;
            this.buttonUserDetails.Click += new System.EventHandler(this.buttonUserDetails_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Enabled = false;
            this.buttonGroups.Location = new System.Drawing.Point(12, 159);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(268, 35);
            this.buttonGroups.TabIndex = 60;
            this.buttonGroups.Text = "View Groups";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonCrossPost
            // 
            this.buttonCrossPost.Enabled = false;
            this.buttonCrossPost.Location = new System.Drawing.Point(309, 159);
            this.buttonCrossPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCrossPost.Name = "buttonCrossPost";
            this.buttonCrossPost.Size = new System.Drawing.Size(268, 35);
            this.buttonCrossPost.TabIndex = 61;
            this.buttonCrossPost.Text = "Cross Post Between Groups";
            this.buttonCrossPost.UseVisualStyleBackColor = true;
            this.buttonCrossPost.Click += new System.EventHandler(this.buttonCrossPost_Click);
            // 
            // buttonAlbumPhotos
            // 
            this.buttonAlbumPhotos.Enabled = false;
            this.buttonAlbumPhotos.Location = new System.Drawing.Point(13, 222);
            this.buttonAlbumPhotos.Name = "buttonAlbumPhotos";
            this.buttonAlbumPhotos.Size = new System.Drawing.Size(268, 35);
            this.buttonAlbumPhotos.TabIndex = 63;
            this.buttonAlbumPhotos.Text = "View Albums";
            this.buttonAlbumPhotos.UseVisualStyleBackColor = true;
            this.buttonAlbumPhotos.Click += new System.EventHandler(this.AlbumsButtonView_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Enabled = false;
            this.buttonLikedPages.Location = new System.Drawing.Point(309, 99);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(268, 35);
            this.buttonLikedPages.TabIndex = 64;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // buttonSwapAlbumPictures
            // 
            this.buttonSwapAlbumPictures.Enabled = false;
            this.buttonSwapAlbumPictures.Location = new System.Drawing.Point(309, 222);
            this.buttonSwapAlbumPictures.Name = "buttonSwapAlbumPictures";
            this.buttonSwapAlbumPictures.Size = new System.Drawing.Size(268, 35);
            this.buttonSwapAlbumPictures.TabIndex = 65;
            this.buttonSwapAlbumPictures.Text = "Cross Post Between Albums";
            this.buttonSwapAlbumPictures.UseVisualStyleBackColor = true;
            this.buttonSwapAlbumPictures.Click += new System.EventHandler(this.buttonSwapAlbumPictures_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(611, 283);
            this.Controls.Add(this.buttonSwapAlbumPictures);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonAlbumPhotos);
            this.Controls.Add(this.buttonCrossPost);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.buttonUserDetails);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook - MainMenu";
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonUserDetails;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonCrossPost;
        private System.Windows.Forms.Button buttonAlbumPhotos;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonSwapAlbumPictures;
    }
}

