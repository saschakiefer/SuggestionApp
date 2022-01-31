using System.Globalization;
using System.Security.AccessControl;

namespace SuggestionAppLibrary.Models;

// Since we're in NoSQL, we duplicate the minimal data we need for getting all data when reading the 
// single record. 
public class BasicSuggestionModel
{
    [BsonRepresentation(BsonType.ObjectId)] // Not be stored in an own collection, but as a sub object ==> No ID
    public string Id { get; set; }
    public string Suggestion { get; set; }

    public BasicSuggestionModel()
    {
        // Needed to keep the implicit constructure after another implicit one is created
    }

    public BasicSuggestionModel(SuggestionModel suggestion)
    {
        Id = suggestion.Id;
        Suggestion = suggestion.Suggestion;
    }
}