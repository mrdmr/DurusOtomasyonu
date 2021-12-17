using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel, DurusOtomasyonuContext>, IPersonelDal
    {


        public List<Personel> GetPersonelAll()
        {
            using (var context = new DurusOtomasyonuContext())
            {
                var match = context.Personels
                    .ToList();
                return match;
            }
        }
    }
}