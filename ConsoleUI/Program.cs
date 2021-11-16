using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			//TestProduct();
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
			}
		}

		private static void TestProduct()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (Product product in productManager.GetAllByUnitPrice(50, 100))
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
