using System;

namespace Project.Domain.ValueObjects
{
    public sealed class Deadline
    {
        public DateTime Value { get; }

        public Deadline(DateTime value)
        {
            if (value < DateTime.UtcNow)
                throw new ArgumentException("Deadline cannot be in the past.");

            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Deadline other && Value == other.Value;
        }

        public override int GetHashCode() => Value.GetHashCode();
    }
}
