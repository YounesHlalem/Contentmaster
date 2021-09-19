namespace DTO.Read
{
    public class DidacticalModelLevelReadDTO
	{
        public int Id { get; set; }
        public int DidacticalModelId { get; set; }
        public virtual DidacticalModelReadDTO DidacticalModel { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    }
}