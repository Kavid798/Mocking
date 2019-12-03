using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Mocking.Mocking
{
    public class MovieService
    {
        public string ReadVideoTitle(IFileReader fileReader)
        {
            var str = fileReader.ReadFile(@"D:\Video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error passing the video.";
            return video.Title;
        }
    }
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }

    }
}