namespace GameLibrary.Models
{
    public class PublisherModelBoardGameModel
    {
        public int BoardGameId { get; set; }
        public int PublisherID { get; set; }

        public virtual PublisherModel Publisher { get; set; }
        public virtual BoardGameModel BoardGame { get; set; }
    }
}
