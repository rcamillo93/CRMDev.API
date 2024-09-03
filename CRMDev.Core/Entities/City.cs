namespace CRMDev.Core.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; private set; }
        public int IdState { get; private set; }
        public State State { get; private set; }
    }
}
