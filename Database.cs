using System.Collections.Generic;

namespace ProjetoMarco___C_
{
    public static class Database
    {
        public static List<User> Users { get; set; }
        static Database()
        {
            Users = new List<User>();
        }
    }
}