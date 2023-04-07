using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{

    public class AlbumManager
    {
        //private readonly User r_User;
        //private readonly Album<Album> r_album;
        //private readonly UserSession r_UserSession;
        //private readonly ListBox r_ListBoxFrom;
        //private readonly ListBox r_ListBoxTo;
        //private PictureBox m_PictureBox;
        private readonly User r_User;

        public AlbumManager(User i_User)
        {
            this.r_User = i_User;

        }


        public void fetchAlbums(ListBox listBoxAlbumShow)
        {
            listBoxAlbumShow.Items.Clear();
            listBoxAlbumShow.DisplayMember = "Name";
            foreach (Album album in r_User.Albums)
            {
                listBoxAlbumShow.Items.Add(album);
                album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (listBoxAlbumShow.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve");
            }
        }
        public void presentAlbumImages(ListBox listBoxAlbumsShow, PictureBox pictureBoxAlbum)
        {
            if (listBoxAlbumsShow.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbumsShow.SelectedItem as Album;
                if (selectedAlbum != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureSmallURL);
                }
                else
                {
                    pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
                }
            }

        }


        public void fetchPictures(ListBox i_ListBoxPicturesShow, ListBox i_ListBoxAlbumsShow)
        {
            try
            {
                i_ListBoxPicturesShow.Items.Clear();
                i_ListBoxPicturesShow.DisplayMember = "Name";
                Album selectedAlbum = i_ListBoxAlbumsShow.SelectedItem as Album;
                FacebookObjectCollection<Photo> selectedAlbumPictures = selectedAlbum.Photos;
                foreach (Photo picture in selectedAlbumPictures)
                {
                    i_ListBoxPicturesShow.Items.Add(picture.PictureAlbumURL);

                }

                if (i_ListBoxPicturesShow.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Error accured");
            }
        }

        public void presentPicturesInsdieAlbum(ListBox i_ListBoxPicturesShow, PictureBox pictureBoxPictures)
        {
            if (i_ListBoxPicturesShow.SelectedItems.Count == 1)
            {
                var selectedPhoto = i_ListBoxPicturesShow.SelectedItem;
                if (selectedPhoto != null)
                {
                    pictureBoxPictures.LoadAsync(selectedPhoto.ToString());
                }
                else
                {
                    pictureBoxPictures.Image = pictureBoxPictures.ErrorImage;
                }
            }
        }

       // public void addPictureToAlbum(ListBox i_ListBoxPicturesShow, )

    }
}