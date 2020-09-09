﻿namespace SquareDMS_DataAccessLayer.Entities
{
    /// <summary>
    /// The Right a Group has on a Document.
    /// </summary>
    public class Right : IEntity
    {
        /// <summary>
        /// Constructor for dapper
        /// </summary>
        public Right() { }

        /// <summary>
        /// Creates a right with a given access level.
        /// </summary>
        /// <param name="groupId">Id of group</param>
        /// <param name="docId">Id of document</param>
        /// <param name="accessLevel">100 := read, 200 := read&update, 
        /// 300 := read&update&discard</param>
        public Right(int groupId, int docId, AccessLevel accessLevel)
        {
            GroupId = groupId;
            DocumentId = docId;
            AccessLevel = accessLevel;
        }

        public int GroupId { get; private set; }

        public int DocumentId { get; private set; }

        public AccessLevel AccessLevel { get; private set; }
    }

    /// <summary>
    /// Different possible access Levels.
    /// </summary>
    public enum AccessLevel
    {
        Read = 100,
        Update = 200,
        Discard = 300
    }
}
