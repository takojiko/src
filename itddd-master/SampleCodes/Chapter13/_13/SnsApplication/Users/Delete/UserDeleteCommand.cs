﻿namespace _13.SnsApplication.Users.Delete
{
    public class UserDeleteCommand
    {
        public UserDeleteCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
