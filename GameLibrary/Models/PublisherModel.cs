namespace GameLibrary.Models
{
    public class PublisherModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<BoardGameModel> Boards { get; set; }
    }
}
