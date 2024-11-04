using System.Collections.Generic;

namespace JaredResumeApp.Models
{
    public class Skill
    {
        required public string Name { get; set; }
        required public string Description { get; set; }
        public string? GitHubLink { get; set; }
    }
}