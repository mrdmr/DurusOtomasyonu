using System;
using Core.Entities;

namespace Entities.Dtos
{
    public class UretimForTable:IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserClaim { get; set; }
        public string UrunName { get; set; }
        public TimeSpan? SabitPeriod { get; set; }
        public TimeSpan? NormalPeriod { get; set; }
        public TimeSpan? PeriodFark { get; set; }
        public string? Verim { get; set; }
    }
}