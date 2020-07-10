using System;

namespace AcikAkademiApp.Models
{
    public class Conference
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
