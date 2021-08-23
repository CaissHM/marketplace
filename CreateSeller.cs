using System.Collections.Generic;
using System;

namespace ProjetoMarco___C_
{
    public class CreateSeller : Seller, ICrud
    {
        public CreateSeller (int id, string name, Address addressDelivery, 
        Address addressBilling, string user, string password, DateTime birthDate)
        {
            base.id = id;
            base.name = name;
            base.addressBilling = addressBilling;
            base.addressDelivery = addressDelivery;
            base.user = user;
            base.password = password;
            base.birthDate = birthDate;
        }
        public void Create(User user)
        {
            List<User> sellers = new List<User>();
            Console.ReadLine();
        }
    }
}