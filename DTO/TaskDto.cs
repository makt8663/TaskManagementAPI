using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.DTOs
{
    public class TaskDto
    {
        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }
    }
}