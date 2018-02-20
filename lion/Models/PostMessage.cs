using System;
using SQLite;

namespace lion.Models
{
    public class PostMessage
    {
        [PrimaryKey, AutoIncrement]
        public string Post { get; set; }

        public string UserUrl { get; set; }
        public string Status { get; set; }
    }
}