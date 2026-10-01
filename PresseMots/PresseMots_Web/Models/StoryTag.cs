using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PresseMots.Models
{
    public class StoryTag
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Tag")]
        public int TagId { get; set; }
        [ForeignKey("Story")]
        public int StoryId { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual Story Story { get; set; }
    }
}
