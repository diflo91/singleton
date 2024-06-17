using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Design_pattern
{
	class DatabaseSingleton : DbContext
	{
        private static Lazy<DatabaseSingleton> _instance = new Lazy<DatabaseSingleton>(() => new DatabaseSingleton());
		private DbSet<Classe1> classe1s {  get; set; }
		private DbSet<Classe2> classe2s {  get; set; }
		private DatabaseSingleton() { }
		



		public static DatabaseSingleton Instance
		{

			get
			{

				return _instance.Value;
			
			}
	
		}


		public void Dbstring(string _database, string _mdp, string _usr)
		{
			DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
			optionsBuilder.UseSqlServer( @"Server=localhost;DataBase= " + _database + "User = " + _usr + " Password = " + _mdp + " TrustServerCertificate=True;");
		}




	}
}
