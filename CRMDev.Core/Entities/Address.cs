namespace CRMDev.Core.Entities
{
    public class Address : BaseEntity
    {
        public string PublicPlace { get; private set; }
        public int IdCity { get; private set; }
        public string CEP { get; private set; }
    }
}
