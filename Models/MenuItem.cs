namespace WitStyle.Web.Models 
{
    public class MenuItem {
        public string DisplayName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public MenuItem(string displayName, string controller, string action)
        {
            this.DisplayName = displayName;
            this.Controller = controller;
            this.Action = action;
        }
    }
}