public sealed class RequestText
{
    public string Value { get; }

    private RequestText(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Request text cannot be empty.");
        Value = value.Trim();
    }

    public static RequestText Create(string value) => new RequestText(value);
    public override string ToString() => Value;
}
