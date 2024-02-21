﻿

using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add(); 
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();


Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Engin";
customer.LastName = "Demiroğ";
customer.City = "Ankara";
 

Console.WriteLine(customer.FirstName );