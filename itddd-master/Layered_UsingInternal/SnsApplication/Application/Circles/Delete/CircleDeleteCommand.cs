﻿namespace SnsApplication.Application.Circles.Delete
{
    public class CircleDeleteCommand
    {
        public CircleDeleteCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
