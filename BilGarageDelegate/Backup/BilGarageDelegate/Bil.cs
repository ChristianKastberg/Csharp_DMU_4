using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilGarageDelegate
{
    class Bil
    {
        public delegate void Arbejde(Bil b);

        private string nummer = "";
        private string mærke = "";
        private int antalKørteKm = 0;
        private bool snavset = false;
        private bool bytHjul = false;

		public Bil(string nummer, string mærke, int antalKørteKm)
		{
            this.nummer = nummer;
            this.mærke = mærke;
            this.antalKørteKm = antalKørteKm;
        }

        public override string ToString() 
        {
            return "Nummer: " + nummer + Environment.NewLine +
                    " mærke: " + mærke + Environment.NewLine +
                    " antal kørte km: " + antalKørteKm + Environment.NewLine +
                    " er snavset: " + snavset + Environment.NewLine +
                    " skal have byttet hjul: " + bytHjul + Environment.NewLine;
        }

        public bool Snavset 
        {
            get {return snavset;}
            set {snavset = value;}
        }
    
        public bool BytHjul 
        {
            get {return bytHjul;}
            set {bytHjul = value;}
        }


    }
}
