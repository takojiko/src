﻿namespace _07.SnsDomain.Models.Users
{
    public interface IUserFactory
    {
        User Create(UserName name);
    }

}
