using System;
using Core.Entities;

namespace Entities.Dtos
{
    public class ArizaForChart:IDto
    {   
        public int[] VeriInts { get; set; }

        public double[] kaybedilenDakika { get; set; }


    }
}