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

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();    
            frm.ShowDialog();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<PostEntities> list = new List<PostEntities>();
            PostBsn bsn = new PostBsn();
            list = bsn.GetPostsByUser(int.Parse(textBox1.Text));
            LstPosts.ValueMember = "PostId";
            LstPosts.DisplayMember = "Content";
            LstPosts.DataSource = list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<CommentEntities> list = new List<CommentEntities>();
            CommentBsn bsn = new CommentBsn();
            list = bsn.GetCommentsByPost(int.Parse(textBox2.Text));
            LstComments.ValueMember = "CommentId";
            LstComments.DisplayMember = "Content";
            LstComments.DataSource = list;
        }
    }
}