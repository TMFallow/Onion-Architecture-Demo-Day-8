using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<UserInfo> userInfoRepository;

        public UserService(IRepository<User> userRepository, IRepository<UserInfo> userInfoRepository)
        {
            this.userRepository = userRepository;
            this.userInfoRepository = userInfoRepository;
        }

        public void Delete(int id)
        {
            UserInfo userInfo = userInfoRepository.Get(id);
            userInfoRepository.Remove(userInfo);
            User user = userRepository.Get(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

        public User Get(int id)
        {
            return userRepository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public void Insert(User user)
        {
            userRepository.Insert(user);
        }

        public void Remove(User user)
        {
            userRepository.Remove(user);
        }

        public void SaveChanges()
        {
            userRepository.SaveChanges();
        }

        public void Update(User user)
        {
            userRepository.Update(user);
        }
    }
}
