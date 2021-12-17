using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMakineDal : EfEntityRepositoryBase<Makine, DurusOtomasyonuContext>, IMakineDal
    {
        
    }
}