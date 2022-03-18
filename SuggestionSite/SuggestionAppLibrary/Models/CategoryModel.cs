namespace SuggestionAppLibrary.Models;
public class CategoryModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string CategoryName { get; set; }
    public int CategoryDescription { get; set; }
}
