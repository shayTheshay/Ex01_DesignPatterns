using BasicFacebookFeatures.Subforms;
using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private UserSession m_Session;
        private Form m_SelectedForm;
        private readonly string r_AppID = "888590382221810";

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginResult result = FacebookService.Login(
                    r_AppID, 
                    /// requested permissions:
					"email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "groups_show_list",
                    "groups_access_member_info",
                    "publish_to_groups",
                    "pages_manage_posts",
                    "pages_read_user_content");

            fetchLoggedInUser(result);
        }

        private void fetchLoggedInUser(LoginResult i_LoginResult)
        {
            m_Session = new UserSession(i_LoginResult);

            if (m_Session.LoginResult != null && !string.IsNullOrEmpty(m_Session.LoginResult.AccessToken))
            {
                enableAllButtons();
            }

            else
            {
                MessageBox.Show(m_Session.LoginResult.ErrorMessage, "Login Failed");
            }
        }
         
         private void buttonLogout_Click(object sender, EventArgs e)
         { 
            FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
            m_Session = null;
            disableAllButtons();
         }

        private void disableAllButtons()
        {
            foreach (Object obj in this.Controls)
            {
                if(obj.GetType() == typeof(Button))
                {
                    ((Button)obj).Enabled = false;
                }
            }

            buttonLogin.Enabled = true;
        }

        private void enableAllButtons()
        {
            foreach (Object obj in this.Controls)
            {
                if (obj.GetType() == typeof(Button))
                {
                    ((Button)obj).Enabled = true;
                }
            }

            buttonLogin.Enabled = false;
        }

        private void buttonUserDetails_Click(object sender, EventArgs e)
        {
            m_SelectedForm = new FormUserDetails(m_Session);
            m_SelectedForm.ShowDialog();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            m_SelectedForm = new FormGroupView(m_Session);
            m_SelectedForm.ShowDialog();
        }

        private void buttonCrossPost_Click(object sender, EventArgs e)
        {
            m_SelectedForm = new FormGroupCrossPost(m_Session);
            m_SelectedForm.ShowDialog();
        }

        private void AlbumsButtonView_Click(object sender, EventArgs e)
        {
            m_SelectedForm = new FormAlbumView(m_Session); ;
            m_SelectedForm.ShowDialog();

        }
        
        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            m_SelectedForm = new FormLikedPages(m_Session);
            m_SelectedForm.ShowDialog();
        }
        
        private void buttonSwapAlbumPictures_Click(object sender, EventArgs e)
        {
            m_SelectedForm = new FormAlbumCrosspost(m_Session);
            m_SelectedForm.ShowDialog();
        }
    }
}
