using System;
using System.Collections.Generic;
using System.Text;

namespace Course.MenuYapisi.Models
{
    public class TableMenuItem
    {
        public string Title { get; set; }
        public List<MenuItem> Items { get; set; }
    }

    public class MenuItem
    {
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
    }
}
