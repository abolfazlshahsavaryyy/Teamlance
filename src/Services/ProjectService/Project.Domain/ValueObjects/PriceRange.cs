using System;

namespace Project.Domain.ValueObjects
{
    public sealed class PriceRange
    {
        public decimal Min { get; }
        public decimal Max { get; }

        public PriceRange(decimal min, decimal max)
        {
            if (min < 0 || max < 0)
                throw new ArgumentException("Price cannot be negative.");

            if (min > max)
                throw new ArgumentException("Minimum price cannot exceed maximum price.");

            Min = min;
            Max = max;
        }

        public override bool Equals(object obj)
        {
            return obj is PriceRange other && Min == other.Min && Max == other.Max;
        }

        public override int GetHashCode() => HashCode.Combine(Min, Max);
    }
}
