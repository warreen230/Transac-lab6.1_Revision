using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PresseMots.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<StoryTag> StoryTags { get; set; }
    }
}
