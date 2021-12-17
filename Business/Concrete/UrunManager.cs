using System.Collections.Generic;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UrunManager:IUrunService
    {
        private IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        public IDataResult<Urun> GetById(int id)
        {
            return new SuccesDataResult<Urun>(_urunDal.Get(p => p.UrunId == id));

        }

        public IDataResult<List<Urun>> GetAll()
        {
            return new SuccesDataResult<List<Urun>>(_urunDal.GetList());

        }

        public IResult Add(Urun urun)
        {
            _urunDal.Add(urun);
            return new SuccessResult(Messages.ArizaAdded);
        }

        public IResult Update(Urun urun)
        {
            _urunDal.Update(urun);
            return new SuccessResult(Messages.ArizaAdded);
        }

        public IResult Delete(Urun urun)
        {
            _urunDal.Delete(urun);
            return new SuccessResult(Messages.ArizaAdded);
        }
    }
}