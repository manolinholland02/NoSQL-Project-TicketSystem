using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Role { Employee, ServiceDeskEmployee}
    public class User_Model
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public int id { get; set; }


        [BsonElement("firstName")]
        public string firstName { get; set; }

        [BsonElement("lastName")]
        public string lastName { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("password")]
        public string password { get; set; }

        [BsonElement("role")]
        public Role role { get; set; }

        [BsonElement("location")]
        public string location { get; set; }

        [BsonElement("phoneNumber")]
        public string phoneNumber { get; set; }
    }
}
