using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Tabanlı_Programlama_Final_Ödevi
{
    class Urunler
    {

        public string ad { get; set; }
        public string sayfasayisi { get; set; }
        public string fiyat { get; set; }
        public string tur { get; set; }

        
        public string [] BilgiDondur() {

            string[] bilgiler = { tur, ad, fiyat.ToString() };
            return bilgiler;
        }
    }
}
