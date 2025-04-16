namespace Animal.Models;

public abstract class Animal : IComparable<Animal>
{
    protected string nom { get; set; }
    public int age { get; set; }

    public override string ToString()
    {
        return $"{nom} à {age} ans";
    }

    public abstract string EmettreSon();

    public int CompareTo(Animal? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        return age.CompareTo(other.age);
    }
}