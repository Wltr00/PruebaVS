using Domain.Entities.Inventory;
using Infraestructure.Context.Inventory;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.ContextTest
{
    [TestClass]
    public class InventoryDbContext
    {
        [AssemblyInitialize]
        public static void EnviromentSetup(TestContext testContext)
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Database.EnsureDeleted();
            }
        }

        [TestMethod]
        public void CreateDatabase()
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Database.EnsureCreated();
            }
        }

        [TestMethod]
        public void InsertCategory()
        {
            using (InventoryDB db = new InventoryDB())
            {
                db.Categories.Add(new Category()
                {
                    Name = "Televisores",
                    Description = "para ver"
                });
                int numberOfChanges = db.SaveChanges();
                Assert.AreEqual(numberOfChanges, 1);
            }
        }
    }
}
