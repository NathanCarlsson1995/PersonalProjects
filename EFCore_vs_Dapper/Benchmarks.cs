using BenchmarkDotNet.Attributes;
using Dapper;
using EFCore_vs_Dapper.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_vs_Dapper
{
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private BooksContext _booksContext = null;
        private IDbConnection _dbConnection = null;
        private Random _random = new Random();
        private Book _testBook = null;
        private BookGenerator _bookGenerator = null;

        [GlobalSetup]
        public async Task Setup()
        {
            _random = new Random();
            var dbConnectionFactory = new SqliteConnectionFactory(@"Data Source=C:\Code\PersonalProjects\EFCore_vs_Dapper\books.db");
            _dbConnection = await dbConnectionFactory.CreateConnectionAsync();

            _bookGenerator = new BookGenerator(_dbConnection, _random);

            await _bookGenerator.GenerateBooks(25);

            _testBook = new Book
            {
                Id = 12345,
                Title = "test",
                Author = "test author"
            };

            await _bookGenerator.InsertBook(_testBook);

            _booksContext = new();
        }

        [GlobalCleanup]
        public async Task Cleanup()
        {
            await _bookGenerator.CleanupBooks();
        }


        [Benchmark]
        public async Task<Book?> EF_Find()
        {
            return await _booksContext.Books.FindAsync(_testBook.Id);
        }

        [Benchmark]
        public async Task<Book?> EF_Single()
        {
            return await _booksContext.Books.SingleOrDefaultAsync(x => x.Id == _testBook.Id);
        }

        [Benchmark]
        public async Task<Book?> EF_First()
        {
            return await _booksContext.Books.FirstOrDefaultAsync(x => x.Id == _testBook.Id);
        }

        [Benchmark]
        public async Task<Book> Dapper_GetById()
        {
            return await _dbConnection.QuerySingleOrDefaultAsync<Book>(@"SELECT * FROM Books WHERE Id=@Id LIMIT 1", new { _testBook.Id });
        }
    }
}
