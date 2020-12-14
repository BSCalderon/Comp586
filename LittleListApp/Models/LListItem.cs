using System;
using System.ComponentModel.DataAnnotations;

namespace LittleListApp.Models
{
    public class LListItem
    {
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        public bool Checked { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }

        public int Quantity { get; set; }

        public string UserId { get; set; }
    }
}