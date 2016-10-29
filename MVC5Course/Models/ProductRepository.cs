using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ProductRepository : EFRepository<Product>, IProductRepository
	{
        public Product Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ProductId == id);
        }

        public IQueryable<Product> Get所有資料_依據ProductId排序(int takeSize)
        {
            return this.All().OrderByDescending(p => p.ProductId).Take(takeSize);
        }

        public override IQueryable<Product> All()
        {
            return base.All().Where(p => p.IsDelet == false);
        }

        public override void Delete(Product Product)
        {
            Product.IsDelet = true;
        }
    }

	public  interface IProductRepository : IRepository<Product>
	{

	}
}