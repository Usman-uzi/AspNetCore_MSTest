using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReviewStore.Controllers;
using ReviewStore_Data;
using ReviewStore_Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MSTest_ReviewStore
{
    [TestClass]
    public class TestProductController
    {
        [TestMethod]
        public async Task GetAllProducts_ShouldReturnAllProducts()
        {
            IProductRepo testRepo = new ProductRepo();
            var testProducts = testRepo.GetList();

            var controller = new ProductController(testRepo);

            var result = await controller.Get();
            var actionResult = (OkObjectResult) result;
            
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetAllProductsAsync_ShouldReturnAllProducts()
        {
            IProductRepo testRepo = new ProductRepo();
            var testProducts = testRepo.GetList();

            var controller = new ProductController(testRepo);

            var result = await controller.GetAllProductsAsync() as List<Product>;
          
            Assert.AreEqual(testProducts.Count, result.Count);
        }

        /*[TestMethod]
        public void GetProduct_ShouldReturnCorrectProduct()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductController(testProducts);

            var result = controller.GetProduct(4) as OkNegotiatedContentResult<Product>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProducts[3].Name, result.Content.Name);
        }*/

        /*[TestMethod]
        public async Task GetProductAsync_ShouldReturnCorrectProduct()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductController(testProducts);

            var result = await controller.GetProductAsync(4) as OkNegotiatedContentResult<Product>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProducts[3].Name, result.Content.Name);
        }*/

        /*[TestMethod]
        public void GetProduct_ShouldNotFindProduct()
        {
            var controller = new ProductController(GetTestProducts());

            var result = controller.GetProduct(999);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }*/
    }
}
