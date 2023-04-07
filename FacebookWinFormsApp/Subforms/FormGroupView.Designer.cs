namespace BasicFacebookFeatures.Subforms
{
    partial class FormGroupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupView));
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.listBoxStatuses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(21, 22);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(203, 224);
            this.listBoxGroups.TabIndex = 0;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(241, 22);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(221, 26);
            this.textBoxStatus.TabIndex = 1;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(257, 54);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(179, 35);
            this.buttonPost.TabIndex = 2;
            this.buttonPost.Text = "Post to selected group";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // listBoxStatuses
            // 
            this.listBoxStatuses.FormattingEnabled = true;
            this.listBoxStatuses.ItemHeight = 20;
            this.listBoxStatuses.Location = new System.Drawing.Point(241, 102);
            this.listBoxStatuses.Name = "listBoxStatuses";
            this.listBoxStatuses.Size = new System.Drawing.Size(224, 144);
            this.listBoxStatuses.TabIndex = 3;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 277);
            this.Controls.Add(this.listBoxStatuses);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.listBoxGroups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGroups";
            this.Text = "Facebook - Groups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ListBox listBoxStatuses;
    }
}