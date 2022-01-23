using Facebook.Data.SQL;
using Facebook.Entities;

namespace Facebook.Business
{
    public class AccountUserInfoBsn
    {
        public AccountUserInfoEntities InsertUser(AccountUserInfoEntities user)
        {
            AccountUserInfoData data = new AccountUserInfoData();
            return data.InsertUser(user);
        }
        public AccountUserInfoEntities GetUserByID(int Id)
        {
            AccountUserInfoData data = new AccountUserInfoData();
            return data.GetUserByID(Id);
        }
        public AccountUserInfoEntities UpdateUserAccountInfo(AccountUserInfoEntities user)
        {
            AccountUserInfoData data = new AccountUserInfoData();
            return data.UpdateUserAccountInfo(user);
        }
        public AccountUserInfoEntities DeleteUserByID(int Id)
        {
            AccountUserInfoData data = new AccountUserInfoData();
            return data.DeleteUserByID(Id);
        }
        public List<AccountUserInfoEntities> GetUserList()
        {
            AccountUserInfoData data = new AccountUserInfoData();
            //logika ide ovde
            return data.GetUserList();
        }
        public List<AccountUserInfoEntities> GetUserByCity()
        {
            AccountUserInfoData data = new AccountUserInfoData();
            return data.GetUserByCity();
        }
    }
}