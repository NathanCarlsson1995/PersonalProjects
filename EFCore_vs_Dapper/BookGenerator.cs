using System.Data;
using Bogus;
using Dapper;

namespace EFCore_vs_Dapper
{
    public class BookGenerator
    {
        private readonly IDbConnection _dbConnection;
        private readonly List<long> _ids = new();

        private readonly Faker<Book> _bookGenerator = new Faker<Book>()
            .RuleFor(x => x.Id, x => x.Random.Long())
            .RuleFor(x => x.Title, x => x.Name.JobArea())
            .RuleFor(x => x.Author, x => x.Name.FullName());

        public BookGenerator(IDbConnection dbConnection, Random random)
        {
            Randomizer.Seed = random;
            _dbConnection = dbConnection;
        }

        public async Task GenerateBooks(int count)
        {
            string insertQuery = @"INSERT INTO Books ([Id], [Title], [Author]) VALUES (@Id, @Title, @Author)";
            var generatedBooks = _bookGenerator.Generate(count);
            foreach(var generatedBook in generatedBooks)
            {
                if (!_ids.Contains(generatedBook.Id))
                {
                    await _dbConnection.ExecuteAsync(insertQuery, new { Id = generatedBook.Id, Title = generatedBook.Title, Author = generatedBook.Author });
                    _ids.Add(generatedBook.Id);
                }
            }
        }

        public async Task InsertBook(Book book)
        {
            if (!_ids.Contains(book.Id))
            {
                string insertQuery = @"INSERT INTO Books ([Id], [Title], [Author]) VALUES (@Id, @Title, @Author)";
                await _dbConnection.ExecuteAsync(insertQuery, new { Id = book.Id, Title = book.Title, Author = book.Author });
                _ids.Add(book.Id);
            }
            else throw new Exception("Could not insert test data as the Id already exists.");
        }

        public async Task CleanupBooks()
        {
            string deleteQuery = @"DELETE FROM Books";
            await _dbConnection.ExecuteAsync(deleteQuery);
        }
    }
}
