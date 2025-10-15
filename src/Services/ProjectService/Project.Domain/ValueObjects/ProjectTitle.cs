using System;

namespace Project.Domain.ValueObjects
{
    public sealed class ProjectTitle
    {
        public string Value { get; }

        public ProjectTitle(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Project title cannot be empty.");

            if (value.Length > 100)
                throw new ArgumentException("Project title cannot exceed 100 characters.");

            Value = value;
        }

        // Equality override for ValueObject
        public override bool Equals(object obj)
        {
            return obj is ProjectTitle other && Value == other.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
