using System;
using System.ComponentModel.DataAnnotations;

namespace DatingSite.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public int MessageStatusCode { get; set; }
        [Required]
        public string MessageFromUserId { get; set; }
        public string MessageFromUser { get; set; }
        [Required]
        public string MessageToUserId { get; set; }
        public string MessageToUser { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime DateSent { get; set; }
    }
}
