using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public partial class Urun : IEntity
    {
        public int UrunId { get; set; }
        public string Ad { get; set; }
    }
}
