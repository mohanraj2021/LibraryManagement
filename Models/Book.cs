using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
 
namespace LibraryManagement.Models
{
    public class Book
    {
        public ObjectId Id { get; set; }

        [BsonElement("BookId")]
        public int BookId { get; set; }
        
        [BsonElement("BookName")]
        public string BookName { get; set; }
        
        [BsonElement("Price")]
        public int Price { get; set; }
        
        [BsonElement("Category")]
        public string Category { get; set; }
    }
}