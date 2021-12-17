using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArizaDal : EfEntityRepositoryBase<Ariza, DurusOtomasyonuContext>, IArizaDal
    {
      
        public List<Ariza> GetArizaForTable()
        {
            using (var context = new DurusOtomasyonuContext())
            {
                var match = context.Arizas

                    .ToList();
                return match;
            }
        }

        public ArizaForChart GetArizaChart()
        {
            int[] veri = new int[24];
            double[] kaybedilenDakika = new double[24];
            using (var context = new DurusOtomasyonuContext())
            {
                var result = context.Arizas.Where(p => p.DurusBaslama >= DateTime.Today).ToList();
                for (int i = 0; i < 24; i++)
                {
                    veri[i] = 0;
                    foreach (var x in result)
                    {

                        if (x.DurusBaslama.Value.Hour == i)
                        {
                            veri[i] += 1;
                            TimeSpan? ts = x.DurusBitis - x.DurusBaslama;
                            kaybedilenDakika[i] += ts.Value.TotalMinutes;
                        }
                    }
                }



            }

            return new ArizaForChart()
            {
                VeriInts = veri
                ,
                kaybedilenDakika = kaybedilenDakika

            };

        }
    }
}