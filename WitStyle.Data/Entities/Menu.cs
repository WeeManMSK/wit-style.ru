using System.Collections.Generic;

namespace WitStyle.Data.Entities
{
    public class Menu
    {
        public Menu()
        {
            MenuItems = new HashSet<MenuItem>();
        }

        public int MenuId { get; set; }
        public string MenuType { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
