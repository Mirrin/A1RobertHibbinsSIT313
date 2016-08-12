using System;
using System.Data;
using System.IO;
using SQLite;


namespace A1RobertHibbinsSIT313.Assets.ORM
{
    // declare the table 
    [Table ("ToDoTask")]

   public class ToDoTask

    {
        [PrimaryKey,AutoIncrement,Column("_Id")]

        public int Id { get; set; }
         [MaxLength(50)]
         public string Task { get; set; }



    }
}