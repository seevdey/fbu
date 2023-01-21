using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm01.Classes
{
    public class Telefon
    {
		private int tusSayisi;

		public int TusSayisi
		{
			get { return tusSayisi; }
			set { tusSayisi = value; }
		}

		public string Marka { get; set; }
		public string Model { get; set; }
		public Color Renk { get; set; }
		public bool KamerasiVarMi{ get; set; }
		public double Agirlik{ get; set; }
		public decimal EkranBoyutu { get; set; }

		public string Isim 
		{
			get
			{
				return Marka + "-" + Model;
			}
		}

	}
}
