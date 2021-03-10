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
            public class volume
            {
                public string title { get; set; }
                public string[] authors { get; set; }
                public string publisher { get; set; }
                public string description { get; set; }
                public List<string> industryIdentifiers { get; set; }
                public class industryIdentifier
                {
                    public string type { get; set; }
                    public string identifier { get; set; }
                }
                public List<string> readingModels { get; set; }
                public class readingModel
                {
                    public string text { get; set; }
                    public bool image { get; set; }
                }
                public int pageCount { get; set; }
                public string printType { get; set; }
                public string maturityRating { get; set; }
                public bool allowAnonLogging { get; set; }
                public string contentVersion { get; set; }
                public List<string> panelizationSummary { get; set; }
                public class panelizationS
                {
                    public bool containsEpubBubbles { get; set; }
                    public bool containsImageBubbles { get; set; }
                }
                public List<string> imageLinks { get; set; }
                public class imageLink
                {
                    public string smallThumbnail { get; set; }
                    public string thumbail { get; set; }
                }

            }
        }

    }
}