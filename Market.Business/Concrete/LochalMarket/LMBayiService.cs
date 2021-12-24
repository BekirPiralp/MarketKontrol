using Market.Business.Abstract.LochalMarket;
using Market.DataAccess.Abstract;
using Market.Entity.Concrete;
using Market.Restriction.Utilities;
using Market.Restriction.ValidationRules.FluentValidation.LochalMarket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business.Concrete.LochalMarket
{
    public class LMBayiService : ILMBayiService
    {
        private IBayiDal _bayiDal;
        private Firma _firma;

        public LMBayiService(IBayiDal bayiDal,Firma firma)
        {
            _firma = firma;
            _bayiDal = bayiDal;
        }

        public void Add(Bayi entity)
        {
            ValidationTool.Validate<LMBayiValidator>(entity);
            _bayiDal.Add(entity);
        }

        public void AddByList(List<Bayi> bayiler)
        {
            Bayi bayi;
            for (int i = 0; i < bayiler.Count; i++)
            {
                bayi = bayiler[i];
                ValidationTool.Validate<LMBayiValidator>(bayi);
                _bayiDal.Add(bayi);
            }
        }

        public void Delete(Bayi bayi)
        {
            try
            {
                ValidationTool.Validate<LMBayiValidator>(bayi);
                _bayiDal.Delete(bayi);
            }
            catch 
            {
                throw new Exception("Silme İşlemi gerçekleşmedi!");
            }
            
        }

        public void DeleteById(int Id)
        {
            try
            {
                _bayiDal.Delete(GetById(Id));
            }
            catch
            {
                throw new Exception("Silme İşlemi gerçekleşmedi!");
            }
           
        }

        public List<Bayi> GetAll()
        {
            List<Bayi> bayiler;
            bayiler = this._bayiDal.GetAll();
            if (bayiler.Count == 0)
                throw new Exception("Sistemde kayıtlı bayi bulunamadı!");
            return bayiler;
        }

        public Bayi GetById(int Id)
        {
            Bayi result = _bayiDal.Get(p => p.Id == Id);
            if (result is null)
                throw new Exception(message: "Aradığınız şekilde bir bayi yoktur");
            else
                return result; 
        }

       
        public void Update(Bayi bayi)
        {
            ValidationTool.Validate<LMBayiValidator>(bayi);
            _bayiDal.Update(bayi);
        }
    }
}
