using Core.DataAcces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAcces.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //DAL = DATA ACCES PROJEDCT VERİYE ERİŞİM YAPTIĞIMIZ. TEMEL VERİYE ERİŞİM OPERAYONLARI OLUŞTURULUCAK. GÜNCELLEME SİLME VB.

    }

   
}
