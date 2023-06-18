﻿using System;

namespace _45
{
    class Program
    {
        void CreateUser(string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (name.Length < 3) throw new ArgumentException("ユーザ名は3文字以上です。", nameof(name));

            var user = new User(name);

            // ...
        }

        void UpdateUser(string id, string name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (name.Length < 3) throw new ArgumentException("ユーザ名は3文字以上です。", nameof(name));
            
            // ...
        }
    }
}
