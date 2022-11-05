namespace HomelyLibrary.DataAccess
{
    internal class ItemModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { set; get; }
        public string ItemName { set; get; }
        public string Description { set; get; }
        public DateTime DateCreated { set; get; } = DateTime.UtcNow;
        public CategoryModel Category { set; get; }
        public string Author { set; get; }
    }
}
