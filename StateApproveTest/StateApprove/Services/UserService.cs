using Microsoft.EntityFrameworkCore;
using StateApprove.Data;

namespace StateApprove.Services
{
    public class UserService
    {
        private readonly MyContext _dbContext;

        private List<User>? _users;

        public UserService(MyContext dbContext)
        {
            _dbContext = dbContext;

        }

        public IEnumerable<User> GetUsers()
        {
            return GetUsersInternal();
        }

        private IEnumerable<User> GetUsersInternal()
        {
            if (_users == null)
            {
                _users = _dbContext.Users.Include(x => x.Stage).ToList();
            }

            return _users;
        }


        public void CreateUser(User user,Stage stage)
        {
            user.Name = "UserTest";

            user.StageId = stage.Id;

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            _users?.Add(user);

            

        }


        public void UpdateUser(User user)
        {
            var target = _users?.FirstOrDefault(p => p.Id == user.Id);
            if (target != null)
            {
                target.Name = user.Name;
                target.Amount = user.Amount;
                target.StageId = user.StageId;
            }

            _dbContext.SaveChanges();
        }


        public void DeleteUser(User user)
        {
            var target = _users?.FirstOrDefault(p => p.Id == user.Id);
            if (target != null)
            {
                _users?.Remove(target);
                _dbContext.Users.Remove(target);

            }

            _dbContext.SaveChanges();

        }
    }

}
