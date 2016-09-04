using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HibbinzA2.Data
{
    public class ShoptrackDataBase
    {
        static object locker = new object();

        SQLiteConnection database;

        string DatabasePath
        {
            get
            {
                var sqliteFilename = "ShopTrack.db3";

#if __ANDROID__
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
				var path = Path.Combine(documentsPath, sqliteFilename);

#endif
                return Path;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
        /// if the database doesn't exist, it will create the database and all the tables.
        /// </summary>
        /// <param name='path'>
        /// Path.
        /// </param>
        public ShoptrackDataBase()
        {
            database = new SQLiteConnection(DatabasePath);
            // create the tables
            database.CreateTable<ShopTrack>();
        }

        public IEnumerable<ShopTrack> GetItems()
        {
            lock (locker)
            {
                return (from i in database.Table<ShopTrack>() select i).ToList();
            }
        }

        public IEnumerable<ShopTrack> GetItemsNotDone()
        {
            lock (locker)
            {
                return database.Query<ShopTrack>("SELECT * FROM [ShopTrack] WHERE [Done] = 0");
            }
        }

        public ShopTrack GetItem(int id)
        {
            lock (locker)
            {
                return database.Table<ShopTrack>().FirstOrDefault(x => x.ID == id);
            }
        }

        public int SaveItem(ShopTrack item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<ShopTrack>(id);
            }
        }
    }
}

