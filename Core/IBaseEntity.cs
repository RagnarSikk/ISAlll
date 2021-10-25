namespace isa3.Core
{
    public interface IBaseEntity
    {
        public string Id { get; }
        public byte[] RowVersion { get; }
    }
}