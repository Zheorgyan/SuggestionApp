namespace SuggestionAppLibrary.Models;
public class SuggestionModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Suggestion { get; set; }
    public string Discription { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public CategoryModel Category { get; set; }
    public StatusModel SuggestionStatus { get; set; }
    public BasicUserModel Author { get; set; }
    public HashSet<string> UserVotes { get; set; } = new();
    public string OwnerNotes { get; set; }
    public bool ApprovedForRelease { get; set; }
    public bool Archived { get; set; }
    public bool Rejected { get; set; }
}
