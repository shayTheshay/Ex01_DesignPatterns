namespace BasicFacebookFeatures.Subforms
{
    partial class FormGroupCrossPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroupCrossPost));
            this.listBoxStatuses = new System.Windows.Forms.ListBox();
            this.listBoxGroupsFrom = new System.Windows.Forms.ListBox();
            this.listBoxGroupsTo = new System.Windows.Forms.ListBox();
            this.buttonCrossPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStatuses
            // 
            this.listBoxStatuses.FormattingEnabled = true;
            this.listBoxStatuses.ItemHeight = 20;
            this.listBoxStatuses.Location = new System.Drawing.Point(234, 51);
            this.listBoxStatuses.Name = "listBoxStatuses";
            this.listBoxStatuses.Size = new System.Drawing.Size(224, 224);
            this.listBoxStatuses.TabIndex = 5;
            this.listBoxStatuses.SelectedIndexChanged += new System.EventHandler(this.listBoxStatuses_SelectedIndexChanged);
            // 
            // listBoxGroupsFrom
            // 
            this.listBoxGroupsFrom.FormattingEnabled = true;
            this.listBoxGroupsFrom.ItemHeight = 20;
            this.listBoxGroupsFrom.Location = new System.Drawing.Point(12, 51);
            this.listBoxGroupsFrom.Name = "listBoxGroupsFrom";
            this.listBoxGroupsFrom.Size = new System.Drawing.Size(203, 224);
            this.listBoxGroupsFrom.TabIndex = 4;
            this.listBoxGroupsFrom.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupsFrom_SelectedIndexChanged);
            // 
            // listBoxGroupsTo
            // 
            this.listBoxGroupsTo.FormattingEnabled = true;
            this.listBoxGroupsTo.ItemHeight = 20;
            this.listBoxGroupsTo.Location = new System.Drawing.Point(480, 51);
            this.listBoxGroupsTo.Name = "listBoxGroupsTo";
            this.listBoxGroupsTo.Size = new System.Drawing.Size(203, 224);
            this.listBoxGroupsTo.TabIndex = 6;
            this.listBoxGroupsTo.SelectedIndexChanged += new System.EventHandler(this.listBoxGroupsTo_SelectedIndexChanged);
            // 
            // buttonCrossPost
            // 
            this.buttonCrossPost.Location = new System.Drawing.Point(234, 303);
            this.buttonCrossPost.Name = "buttonCrossPost";
            this.buttonCrossPost.Size = new System.Drawing.Size(224, 57);
            this.buttonCrossPost.TabIndex = 7;
            this.buttonCrossPost.Text = "Cross Post";
            this.buttonCrossPost.UseVisualStyleBackColor = true;
            this.buttonCrossPost.Click += new System.EventHandler(this.buttonCrossPost_Click);
            // 
            // FormCrossPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCrossPost);
            this.Controls.Add(this.listBoxGroupsTo);
            this.Controls.Add(this.listBoxStatuses);
            this.Controls.Add(this.listBoxGroupsFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCrossPost";
            this.Text = "Facebook - CrossPost";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStatuses;
        private System.Windows.Forms.ListBox listBoxGroupsFrom;
        private System.Windows.Forms.ListBox listBoxGroupsTo;
        private System.Windows.Forms.Button buttonCrossPost;
    }
}