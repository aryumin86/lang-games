namespace CrosswordsWA.Models.Crossword
{
    public class CharCell
    {
        public char? RealLetter { get; set; }
        public char? UserLetter { get; set; }
        public bool ContainsLetter { get; set; } = false;
        public bool ShowLetter { get; set; } = false;
        public bool? IsCorrect { get; set; }
        public bool WordStart { get; set; } = false;
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int? WordNumberInList { get; set; }
    }
}
