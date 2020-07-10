using System;

namespace XamarinDataAccess.Models
{
    public class Note
    {
        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
