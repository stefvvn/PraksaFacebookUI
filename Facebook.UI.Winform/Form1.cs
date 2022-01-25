using Facebook.Business;
using Facebook.Entities;

namespace Facebook.UI.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<AccountUserInfoEntities> list = new List<AccountUserInfoEntities>();
            AccountUserInfoBsn bsn = new AccountUserInfoBsn();
            list = bsn.GetUserList();
            LstUsers.ValueMember = "UserIdNumber";
            LstUsers.DisplayMember = "UserName";
            LstUsers.DataSource = list;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PostEntities> listPostsByUser = new List<PostEntities>();
            PostBsn postlistbyuserbsn = new PostBsn();
            //int selecteduser = SelectedGridItemChangedEventArgs;
            //listPostsByUser = postlistbyuserbsn.GetPostsByUser(selecteduser);
            LstPosts.ValueMember = "PostId";
            LstPosts.DisplayMember = "Content";
            LstUsers.DataSource = listPostsByUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();    
            frm.ShowDialog();
        }
    }
}