using System;

namespace ProjetoMarco___C_
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public Address addressDelivery { get; set; }
        public Address addressBilling { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public DateTime birthDate { get; set; }
    }
}
