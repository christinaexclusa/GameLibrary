﻿using System.ComponentModel.DataAnnotations;

namespace GameLibrary.Models
{
    public class BoardGameModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }

        public string ImageURL { get; set; }
    }
}
