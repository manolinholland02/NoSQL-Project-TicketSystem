using DAL;
using Model;

namespace Logic
{
    public class UserService
    {
        private UserDAO dao;
        //Singleton for UserService
        private static UserService instance;

        private UserService()
        {
            dao = UserDAO.GetInstance();
        }

        public static UserService GetInstance()
        {
            if (instance == null)
                instance = new UserService();

            return instance;
        }

        public void GetMongoFields()
        {
            dao.GetMongoFields();
        }
        public void AddUser(User_Model user)
        {
            dao.AddUser(user);
        }
    }
}
