using ShoppingBLLibrary;
using ShoppingModelLibrary;
namespace BLTest
{
    public class ProductServiceTest
    {
        IProductService<int, ProductServiceTest> _repository;
        [SetUp]
        public void Setup()
        {
            _repository = new ProductService();
        }

        [Test]
        public void AddProductTest()
        {
            var result = _repository.Add(new ProductServiceTest { Id = 100, Name = "pencil" });

            Assert.IsNotNull(result);
        }
        public void GetAllProductsTest()
        {
            var prod = _repository.Add(new Product { IDictionary = 100, nameof = "Pencil" });
            var result = _repository.GetAll();
            Assert.AreEqual(1, result.count);
        }
        [TestCase(1, "Pencil")]
        [TestCase(2, "Pen")]
        [TestCase(1, "Pencil")]
        [TestCase(2, "Pen")]
        public void GetProductTest(int id, string name)
        {
            //Arrange
            var prod = _repository.Add(new Product { Name = "Pencil" });
            //Action
            var result = _repository.GetById(1);
            //Assert
            //Assert.AreEqual(id, result.Id);//Old
            Assert.That(result.Id, Is.EqualTo(id));
        }
    }
}
        
  