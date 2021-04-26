using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4
{
    class Futbolcu
    {
        private string ad, soyad, mevki, takim;
        private int yas;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Mevki
        {
            get { return mevki; }
            set { mevki = value; }
        }
        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }
        public string Takim
        {
            get { return takim; }
            set { takim = value; }
        }
        public string Bilgi()
        {
            return this.ad + this.soyad + " isimli " + this.yas + " yasindaki " + this.mevki + " oyuncusu "
                + this.takim + "'nde forma giymektedir. ";
        }
    }

}
