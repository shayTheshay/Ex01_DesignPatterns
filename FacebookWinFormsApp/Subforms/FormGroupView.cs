using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures.Subforms
{
    public partial class FormGroupView : Form
    {
        private readonly UserSession r_Session;
        private Group m_SelectedGroup;
        private readonly GroupManager r_GroupManager;
        public FormGroupView(UserSession i_Session)
        {
            r_Session = i_Session;
            r_GroupManager = new GroupManager(r_Session.User);
            r_GroupManager.ErrorCallbacks += notAdminError;
            InitializeComponent();
            this.Shown += OnShown;
        }
        private void OnShown(object sender, EventArgs e)
        {
            r_GroupManager.FetchUserGroupsToListBox(listBoxGroups);
        }
        
        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedGroup = (Group)listBoxGroups.SelectedItem;
            buttonPost.Enabled = true;
            r_GroupManager.FetchUserStatusesInGroupToListBox(m_SelectedGroup, listBoxStatuses);
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            r_GroupManager.PostToGroup(m_SelectedGroup,textBoxStatus.Text);
            r_GroupManager.FetchUserStatusesInGroupToListBox(m_SelectedGroup, listBoxStatuses);
        }
        private void notAdminError()
        {
            MessageBox.Show("Cannot get information from group without admin permissions");
            buttonPost.Enabled = false;
        }
    }
}
