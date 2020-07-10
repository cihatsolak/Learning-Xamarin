using SQLite;
using System;

namespace AcikAkadamiHaftaDort.Models
{
    public class Log
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
