﻿using System;
using System.Collections.Generic;

namespace _13.SnsDomain.Models.Circles
{
    public interface ICircleRepository
    {
        public void Save(Circle circle);
        public Circle Find(CircleId id);
        public Circle Find(CircleName name);
        public List<Circle> FindAll();
    }
}
