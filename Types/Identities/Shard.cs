public class Shard : IEquatable<Shard>
{
    public int id { get; set; }
    public Shard(int id)
    {
        this.id = id;
    }

    public bool Equals(Shard? other)
    {
        if (other is null)
            return false;
        return other.id == id;
    }
}