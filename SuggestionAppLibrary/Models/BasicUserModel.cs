namespace SuggestionAppLibrary.Models;

// Since we're in NoSQL, we duplicate the minimal data we need for getting all data when reading the 
// single record. 
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