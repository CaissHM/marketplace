using System.Collections.Generic;
using System;

namespace ProjetoMarco___C_
{
    public class Create : User, ICrud
    {
        public Create (int id, string name, Address addressDelivery, 
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
        void ICrud.Create(User user)
        {
            List<User> users = new List<User>();
            Console.ReadLine();
        }
    }
}