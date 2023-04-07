using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.Subforms
{
    public partial class FormUserDetails : Form
    {
        private readonly UserSession r_Session;

        public FormUserDetails(UserSession i_Session)
        {
            r_Session = i_Session;
            InitializeComponent();
            this.Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            fetchAndDisplayUserInfo();
        }

        private void fetchAndDisplayUserInfo()
        {
            labelUserName.Text = r_Session.User.Name + "!";
            labelBirthday.Text = r_Session.User.Birthday;
            labelAge.Text = getAge().ToString();
            labelEmail.Text = r_Session.User.Email;
            labelGender.Text = r_Session.User.Gender.ToString();
            labelFriendCount.Text = r_Session.User.Friends.Count.ToString();
            labelRelashionship.Text = r_Session.User.RelationshipStatus.ToString();
            pictureBoxProfile.LoadAsync(r_Session.User.PictureNormalURL);
            labelLocation.Text = r_Session.User.Location.Name;
        }

        private int getAge()
        {
            int agecurr = 0;
            if (r_Session.User.Birthday != null)
            {
                DateTime birthday = new DateTime();
                try
                {
                    birthday = DateTime.ParseExact(r_Session.User.Birthday, "dd/MM/yyyy", null);
                }
                catch
                {
                    birthday = DateTime.ParseExact(r_Session.User.Birthday, "MM/dd/yyyy", null);
                }

                DateTime today = DateTime.Today;
                agecurr = today.Year - birthday.Year;
                if (birthday > today.AddYears(-agecurr))
                    agecurr--;

            }
            return agecurr;
        }

    }
}
