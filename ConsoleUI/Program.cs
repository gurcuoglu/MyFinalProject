﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using Business.Abstract;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();




        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productmanager = new ProductManager(new EfProductDal());

            var result = productmanager.GetProductDetails();

            if (result.Success==true)
            {
foreach (var product in productmanager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
