using System.Linq;

namespace TaskManager.Presentation.Repositories
{
    public class UsersRepository : Repository
    {
        public bool Login(string password, string username)
        {
            return ExecuteProcedure<string>("verify_user", new { username, password }).FirstOrDefault() == username;
        }

        //public IEnumerable<EmployeeModel> GetUsers()
        //{
        //    return ExecuteProcedure<EmployeeModel>("get_all_employes");
        //}
    }
}
