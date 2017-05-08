using System.ComponentModel.DataAnnotations;

namespace DatingSite.Models
{
    public class Profile
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        public int PictureId { get; set; }
        public Picture Picture { get; set; }
    }
}
