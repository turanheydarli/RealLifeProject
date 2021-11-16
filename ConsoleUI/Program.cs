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
			TestProduct();
			//TestCategory();
		}

		private static void TestCategory()
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
			}
		}

		private static void TestProduct()
		{
		
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (var product in productManager.GetProductDetails().Data)
			{
				Console.WriteLine(productManager.GetProductDetails().Success);
				Console.WriteLine(product.ProductName + " / / " + product.CategoryName);
			}
		}
	}
}
