using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinDataAccess.Models;

namespace XamarinDataAccess.SqlLiteDatabase
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public NoteDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<NoteSqlModel>().Wait(); // Wait ile tablonun oluşturulmasını bekliyoruz.
        }

        public Task<List<NoteSqlModel>> GetNotesAsync()
        {
            return _database.Table<NoteSqlModel>().ToListAsync();
        }

        public Task<int> SaveNoteAsync(NoteSqlModel noteSqlModel)
        {
            if (noteSqlModel.Id != 0)
                return _database.UpdateAsync(noteSqlModel);
            
            return _database.InsertAsync(noteSqlModel);
        }

        public Task<int> DeleteNoteAsync(NoteSqlModel noteSqlModel)
        {
            return _database.DeleteAsync(noteSqlModel);
        }
    }
}
