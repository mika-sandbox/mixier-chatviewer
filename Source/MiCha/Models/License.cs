namespace MiCha.Models
{
    public class License
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string[] Authors { get; set; } = new string[0];
    }
}