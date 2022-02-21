namespace InOtherWord.Models
{
    public class Word
    {
        public int Id { get; set; }
        public int DictionaryId { get; set; }
        public string? Name { get; set; }
        public string? Translation { get; set; }
    }
}
