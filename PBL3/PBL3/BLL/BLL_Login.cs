using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLL_Login
    {
		private static BLL_Login _Instance;
		public static BLL_Login Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_Login();
				}
				return _Instance;
			}
			private set { }
		}

		public Login DangNhap(string UserName, string PW)
		{
			PBL3_QLKTX db = new PBL3_QLKTX();
			foreach (Login i in db.Logins)
			{
				if (i.UserName == UserName && i.Password == PW) return i;
			}
			return null;
		}
	}
}
