using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class BLL_MenuSV
    {
		private static BLL_MenuSV _Instance;
		public static BLL_MenuSV Instance
		{
			get
			{
				if (_Instance == null)
				{
					_Instance = new BLL_MenuSV();
				}
				return _Instance;
			}
			private set { }
		}
		public string BLL_MenuSVSetName(string Id)
		{
			string s = "";
			PBL3Entities db = new PBL3Entities();
			foreach (SV i in db.SVs)
			{
				if (i.Ma_TK == Id)
				{
					s = i.Ho_Ten;
					break;
				}
			}
			return s;
		}
	}
}
