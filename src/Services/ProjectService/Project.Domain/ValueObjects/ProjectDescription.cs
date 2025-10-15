using System;

namespace Project.Domain.ValueObjects
{
    public sealed class ProjectDescription
    {
        public string Value { get; }

        public ProjectDescription(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Project description cannot be empty.");

            if (value.Length > 1000)
                throw new ArgumentException("Project description cannot exceed 1000 characters.");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is ProjectDescription other && Value == other.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
