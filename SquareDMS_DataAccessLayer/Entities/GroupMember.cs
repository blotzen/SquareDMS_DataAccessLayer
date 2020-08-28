namespace SquareDMS_DataAccessLayer.Entities
{
    /// <summary>
    /// Users are members in groups. This entity links them.
    /// </summary>
    public class GroupMember : IEntity
    {
        /// <summary>
        /// Default constructor for dapper
        /// </summary>
        public GroupMember() { }

        /// <summary>
        /// Creates a new GroupMember
        /// </summary>
        public GroupMember(int groupId, int userId)
        {
            GroupId = groupId;
            UserId = userId;
        }

        public int GroupId { get; }

        public int UserId { get; }
    }
}