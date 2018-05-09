using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using LibraryManagement.Models;

namespace LibraryManagement.Repositories
{
    public class BooksRepository
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
 
        public BooksRepository()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("LibraryDB");      
        }
 
        public IEnumerable<Book> GetBooks()
        {
            return _db.GetCollection<Book>("Books").FindAll();
        }
 
        public Book GetBook(ObjectId id)
        {
            var res = Query<Book>.EQ(p => p.Id, id);
            return _db.GetCollection<Book>("Books").FindOne(res);
        }
 
        public Book Create(Book book)
        {
            _db.GetCollection<Book>("Books").Save(book);
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