using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFremawork;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManeger = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManeger.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);

                }
            }
            else{
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
