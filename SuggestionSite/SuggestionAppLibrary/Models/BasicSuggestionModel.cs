namespace SuggestionAppLibrary.Models;

/// <summary>
/// This is a sub-object of SuggestionModel. 
/// We do not have [BsonId] as this could be duplicated
/// This will be a sub-object of UserModel
/// </summary>
public class BasicSuggestionModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Suggestion { get; set; }

    public BasicSuggestionModel()
    {

    }

    public BasicSuggestionModel(SuggestionModel suggestion)
    {
        Id = suggestion.Id;
        Suggestion = suggestion.Suggestion;
    }
}
