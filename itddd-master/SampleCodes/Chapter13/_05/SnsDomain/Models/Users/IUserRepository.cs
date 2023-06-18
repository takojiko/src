﻿using System.Collections.Generic;

namespace _05.SnsDomain.Models.Users
{
    public interface IUserRepository
    {
        User Find(UserId id);
        User Find(UserName name);
        List<User> FindAll();
        void Save(User user);
        void Delete(User user);
        List<User> Find(List<UserId> circleMembers);
    }
}
