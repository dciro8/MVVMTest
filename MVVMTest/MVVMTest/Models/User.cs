using SQLite;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace MVVMTest.Models
{
   public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public DateTime CreationData{ get; set; }
    }
}
