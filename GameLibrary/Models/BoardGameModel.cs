using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Models
{
    public class BoardGameModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Publisher
        {
            get
            {
                if (Publishers is not null)
                {
                    return Publishers.Name;
                }
                else
                {
                    return "";
                }
            }
        }

        // The publisher id has to match the Table column 
        // in this case the Table column name is PublishersId
        // public DbSet<PublisherModel> Publishers { get; set; } the Table Name is Publisher
        // and the Key in that table is Id, thus the ForignKey has to be PublishersId
        [ForeignKey("PublisherModel")]
        public int PublishersId { get; set; }
        public virtual PublisherModel? Publishers { get; set; }
        public string ImageURL { get; set; }
    }
}