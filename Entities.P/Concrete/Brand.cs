using Core.Entities;

namespace Entities.P.Concrete
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
