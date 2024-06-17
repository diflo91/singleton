using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_pattern
{
	class Classe2
	{
		public DatabaseSingleton DataBase { get; set; }

		public Classe2()
		{
			DataBase = DatabaseSingleton.Instance;
		}


		public void GetInstance()
		{
			if (DataBase == null)
			{
				DataBase.Dbstring("Singleton", "19911991fK@", "sa");
			}
		}

	}
}
