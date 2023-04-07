using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormAlbumCrosspost : Form
    {
        private readonly UserSession r_UserSession;
        private readonly AlbumManager r_AlbumManager;

        public FormAlbumCrosspost()
        {
            InitializeComponent();
        }

        public FormAlbumCrosspost(UserSession i_UserSession)
        {
            this.r_UserSession = i_UserSession;
            this.r_AlbumManager = new AlbumManager(i_UserSession.User);
            InitializeComponent();
            this.Shown += OnShown;
        }

        public void OnShown(Object sender, EventArgs e)
        {
            r_AlbumManager.fetchAlbums(listBoxSelectedFromAlbum);
            r_AlbumManager.fetchAlbums(ListBoxSelectedToAlbum);
        }

        private void listBoxFromAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_AlbumManager.fetchPictures(listBoxSelectedPicture, listBoxSelectedFromAlbum);
            pictureBoxShowAlbumPictureAdd.Image = null;
        }

        private void listBoxSelectedToAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAddPictureTo.Enabled = true;
        }

        private void listBoxSelectedPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            r_AlbumManager.presentPicturesInsdieAlbum(listBoxSelectedPicture, pictureBoxShowAlbumPictureAdd);
            ListBoxSelectedToAlbum.Enabled = true;
        }

        private void buttonAddPictureTo_Click(object sender, EventArgs e)
        {
            // Upload Photo currently disabled: Enable if permissions in the future will allow again
            //var selectedPhoto = listBoxSelectedPicture.SelectedItem;
            //m_toAlbum.UploadPhoto(selectedPhoto.ToString());
            MessageBox.Show("The permission relevant for the posting of a picture into album (post_actions) is depricated thus making the action unavailable \n what I would have done is take the format specified.\nThen adjust to the format and upload");
        }
    }
}

