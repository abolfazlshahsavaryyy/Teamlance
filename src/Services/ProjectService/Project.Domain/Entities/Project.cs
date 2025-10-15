using Project.Domain.ValueObjects;
using Project.Domain.Enums;
namespace Project.Domain.Entities;
public class Project
{
    public ProjectTitle Title { get; private set; }
    public ProjectDescription Description { get; private set; }
    public PriceRange Budget { get; private set; }
    public Deadline DueDate { get; private set; }
    public ProjectType TeamOption { get; private set; }
    public List<SkillRequirement> RequiredSkills { get; private set; }

}
