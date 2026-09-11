namespace SMAd.Models
{
    public sealed class EntryPreparationResult
    {
        public bool Success { get; set; }
        public bool EndTask { get; set; }
        public string? FirstPageUrl { get; set; }
    }
}
