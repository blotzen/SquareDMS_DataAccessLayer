﻿namespace SquareDMS_DataAccessLayer.Entities
{
    public class User : IEntity
    {
        /// <summary>
        /// Constructor for dapper
        /// </summary>
        public User() { }

        /// <summary>
        /// Creates a new user
        /// </summary>
        public User(string lastName, string firstName, string userName,
            byte[] passwordHash, bool active)
        {
            LastName = lastName;
            FirstName = firstName;
            UserName = userName;
            PasswordHash = passwordHash;
            Active = active;
        }

        public int Id { get; private set; }

        public string LastName { get; private set; }

        public string FirstName { get; private set; }

        public string UserName { get; private set; }

        public byte[] PasswordHash { get; private set; }

        public bool Active { get; private set; }
    }
}
