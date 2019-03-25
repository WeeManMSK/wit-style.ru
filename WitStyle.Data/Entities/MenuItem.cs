using System.Collections.Generic;

namespace WitStyle.Data.Entities
{
    public class MenuItem
    {
        public MenuItem()
        {
            Children = new HashSet<MenuItem>();
        }

        public int MenuItemId { get; set; }
        public int MenuId { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int? ParentMenuItemId { get; set; }

        public Menu Menu { get; set; }
        public MenuItem ParentMenuItem { get; set; }
        public ICollection<MenuItem> Children { get; set; }
    }
}
