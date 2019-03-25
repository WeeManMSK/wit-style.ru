namespace WitStyle.Common.Dto
{
    public class MenuItemDto
    {
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public MenuItemDto[] Children { get; set; }
    }
}
