﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestEats.Logic;

namespace BestEats.DataAccess
{
    public interface ICustomerRepo
    {
        IEnumerable<Logic.Customer> GetCustomer(string name = null);

        BestEats.Logic.Customer GetCustomerByName(string customerName);

        BestEats.Logic.Customer GetCustomerByID(int customerID);

        int GetCustomerIDByName(string customerName);

        bool CheckCustomerPasswordExists(string userName, string passwordInput);

        bool CheckCustomerNameExists(string loginInput);

        Task RegisterCustomerAsync(BestEats.Logic.Customer DBcustomer);

        void RegisterCustomer(BestEats.Logic.Customer DBcustomer);

        void UnregisterCustomer(int customerID);

        void UpdateCustomer(Logic.Customer customer);
    }
}
