namespace SuggestionAppLibrary.Models;

public class SuggestionModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Suggestion { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public CategoryModel Category { get; set; }
    public string Author { get; set; }
    public HashSet<string> UserVotes { get; set; } = new();
    public StatusModel SuggestStatus { get; set; }
    public string OwnerNotes { get; set; }
    // Whether or not this suggestion has been approved by an admin. For example, if the suggestion violates community guidelines
    public bool ApprovedForRelease { get; set; } = false;
    public bool Archived { get; set; } = false;
    public bool Rejected { get; set; } = false;
}
