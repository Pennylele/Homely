namespace HomelyLibrary.DataAccess;
internal class UserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string ObjectIdentifier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { set; get; }
    public List<ItemModel> AuthoredItems { set; get; } = new();
}
