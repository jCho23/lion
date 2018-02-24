using System;
using SQLite;

namespace lion.Models
{
    public class PostMessageModel
    {
        [PrimaryKey]
        public string Id { get; set; }

        public UserProfileModel PostUser { get; set; }
        public string PostText { get; set; }
        public int NumberOfLikes { get; set; }
        public int NumberOfReplies { get; set; }
    }
}