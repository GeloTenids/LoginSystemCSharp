using LoginModel;
using LoginDL;

namespace LoginBL
{
    public class LoginService
    {
        public List<Accounts> getUser()
        {
            LoginData data = new LoginData();
            return data.GetUsers();
        }
        public bool verifyUser(int accNUm, int pinNum)
        {
            bool result = new bool();
            foreach (var users in getUser())
            {
                if (users.accNumber == accNUm && users.pinNumber == pinNum)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
