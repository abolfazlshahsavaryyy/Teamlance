using Project.Domain.Enums;
using System;

namespace Project.Domain.ValueObjects
{
    public sealed class SkillRequirement
    {
        public string Name { get; }
        public SkillLevel Level { get; }

        public SkillRequirement(string name, SkillLevel level)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Skill name cannot be empty.");

            Name = name;
            Level = level;
        }

        public override bool Equals(object obj)
        {
            return obj is SkillRequirement other && Name == other.Name && Level == other.Level;
        }

        public override int GetHashCode() => HashCode.Combine(Name, Level);
    }
}
