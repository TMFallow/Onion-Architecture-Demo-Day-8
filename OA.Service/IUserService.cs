using OA.Data;

namespace OA.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Insert(User user);
        void Update(User user);
        void Delete(int id);
        void Remove(User user);
        void SaveChanges();
    }
}