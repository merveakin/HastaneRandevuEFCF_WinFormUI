using HastaneRandevuEFCF_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_BLL
{
    public static class EnumManager
    {
        public static List<Enums> TumBranslariGetir()
        {
            List<Enums> data = new List<Enums>();
            foreach (var item in Enum.GetValues(typeof(Branslar)))
            {
                Enums theEnum = new Enums()
                {
                    TheKey = Convert.ToInt32(item),
                    TheValue = item.ToString()
                };
                data.Add(theEnum);
            }
            return data;
        }

        public static string BransiTurkceStringOlarakVer(Branslar brans)
        {
            string bransString = "";

            switch (brans)
            {
                case Branslar.BransYok:
                    bransString = "Genel Servisi";
                    break;
                case Branslar.Dahiliye:
                    bransString = "Dahiliye Servisi";
                    break;
                case Branslar.KBB:
                    bransString = "KBB Servisi";
                    break;
                case Branslar.GozHastaliklari:
                    bransString = "Göz Hastalıkları Servisi";
                    break;
                case Branslar.Ortopedi:
                    bransString = "Ortopedi Servisi";
                    break;
                case Branslar.Kardiyoloji:
                    bransString = "Kardiyoloji Servisi";
                    break;
                default:
                    bransString = "Genel Servis";
                    break;
            }

            return bransString;
        }
    }
}
