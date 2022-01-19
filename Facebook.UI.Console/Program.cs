using Facebook.Business;
using Facebook.Entities;

Console.WriteLine("Prvi user");
AccountUserInfoBsn bsn = new AccountUserInfoBsn();
AccountUserInfoEntities user = bsn.GetUserByID(1);
Console.WriteLine(user.UserName);
Console.WriteLine(user.FirstName);
Console.WriteLine(user.City);
Console.WriteLine(user.LastName);
Console.WriteLine(user.GenderString);
Console.WriteLine(user.ProfileDescription);
Console.WriteLine(user.DateOfBirth.ToString());
Console.WriteLine(user.DateMade.ToString());
Console.WriteLine(user.EmailAddress);

Console.WriteLine("Drugi user");
AccountUserInfoEntities user1 = bsn.GetUserByID(9);
Console.WriteLine(user1.UserName);
Console.WriteLine(user1.FirstName);
Console.WriteLine(user1.City);
Console.WriteLine(user1.LastName);
Console.WriteLine(user1.GenderString);
Console.WriteLine(user1.ProfileDescription);
Console.WriteLine(user1.DateOfBirth.ToString());
Console.WriteLine(user1.DateMade.ToString());
Console.WriteLine(user1.EmailAddress);

AccountUserInfoEntities user2 = new AccountUserInfoEntities();
user2.UserName = "NewUser";
user2.FirstName = "Test";
user2.LastName = "Korisnik";
user2.EmailAddress = "testemail@gmail.com";
user2.City = "TestGrad";
user2.Gender = 1;
user2.DateOfBirth = DateTime.Parse("1995-12-30");
user2.ProfileDescription = "Test profile description";
bsn.InsertUser(user2);

AccountUserInfoEntities user3 = bsn.UpdateUserAccountInfo(user1);
user3.FirstName = "Wasdwasd";
user3.UserName = "AAAAAA";
user3.FirstName = "AAAAAA";
user3.LastName = "AAAAAA";
user3.EmailAddress = "AAAAAA@gmail.com";
user3.City = "AAAAAA";
user3.Gender = 1;
user3.DateOfBirth = DateTime.Parse("1913-11-12");
user3.ProfileDescription = "AAAAAAAAAAAA";
bsn.UpdateUserAccountInfo(user1);

List<AccountUserInfoEntities> list = new List<AccountUserInfoEntities>();
AccountUserInfoBsn userlistbsn = new AccountUserInfoBsn();
list = bsn.GetUserList();
foreach (AccountUserInfoEntities item in list)
    Console.WriteLine(item.UserIdNumber.ToString() + " " + item.FirstName.ToString() + " " + item.LastName.ToString());
//int id = int.Parse(Console.ReadLine());
//AccountUserInfoEntities user4 = bsn.GetUserByID(Convert.ToInt32(id.ToString()));

AccountUserInfoEntities user4 = bsn.DeleteUserByID(35);

Console.WriteLine("Prvi post");
PostBsn postbsn = new PostBsn();
PostEntities post = postbsn.GetPostByID(1);
Console.WriteLine(post.UserId);
Console.WriteLine(post.Content);
Console.WriteLine(post.DateMade.ToString());

Console.WriteLine("Peti post");
PostEntities post1 = postbsn.GetPostByID(7);
Console.WriteLine(post1.UserId);
Console.WriteLine(post1.Content);
Console.WriteLine(post1.DateMade.ToString());

//PostEntities post2 = new PostEntities();
//post2.UserId = 4;
//post2.Content = "novi post";
//postbsn.InsertPost(post2);

PostEntities post3 = postbsn.UpdatePost(post1);
post3.Content = "testupdate";
postbsn.UpdatePost(post1);

List<PostEntities> postlist = new List<PostEntities>();
PostBsn postlistbsn = new PostBsn();
postlist = postlistbsn.GetPostList();
foreach (PostEntities postlistitem in postlist)
    Console.WriteLine(postlistitem.PostId.ToString() + " " + postlistitem.UserId.ToString() + " " + postlistitem.Content.ToString());
//int postlistid = int.Parse(Console.ReadLine());
//PostEntities post4 = postlistbsn.GetPostByID(Convert.ToInt32(postlistid.ToString()));


Console.WriteLine("Prvi komentar");
CommentBsn commentbsn = new CommentBsn();
CommentEntities comment = commentbsn.GetCommentByID(1);
Console.WriteLine(comment.UserId);
Console.WriteLine(comment.Content);
Console.WriteLine(comment.DateMade.ToString());

Console.WriteLine("Deveti komentar");
CommentEntities comment1 = commentbsn.GetCommentByID(9);
Console.WriteLine(comment1.UserId);
Console.WriteLine(comment1.Content);
Console.WriteLine(comment1.DateMade.ToString());

//CommentEntities comment2 = new CommentEntities();
//comment2.PostId = 1;
//comment2.UserId = 1;
//comment2.Content = "novi komentar";
//commentbsn.InsertComment(comment2);

CommentEntities comment3 = commentbsn.UpdateComment(comment1);
comment3.Content = "testupdate";
commentbsn.UpdateComment(comment1);

List<CommentEntities> commentlist = new List<CommentEntities>();
CommentBsn commentlistbsn = new CommentBsn();
commentlist = commentlistbsn.GetCommentList();
foreach (CommentEntities commentitem in commentlist)
    Console.WriteLine(commentitem.CommentId.ToString() + " " + commentitem.UserId.ToString() + " " + commentitem.PostId.ToString() + " " + commentitem.Content.ToString());
//int commentlistid = int.Parse(Console.ReadLine());
//CommentEntities comment4 = commentlistbsn.GetCommentByID(Convert.ToInt32(commentlistid.ToString()));