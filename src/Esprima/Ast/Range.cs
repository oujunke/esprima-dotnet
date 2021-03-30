using System;
using System.Globalization;

namespace Esprima.Ast
{
    public readonly struct Range : IEquatable<Range>
    {
        public readonly int Start;
        public readonly int End;
        public readonly string? Source;

        public Range(int start, int end,string? source)
        {
            Start = start;
            End = end;
            Source = source;
        }

        public bool Equals(Range other) =>
            Start == other.Start && End == other.End;

        public override bool Equals(object obj) =>
            obj is Range other && Equals(other);

        public override int GetHashCode() =>
            unchecked((Start * 397) ^ End);

        public override string ToString() =>
            string.Format(CultureInfo.InvariantCulture, "[{0}..{1}:{2})", Start, End,Source);

        public static bool operator ==(Range left, Range right) => left.Equals(right);
        public static bool operator !=(Range left, Range right) => !left.Equals(right);
    }
}