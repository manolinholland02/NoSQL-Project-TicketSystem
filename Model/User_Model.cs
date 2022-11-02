using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
        public Role Role { get; set; }

        [BsonElement("location")]
        public string Location { get; set; }

        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; }

        public User_Model(string firstName, string lastName, string email, string password, Role role, string location, string phoneNumber)
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
