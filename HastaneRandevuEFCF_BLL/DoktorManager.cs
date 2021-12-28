using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuEFCF_DAL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_BLL
{

    public class DoktorManager
    {
        ////Burayı ORM projesindeki static Current nesnesini hatırlamak amacı ile yazdık.
        //private static MyContext _mevcutContext;
        //public static MyContext MevcutContext
        //{
        //    get
        //    {
        //        if (_mevcutContext==null)
        //        {
        //            return new MyContext();
        //        }

        //        return _mevcutContext;
        //    }
        //}

        //GLOBAL ALAN
        MyContext myDBContext = new MyContext();

        public bool YeniDoktorEkle(Doktor yeniDr)
        {
            try
            {
                //1.YÖNTEM
                myDBContext.Doktorlar.Add(yeniDr);

                //2.YÖNTEM
                //---->>> Bu yöntemi ilerleyen derslerde Repository design pattern konusunda yani MVC'de kullanacağız.
                // myDBContext.Set<Doktor>().Add(yeniDr);

                myDBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Doktor> TumAktifDoktorlariGetir() 
        {
            try
            {
                //1.YÖNTEM      ------>>> uzun. Fazladan bir doktor listesi oluşturmuş olduk bunun yerine 2. Yöntemi kullanabiliriz.
                //List<Doktor> drList = new List<Doktor>();
                //drList = myDBContext.Doktorlar.ToList();
                //return drList;

                //2.YÖNTEM
                //Where ile sadece aktifler çekilecek.
                //Bunu daha sonra yapacağız.
                return myDBContext.Doktorlar.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }
        public List<Doktor> BransaGoreDoktorlariGetir(Branslar brans)
        {
            try
            {
                return myDBContext.Doktorlar.Where(x => x.Brans == brans).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
