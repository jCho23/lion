using System;
using SQLite;

namespace lion.Models
{
    public class ReplyMessageModel
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string PostMessageId { get; set; }
        public UserProfileModel ReplyUser { get; set; }
        public string ReplyText { get; set; }
    }
}
