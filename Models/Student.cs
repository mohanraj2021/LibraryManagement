using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
 
namespace LibraryManagement.Models
{
    public class Student
    {
        public ObjectId Id { get; set; }

        [BsonElement("StudentId")]
        public int StudentId { get; set; }
        
        [BsonElement("StudentName")]
        public string StudentName { get; set; }
        
        [BsonElement("PhnNo")]
        public int PhnNo { get; set; }
        
       
    }
}