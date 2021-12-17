using System.Collections.Generic;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PersonelManager:IPersonelService
    {
        private IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IDataResult<Personel> GetById(int id)
        {
            return new SuccesDataResult<Personel>(_personelDal.Get(p=>p.PersonelId==id));
        }

        public IDataResult<List<Personel>> GetAll()
        {
            return new SuccesDataResult<List<Personel>>(_personelDal.GetPersonelAll());
        }


        public IResult Add(Personel personel)
        {
            _personelDal.Add(personel);
            return new SuccessResult(Messages.PersonelAdded);
        }

        public IResult Update(Personel personel)
        {
            _personelDal.Update(personel);
            return new SuccessResult(Messages.PersonelUpdated);
        }

        public IResult Delete(Personel personel)
        {
            _personelDal.Delete(personel);
            return new SuccessResult(Messages.PersonelDeleted);
        }
    }
}