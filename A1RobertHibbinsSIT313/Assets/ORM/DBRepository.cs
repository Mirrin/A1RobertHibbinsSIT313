using System;

using System.Data;
using System.IO;
using SQLite;

namespace A1RobertHibbinsSIT313.Assets.ORM
{
    public class DBRepository
    {
        // code to create Database


        public string CreateDB()
        {
            var output = "";
            output += "creating data base if it doesnt exist.";
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "List.db3");
            var db = new SQLiteConnection(dbPath);
            output += "\nDataBase CZreated ... ";

            return output;


        }
        // code to create table 
        public string CreateTable()
        {

            try // establish a connection 
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "List.db3");
                var db = new SQLiteConnection(dbPath);
                db.CreateTable<ToDoTask>();
                string result = " Table created Successfully ";
                return result;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;

            }
        }
        // insert record


        public string InsertRecord(string task)
        {
            try // establish a connection 
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "List.db3");
                var db = new SQLiteConnection(dbPath);

                ToDoTask item = new ToDoTask();
                item.Task = task;
                db.Insert(item);
                return " Record added";


            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;

            }

        }

        // code to access records saved within my data base 
        public string GetAllRecords()
        {
            // establish a connection 

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "List.db3");
            var db = new SQLiteConnection(dbPath);

            string output = "";
            output += "Getting the data using ORM";
            var table = db.Table<ToDoTask>();
            foreach (var item in table)
            {
                output += "\n" + item.Id + "----" + item.Task;
            }
            return output;


        }

        // code to search ORM 
        public string GetTaskById (int id)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "List.db3");
            var db = new SQLiteConnection(dbPath);

            var item = db.Get<ToDoTask>(id);
            return item.Task;

        }


        // update record
        public string updateRecord(int id, string task)
        {

            // establish connection to data base 
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "List.db3");
            var db = new SQLiteConnection(dbPath);

            var item = db.Get<ToDoTask>(id);
            item.Task = task;
            db.Update(item);
            return "  Record updated";

        }



        // delete funcitonality 
        public string RemoveTask (int id)
        {
            // establish connection 
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "List.db3");
            var db = new SQLiteConnection(dbPath);

            var item = db.Get<ToDoTask>(id);
            db.Delete(item);
            return " List item Removed";


        }
        
    }
}