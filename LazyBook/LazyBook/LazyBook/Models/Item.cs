using System;


namespace LazyBook
{
    public enum Cat { Business, Cooking, History, Computers, Detective, Thriller, Kids, Politics, Law, Religion, Romance, Science_Fiction, Health }

    public class Item
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Author")]
        public string Author { get; set; }

        [Newtonsoft.Json.JsonProperty("Publisher")]
        public string Publisher { get; set; }

        [Newtonsoft.Json.JsonProperty("Year")]
        public string Year { get; set; }

        [Newtonsoft.Json.JsonProperty("Category")]
        public Cat Category { get; set; }

        [Newtonsoft.Json.JsonProperty("Summary")]
        public string Summary { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }

        public Item() { }

        public Item(string name, string author, string publisher, string year, Cat category, string summary)
        {
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
            this.Year = year;
            this.Category = category;
            this.Summary = summary;
        }
    }
}
