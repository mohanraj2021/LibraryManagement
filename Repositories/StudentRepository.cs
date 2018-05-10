using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using LibraryManagement.Models;

namespace LibraryManagement.Repositories
{
    public class StudentRepository
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;

        public StudentRepository()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("LibraryDB");
        }

        public IEnumerable<Student> GetStudent()
        {
            return _db.GetCollection<Student>("Books").FindAll();
        }

        public Student GetBook(ObjectId id)
        {
            var res = Query<Student>.EQ(p => p.Id, id);
            return _db.GetCollection<Student>("Books").FindOne(res);
        }

        public Student Create(Student book)
        {
            _db.GetCollection<Student>("Books").Save(book);
            return book;
        }

        // public void Update(ObjectId id,Product p)
        // {
        //     p.Id = id;
        //     var res = Query<Product>.EQ(pd => pd.Id,id);
        //     var operation = Update<Product>.Replace(p);
        //     _db.GetCollection<Product>("Products").Update(res,operation);
        // }

        // public void Remove(ObjectId id)
        // {
        //     var res = Query<Product>.EQ(e => e.Id, id);
        //     var operation = _db.GetCollection<Product>("Products").Remove(res);
        // }
    }
}