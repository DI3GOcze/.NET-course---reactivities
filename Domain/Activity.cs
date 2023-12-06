namespace Domain
{
    public class Activity
    {
        // Entity framework recognizes Id as primary key... It HAS to be named Id 
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}