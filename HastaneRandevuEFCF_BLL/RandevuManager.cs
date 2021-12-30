using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuEFCF_DAL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_BLL
{
    public class RandevuManager
    {
        //GLOBAL ALAN
        MyContext myDBContext = new MyContext();

        public List<RandevuBilgileri> DoktorunRandevulariniTariheGoreGetir(Doktor dr, DateTime trh)
        {
            try
            {
                List<RandevuBilgileri> rndList = new List<RandevuBilgileri>();

                rndList = myDBContext.RandevuBilgileri.Where(x => x.DoktorId == dr.DoktorId).ToList();

                //Burada foreach kullanmamamızın sebebi foreach döngüsünde koleksiyonun bozulamamasıdır. Oysa biz burada tarihi eşleşmeyen randevuları listemizden sileceğiz...
                for (int i = 0; i < rndList.Count; i++)
                {
                    if (rndList[i].RandevuTarihi.ToShortDateString() != trh.ToShortDateString())
                    {
                        rndList.Remove(rndList[i]);
                    }
                }


                return rndList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool HastaninSecilenTarihveSaatteRandevusuVarMi(Hasta hasta, DateTime trh)
        {
            try
            {
                bool sonuc = false;
                var liste = myDBContext.RandevuBilgileri.Where(x => x.HastaId == hasta.HastaId
                && x.RandevuTarihi == trh).ToList();

                sonuc = liste.Count > 0 ? true : false;

                return sonuc;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool RandevuyuAl(RandevuBilgileri rnd)
        {
            try
            {
                myDBContext.RandevuBilgileri.Add(rnd);
                if (myDBContext.SaveChanges() > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public RandevuBilgileriViewModel RandevuyuViewModeleAktar(RandevuBilgileri rnd)
        {
            try
            {
                RandevuBilgileriViewModel rndView = new RandevuBilgileriViewModel()
                {
                    RandevuId = rnd.Id,
                    DoktorId = rnd.DoktorId,
                    HastaId = rnd.HastaId,
                    RandevuTarihi = rnd.RandevuTarihi
                };

                Hasta hst = myDBContext.Hastalar.FirstOrDefault(x => x.HastaId == rnd.HastaId);
                rndView.HastaAdSoyad = hst?.HastaAdi + " " + hst?.HastaSoyadi;

                Doktor dr = myDBContext.Doktorlar.FirstOrDefault(x => x.DoktorId == rnd.DoktorId);
                rndView.DoktorAdSoyad = dr?.DoktorAdi + " " + dr?.DoktorSoyadi;

                //servis
                rndView.Servis = EnumManager.BransiTurkceStringOlarakVer(rnd.Doktor.Brans);


                return rndView;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
