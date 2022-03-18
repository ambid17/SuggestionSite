namespace SuggestionAppLibrary.Models;

/// <summary>
/// This is a sub-object of the UserModel
/// This is so that when loading a suggestion, we can get the author of the suggestion, without loading all of the data about a user
/// </summary>
public class BasicUserModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string DisplayName { get; set; }

    public BasicUserModel()
    {

    }

    public BasicUserModel(UserModel user)
    {
        Id = user.Id;
        DisplayName = user.DisplayName;
    }
}
