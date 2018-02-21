using System;
using System.Collections.Generic;
using lion.Models;

namespace lion.FakeService
{
    public static class FakeFeedService
    {
        public static List<PostMessage> GetPostMessages()
        {
            return new List<PostMessage>
            {
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    Status= "8 replies" }
            };
        }
    }
}
