using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.P.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
