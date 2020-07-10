using SQLite;
using System;

namespace XamarinDataAccess.Models
{
    public class NoteSqlModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
