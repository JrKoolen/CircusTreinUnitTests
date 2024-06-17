using CircusTrein.Domein;

namespace CircusTrein.UnitTests
{
    public class TDDTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Add_PositiveNumberToObject_ReturnFalse()
        {
            //arrange
            int amount = 10;

            //act
            TDDObject tdd = new TDDObject(11);

            //assert
            Assert.IsFalse(tdd.IsItAboveTotalAmount(11));
        }

        [Test]
        public void CallResetFunction_ReturnZero()
        {
            int amount = 10;

            TDDObject tdd = new TDDObject(amount);

            int result = tdd.ResetAmount();

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Send_ListTDDObjects_ReturnsTrue()
        {
            //Arrange
            int amount = 10;

            TDDObject Original = new TDDObject(amount);
            List<TDDObject> tdd = new List<TDDObject>()
            {
             new TDDObject(9),
             new TDDObject(5),
             new TDDObject(11),
            };

            //Act
            Boolean result = Original.IsItAboveForAll(tdd, 12);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Check_StringName_IsNotNull()
        {
            TDDObject tdd = new TDDObject(1);

            string name = tdd.Name;

            Assert.IsNotNull(name);
        }
    }
}
