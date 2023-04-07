
namespace BasicFacebookFeatures.Subforms
{
    partial class FormLikedPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLikedPages));
            this.buttonShareYourLove = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonShareYourLove
            // 
            this.buttonShareYourLove.Location = new System.Drawing.Point(248, 126);
            this.buttonShareYourLove.Name = "buttonShareYourLove";
            this.buttonShareYourLove.Size = new System.Drawing.Size(178, 35);
            this.buttonShareYourLove.TabIndex = 4;
            this.buttonShareYourLove.Text = "Share Your Love!";
            this.buttonShareYourLove.UseVisualStyleBackColor = true;
            this.buttonShareYourLove.Click += new System.EventHandler(this.buttonShareYourLove_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 20;
            this.listBoxLikedPages.Location = new System.Drawing.Point(16, 46);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(204, 224);
            this.listBoxLikedPages.TabIndex = 3;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 305);
            this.Controls.Add(this.buttonShareYourLove);
            this.Controls.Add(this.listBoxLikedPages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLikedPages";
            this.Text = "Facebook - Liked Pages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShareYourLove;
        private System.Windows.Forms.ListBox listBoxLikedPages;
    }
}