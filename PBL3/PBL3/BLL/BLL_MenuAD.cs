using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLL_MenuAD
    {
		private static BLL_MenuAD _Instance;
		public static BLL_MenuAD Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_MenuAD();
				}
				return _Instance;
			}
			private set { }
		}

		public string BLL_MenuADSetName(string Id)
        {
			string s = "";
			PBL3Entities db = new PBL3Entities();
			foreach(NhanVien i in db.NhanViens)
            {
				if(i.Ma_TK == Id)
                {
					s = i.HoTen;
					break;
                }
            }
			
			return s;
		}
	}
}
