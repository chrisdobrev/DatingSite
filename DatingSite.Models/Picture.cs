using System;
using System.ComponentModel.DataAnnotations;

namespace DatingSite.Models
{
    public class Picture
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        public string PictureTitle { get; set; }
        public string PictureFileName { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime LastChange { get; set; }
        public string ProfileDetails { get; set; }
    }
}
