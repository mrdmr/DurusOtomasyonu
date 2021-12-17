using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUretimDal : EfEntityRepositoryBase<Uretim, DurusOtomasyonuContext>, IUretimDal
    {
        public List<UretimForTable> GetUretimForTable()
        {
            using (var context = new DurusOtomasyonuContext())
            {
                var result = context.Uretims.Select(p => new UretimForTable
                {
                    Id = p.UretimId,
                    NormalPeriod = p.NormalPeriod,
                    PeriodFark = p.SabitPeriod - p.NormalPeriod,
                    SabitPeriod = p.SabitPeriod,
                    Verim = Convert.ToString(Math.Round(
                        Convert.ToDecimal((long) (p.SabitPeriod.Value.Ticks - p.NormalPeriod.Value.Ticks)) /
                        p.SabitPeriod.Value.Ticks * 100, 2))
                }).ToList();
                return result;
            }
        }
    }
}