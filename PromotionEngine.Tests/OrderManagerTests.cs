using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Contracts.Models;
using PromotionEngine.Managers;
using System.Collections.Generic;

namespace PromotionEngine.Tests
{
    [TestClass]
    public class OrderManagerTests
    {
        private OrderManager _orderManager { get; set; }
        public OrderManagerTests()
        {
            _orderManager = new OrderManager();
        }

        //OrderItem as "A" = 1, "B" = 1, "C" = 1 and expected price as 100
        [TestMethod]
        [DataTestMethod]
        [DataRow(100)]
        public void Scenario_A_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "A", TotalUnit = 1 },
                new Product { Name = "B", TotalUnit = 1 },
                new Product { Name = "C", TotalUnit = 1 },
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as "A" = 5, "B" = 5, "C" = 1 and expected price as 370
        [TestMethod]
        [DataTestMethod]
        [DataRow(370)]
        public void Scenario_B_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "A", TotalUnit = 5 },
                new Product { Name = "B", TotalUnit = 5 },
                new Product { Name = "C", TotalUnit = 1 },
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as "A" = 3, "B" = 5, "C" = 1, "D" = 1 and expected price as 280
        [TestMethod]
        [DataTestMethod]
        [DataRow(280)]
        public void Scenario_C_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "A", TotalUnit = 3 },
                new Product { Name = "B", TotalUnit = 5 },
                new Product { Name = "C", TotalUnit = 1 },
                new Product { Name = "D", TotalUnit = 1 },
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as "A" = 1, "B" = 1, "C" = 1, "D" = 1 and expected price as 110
        [TestMethod]
        [DataTestMethod]
        [DataRow(110)]
        public void Scenario_D_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "A", TotalUnit = 1 },
                new Product { Name = "B", TotalUnit = 1 },
                new Product { Name = "C", TotalUnit = 1 },
                new Product { Name = "D", TotalUnit = 1 },
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as "A" = 2, "B" = 2, "D" = 1 and expected price as 160
        [TestMethod]
        [DataTestMethod]
        [DataRow(160)]
        public void Scenario_E_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "A", TotalUnit = 2 },
                new Product { Name = "B", TotalUnit = 2 },
                new Product { Name = "D", TotalUnit = 1 },
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as "A" = 2, "B" = 2, "D" = 1, "C" = 1 and expected price as 175
        [TestMethod]
        [DataTestMethod]
        [DataRow(175)]
        public void Scenario_F_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "A", TotalUnit = 2 },
                new Product { Name = "B", TotalUnit = 2 },
                new Product { Name = "D", TotalUnit = 1 },
                new Product { Name = "C", TotalUnit = 1 },
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as "B" = 3, "D" = 1, "C" = 0 and expected price as 90 
        [TestMethod]
        [DataTestMethod]
        [DataRow(90)]
        public void Scenario_G_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product> {
                new Product { Name = "B", TotalUnit = 3 },
                new Product { Name = "D", TotalUnit = 1 },
                new Product { Name = "C", TotalUnit = 0 },
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //No OrderItem purchased (Empty List) and expected price as 0
        [TestMethod]
        [DataTestMethod]
        [DataRow(0)]
        public void Scenario_H_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>();

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //Only OrderItem "A" with quantity 1 and expected price as 50
        [TestMethod]
        [DataTestMethod]
        [DataRow(50)]
        public void Scenario_I_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "A", TotalUnit = 1 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //Only OrderItem "B" with quantity 1 and expected price as 30
        [TestMethod]
        [DataTestMethod]
        [DataRow(30)]
        public void Scenario_J_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "B", TotalUnit = 1 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //Only OrderItem "C" with quantity 1 and expected price as 20
        [TestMethod]
        [DataTestMethod]
        [DataRow(20)]
        public void Scenario_K_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "C", TotalUnit = 1 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //Only OrderItem "D" with quantity 1 and expected price as 15
        [TestMethod]
        [DataTestMethod]
        [DataRow(15)]
        public void Scenario_L_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "D", TotalUnit = 1 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }


        //All OrderItems having quantity as 0 for each and expected price as 0
        [TestMethod]
        [DataTestMethod]
        [DataRow(0)]
        public void Scenario_M_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "A", TotalUnit = 0 },
                new Product { Name = "B", TotalUnit = 0 },
                new Product { Name = "C", TotalUnit = 0 },
                new Product { Name = "D", TotalUnit = 0 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as A = "10" and expected price as 440
        [TestMethod]
        [DataTestMethod]
        [DataRow(440)]
        public void Scenario_N_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "A", TotalUnit = 10 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as B = "10" and expected price as 225
        [TestMethod]
        [DataTestMethod]
        [DataRow(225)]
        public void Scenario_O_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "B", TotalUnit = 10 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as C = "10" and expected price as 200
        [TestMethod]
        [DataTestMethod]
        [DataRow(200)]
        public void Scenario_P_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "C", TotalUnit = 10 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }

        //OrderItem as D = "10" and expected price as 150
        [TestMethod]
        [DataTestMethod]
        [DataRow(150)]
        public void Scenario_Q_Test(double ExpectedTotalPrice)
        {
            //Prepared Data
            List<Product> orderedProducts = new List<Product>
            {
                new Product { Name = "D", TotalUnit = 10 }
            };

            //Action
            double actualTotalPrice = _orderManager.PlaceOrder(orderedProducts);

            //Validation
            Assert.AreEqual(ExpectedTotalPrice, actualTotalPrice);
        }
    }
}
