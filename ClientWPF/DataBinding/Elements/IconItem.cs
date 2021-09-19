namespace ClientWPF.DataBinding.Elements
{
    public enum Icons
    {
        Access,
        Word,
        Powerpoint,
        Excel,
        Onenote,
        Teams
    }
    public class IconItem
    {
        private string iconPath;
        public Icons IconName { get; set; }
        public string IconPath
        {
            get
            {
                return iconPath;
            }
            set
            {
                iconPath = $"../Icons/{value.ToLower()}.png";
                IconToSend = value;
            }
        }
        public string IconToSend { get; set; }
    }
}
