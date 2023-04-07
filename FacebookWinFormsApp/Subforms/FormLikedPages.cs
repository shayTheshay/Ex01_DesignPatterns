using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormLikedPages : Form
    {
        private readonly UserSession r_Session;
        private Page m_ChosenPage;

        public FormLikedPages(UserSession i_Session)
        {
            r_Session = i_Session;
            InitializeComponent();
            this.Shown += OnShown;
        }
        private void OnShown(object sender, EventArgs e)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in r_Session.User.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ChosenPage = (Page)listBoxLikedPages.SelectedItem;
        }

        private void buttonShareYourLove_Click(object sender, EventArgs e)
        {
            //r_Session.User.PostStatus("Boy do I love this page");
            MessageBox.Show("Sadly, there are no longer permissoions to post about your love of the page :(");
            fetchLikedPages();
        }
    }
}
