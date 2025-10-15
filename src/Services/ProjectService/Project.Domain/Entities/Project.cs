using Project.Domain.ValueObjects;
using Project.Domain.Enums;

namespace Project.Domain.Entities
{
    public class Project
    {
        public ProjectTitle Title { get; private set; }
        public ProjectDescription Description { get; private set; }
        public PriceRange Budget { get; private set; }
        public Deadline DueDate { get; private set; }
        public ProjectType TeamOption { get; private set; }
        public List<SkillRequirement> RequiredSkills { get; private set; }

        // Constructor to initialize all required fields
        public Project(
            ProjectTitle title,
            ProjectDescription description,
            PriceRange budget,
            Deadline dueDate,
            ProjectType teamOption,
            IEnumerable<SkillRequirement>? requiredSkills = null)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Budget = budget ?? throw new ArgumentNullException(nameof(budget));
            DueDate = dueDate ?? throw new ArgumentNullException(nameof(dueDate));
            TeamOption = teamOption; // enum, cannot be null
            RequiredSkills = requiredSkills?.ToList() ?? new List<SkillRequirement>();
        }

        // Optional: Add a method to safely add skills
        public void AddSkill(SkillRequirement skill)
        {
            if (skill == null) throw new ArgumentNullException(nameof(skill));
            RequiredSkills.Add(skill);
        }
    }
}
