namespace DTO.Read
{
    public class ExercisefileReadDTO
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public bool ContainsCurrency { get; set; }
        public bool ContainsDate { get; set; }
        public bool ContainsTime { get; set; }
        public bool ContainsGeographical { get; set; }
        public bool ContainsNamesToTranslate { get; set; }

    }
}
