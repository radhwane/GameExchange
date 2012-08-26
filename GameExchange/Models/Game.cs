using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameExchange.Models
{
    public class Game
    {
        // 12 fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string IssueYear { get; set; }
        public string Description { get; set; }
        public string Cover_image { get; set; }
        public string Screen_image1 { get; set; }
        public string Screen_image2 { get; set; }
        public string Screen_image3 { get; set; }
        public string Screen_image4 { get; set; }
        public string Screen_image5 { get; set; }
        public string Video { get; set; }
        public float rating { get; set; }
    }
}