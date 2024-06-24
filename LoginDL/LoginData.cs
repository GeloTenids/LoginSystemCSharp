using LoginModel;

namespace LoginDL
{
    public class LoginData
    {
        List<Accounts> users;
        LoginDbData sqlData;
        public LoginData()
        {
            users = new List<Accounts>();
            sqlData = new LoginDbData();
        }

        public List<Accounts> GetUsers()
        {
            users = sqlData.GetUsers();
            return users;
        }
    }
}
