/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add(Product product)
        {
            //*
            //**
            if (product == null)
                throw new ArgumentNullException("product");
            ObjectValidator.Validate(product); 

            return AddCore(product);
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get(int id)
        {
            //*
            if (id < 0)
                throw new ArgumentNullException("Id cannot be empty");

            return GetCore(id);
        }

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll()
        {
            return GetAllCore();
        }

        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove(int id)
        {
            //*
            if (id < 0)
                throw new ArgumentNullException("Id cannot be empty");
            RemoveCore(id);
        }

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update(Product product)
        {
            //*
            //**
            //Get existing product
            var existing = GetCore(product.Id);
            if (product == null)
                throw new ArgumentNullException("product");
            ObjectValidator.Validate(product);

            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore(int id);

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore(int id);

        protected abstract Product UpdateCore(Product existing, Product newItem);

        protected abstract Product AddCore(Product product);

        public abstract bool ExistingProduct(string name);

        #endregion
    }

    //error ***
    //validate**
    //argument*
}
