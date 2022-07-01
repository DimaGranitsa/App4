using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App4.DataBase
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        public string Login { get; set; }
         public string Password { get; set; }
        public string surname { get; set; }
    }
    //[Table("Users")]
    //public class User
    //{
    //    [PrimaryKey, AutoIncrement, Column("_id")]
    //    public int Id { get; set; }
    //    [Unique]
    //    public string Login { get; set; }
    //    public string Password { get; set; }
    //    public string FIO { get; set; }


    //}
}
