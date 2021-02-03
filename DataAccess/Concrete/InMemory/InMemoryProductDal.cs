using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Low-heeled", UnitPrice = 130, UnitsInStock = 42},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "High-heeled", UnitPrice = 155, UnitsInStock = 63},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "Babette", UnitPrice = 90, UnitsInStock = 74},
                new Product{ProductId = 4, CategoryId = 1, ProductName = "Wedge", UnitPrice = 125, UnitsInStock = 27},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Purse", UnitPrice = 100, UnitsInStock = 56},
                new Product{ProductId = 6, CategoryId = 2, ProductName = "Cabas", UnitPrice = 85, UnitsInStock = 43}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;

            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //_products.Remove(productToDelete);

            //LINQ
            productToDelete = _products.SingleOrDefault(p => product.ProductId == p.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //LINQ
            Product productToUpdate = _products.SingleOrDefault(p => product.ProductId == p.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
