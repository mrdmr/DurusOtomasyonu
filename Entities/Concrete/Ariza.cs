using System;
using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public partial class Ariza : IEntity
    {
        public int ArizaId { get; set; }
        public int? MakineId { get; set; }
        public int? PersonelId { get; set; }
        public int? ArizaTurId { get; set; }
        public int? ArizaDetayId { get; set; }
        public DateTime? DurusBaslama { get; set; }
        public DateTime? DurusBitis { get; set; }
        public DateTime? TotalTime { get; set; }

        public virtual ArizaDetay ArizaDetay { get; set; }
        public virtual ArizaTur ArizaTur { get; set; }
        public virtual Makine Makine { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
