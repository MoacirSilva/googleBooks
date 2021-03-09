using System.Collections.Generic;
namespace googleBooksApp
{
    public class Books 
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public List<item> items { get; set; } 

        public class item
        {
            public string kind { get; set; }
            public string id { get; set; }
            public string etag { get; set; }
            public string selfLink { get; set; }
            public List<string> volumeInfo { get; set; }
        } 

        public class volume
        {
            public string title { get; set; }
            
        }

    }
}