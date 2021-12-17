using System;
using Core.Entities;

#nullable disable

namespace Entities.Concrete
{
    public partial class Uretim:IEntity
    {
        public int UretimId { get; set; }
        public int? PersonelId { get; set; }
        public int? UrunId { get; set; }
        public TimeSpan? SabitPeriod { get; set; }
        public TimeSpan? NormalPeriod { get; set; }
        public TimeSpan? PeriodFark { get; set; }
        public decimal? Verim { get; set; }
    }
}
