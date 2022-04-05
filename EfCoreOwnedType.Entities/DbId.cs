namespace EFCoreOwnedType.Entities;

using System;

public class DbId : IEquatable<DbId>
{
    public const int MAX_LENGTH = 22;

    public static DbId Empty => new(Guid.Empty);

    public string Value { get; }
    public Guid Guid { get; }

    /// <summary>
    /// Generates a new unique DbId. If you meant to create an empty DbId use DbId.Empty instead.
    /// </summary>
    public DbId() : this(Guid.NewGuid()) { }

    public DbId(string value)
    {
        Value = value;
        Guid = Parse(value);
    }

    public DbId(Guid guid)
    {
        Guid = guid;
        Value = Parse(guid);
    }

    public static explicit operator string(DbId guid)
    {
        return guid.Value;
    }

    public static explicit operator Guid(DbId guid)
    {
        return guid.Guid;
    }

    public static explicit operator DbId(string value)
    {
        return new DbId(value);
    }

    public static explicit operator DbId(Guid guid)
    {
        return new DbId(guid);
    }

    private static string Parse(Guid guid)
    {
        var base64 = Convert.ToBase64String(guid.ToByteArray());
        return base64[..^2].Replace("/", "_").Replace("+", "-");
    }

    private static Guid Parse(string value)
    {
        if (value.Length != MAX_LENGTH)
        {
            throw new ArgumentException($"{value} is not a valid DbId!", nameof(value));
        }

        var base64 = $"{value.Replace("_", "/").Replace("-", "+")}==";
        return new Guid(Convert.FromBase64String(base64));
    }

    public override string ToString()
    {
        return Value;
    }

    public bool Equals(DbId guid)
    {
        return guid != null
            && guid.Value == Value;
    }

    public bool Equals(string guid)
    {
        return !string.IsNullOrEmpty(guid)
            && guid == Value;
    }

    public override bool Equals(object obj)
    {
        return obj is DbId dbId
            && dbId.Guid.Equals(Guid);
    }

    public override int GetHashCode()
    {
        return Guid.GetHashCode();
    }

    public static bool operator ==(DbId guid1, DbId guid2)
    {
        if (guid1 is null || guid2 is null)
        {
            return Equals(guid1, guid2);
        }

        return guid1.Equals(guid2);
    }

    public static bool operator !=(DbId guid1, DbId guid2)
    {
        if (guid1 is null || guid2 is null)
        {
            return !Equals(guid1, guid2);
        }

        return !guid1.Equals(guid2);
    }
}
