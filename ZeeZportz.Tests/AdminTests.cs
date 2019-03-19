using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZeeZportz.Domain.Abstract;
using ZeeZportz.Domain.Entities;
using ZeeZportz.WebUI.Controllers;

namespace ZeeZportz.Tests
{
    //[TestClass]
    //public class AdminTests
    //{
    //    [TestMethod]
    //    public void Can_Edit_Product()
    //    {
    //        // Arrange - create the mock repository  
    //        Mock<IProductRepository> mock = new Mock<IProductRepository>();
    //        mock.Setup(m => m.Products).Returns(new Product[] {
    //            new Product {ProductID = 1, Name = "P1"},
    //            new Product {ProductID = 2, Name = "P2"},
    //            new Product {ProductID = 3, Name = "P3"},
    //        }.AsQueryable());

    //        // Arrange - create the controller     
    //        AdminController target = new AdminController(mock.Object);

    //        // Act     
    //        Product p1 = target.Edit(1).ViewData.Model as Product;
    //        Product p2 = target.Edit(2).ViewData.Model as Product;
    //        Product p3 = target.Edit(3).ViewData.Model as Product;

    //        // Assert     Assert.AreEqual(1, p1.ProductID);     
    //        Assert.AreEqual(2, p2.ProductID);
    //        Assert.AreEqual(3, p3.ProductID);
    //    }

    //    [TestMethod]
    //    public void Cannot_Edit_Nonexistent_Product()
    //    {

    //        // Arrange - create the mock repository    
    //        Mock<IProductRepository> mock = new Mock<IProductRepository>();
    //        mock.Setup(m => m.Products).Returns(new Product[] {
    //            new Product {ProductID = 1, Name = "P1"},
    //            new Product {ProductID = 2, Name = "P2"},
    //            new Product {ProductID = 3, Name = "P3"},
    //        }.AsQueryable());

    //        // Arrange - create the controller     
    //        AdminController target = new AdminController(mock.Object);

    //        // Act    
    //        Product result = (Product)target.Edit(4).ViewData.Model;

    //        // Assert     
    //        Assert.IsNull(result);
    //    }

    //    [TestMethod]
    //    public void Can_Save_Valid_Changes()
    //    {
    //        // Arrange - create mock repository    
    //        Mock<IProductRepository> mock = new Mock<IProductRepository>();
    //        // Arrange - create the controller     
    //        AdminController target = new AdminController(mock.Object);
    //        // Arrange - create a product     
    //        Product product = new Product { Name = "Test" };


    //        // Act - try to save the product     
    //        ActionResult result = target.Edit(product);

    //        // Assert - check that the repository was called     
    //        mock.Verify(m => m.SaveProduct(product));
    //        // Assert - check the method result type     
    //        Assert.IsNotInstanceOfType(result, typeof(ViewResult));
    //    }

    //    [TestMethod]
    //    public void Cannot_Save_Invalid_Changes()
    //    {

    //        // Arrange - create mock repository  
    //        Mock<IProductRepository> mock = new Mock<IProductRepository>();
    //        // Arrange - create the controller     
    //        AdminController target = new AdminController(mock.Object);
    //        // Arrange - create a product     
    //        Product product = new Product { Name = "Test" };
    //        // Arrange - add an error to the model state     
    //        target.ModelState.AddModelError("error", "error");

    //        // Act - try to save the product     
    //        ActionResult result = target.Edit(product);

    //        // Assert - check that the repository was not called     
    //        mock.Verify(m => m.SaveProduct(It.IsAny<Product>()), Times.Never());
    //        // Assert - check the method result type     
    //        Assert.IsInstanceOfType(result, typeof(ViewResult));
    //    }

    //    [TestMethod]
    //    public void Can_Delete_Valid_Products()
    //    {

    //        // Arrange - create a Product     
    //        Product prod = new Product { ProductID = 2, Name = "Test" };

    //        // Arrange - create the mock repository    
    //        Mock<IProductRepository> mock = new Mock<IProductRepository>();
    //        mock.Setup(m => m.Products).Returns(new Product[] {
    //            new Product {ProductID = 1, Name = "P1"},
    //            prod,
    //            new Product {ProductID = 3, Name = "P3"},
    //        }.AsQueryable());

    //        // Arrange - create the controller    
    //        AdminController target = new AdminController(mock.Object);

    //        // Act - delete the product     
    //        target.Delete(prod.ProductID);


    //        // Assert - ensure that the repository delete method was     
    //        // called with the correct Product     
    //        mock.Verify(m => m.DeleteProduct(prod.ProductID));
    //    }
    //}
}

