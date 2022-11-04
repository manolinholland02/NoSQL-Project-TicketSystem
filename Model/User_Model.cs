using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Model
{
    public class User_Model
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("role")]
        [JsonConverter(typeof(StringEnumConverter))]  
        [BsonRepresentation(BsonType.String)]         
        public Role Role { get; set; }

        [BsonElement("location")]
        [JsonConverter(typeof(StringEnumConverter))]  
        [BsonRepresentation(BsonType.String)]        
        public Location Location { get; set; }

        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; }

        public User_Model(string firstName, string lastName, string email, string password, Role role, Location location, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Role = role;
            Location = location;
            PhoneNumber = phoneNumber;
        }
    }
}
