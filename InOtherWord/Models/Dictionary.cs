namespace InOtherWord.Models
{
    public class Dictionary
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Summary { get; set; }
        public string? ImgUrl { get; set; }
    }
}
