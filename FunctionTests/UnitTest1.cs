using FightLibrary;
using ModeFunctions;
namespace FunctionTests
{
    [TestClass]
    public class ActionsTests
    {
        [TestMethod]
        public void TestAttack()
        {
            // Arrange
            float attack = 10;
            float defense = 2;

            // Act
            float result = Actions.Attack(attack, defense);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestDeffense()
        {
            // Arrange
            float deffense = 10;

            // Act
            float result = Actions.Deffense(deffense);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestRestHP()
        {
            // Arrange
            float hp = 100;
            float attack = 20;

            // Act
            float result = Actions.RestHP(hp, attack);

            // Assert
            Assert.AreEqual(80, result);
        }

        [TestMethod]
        public void TestArraySort()
        {
            // Arrange
            float[] array = { 5, 3, 1, 4, 2 };

            // Act
            float[] result = Actions.ArraySort(array);

            // Assert
            CollectionAssert.AreEqual(new float[] { 1, 2, 3, 4, 5 }, result);
        }

        [TestMethod]
        public void TestCritical()
        {
            // Arrange
            float attack = 10;

            // Act
            float result = Actions.Critical(attack);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestRandomProb()
        {
            // Arrange
            int probabilidad = 50;

            // Act
            bool result = Actions.RandomProb(probabilidad);

            // Assert
            Assert.IsInstanceOfType(result, typeof(bool));
        }
    }
    [TestClass]
    public class StringNamesTests
    {
        [TestMethod]
        public void TestComprobation()
        {
            // Arrange
            string names = "Pepe Luis, CarlitosAlcaraz, David, IlloJuan";

            // Act
            bool result = StringNames.Comprobation(names);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestStringArray()
        {
            // Arrange
            string names = "PepeLuis, CarlitosAlcaraz, David, IlloJuan";

            // Act
            string[] result = StringNames.StringArray(names);

            // Assert
            CollectionAssert.AreEqual(new string[] { "PepeLuis", "CarlitosAlcaraz", "David", "IlloJuan" }, result);
        }
    }

    [TestClass]
    public class ModeFuncTests
    {
        [TestMethod]
        public void TestEasyHardMode()
        {
            // Arrange
            float m1 = 1, m2 = 2, m3 = 3, m4 = 4;

            // Act
            float[] result = ModeFunc.EasyHardMode(m1, m2, m3, m4);

            // Assert
            CollectionAssert.AreEqual(new float[] { m1, m2, m3, m4 }, result);
        }

        [TestMethod]
        public void TestRandomMode()
        {
            // Arrange
            float min1 = 1, max1 = 10;
            float min2 = 1, max2 = 10;
            float min3 = 1, max3 = 10;
            float min4 = 1, max4 = 10;

            // Act
            float[] result = ModeFunc.RandomMode(min1, max1, min2, max2, min3, max3, min4, max4);

            // Assert
            Assert.IsTrue(result[0] >= min1 && result[0] <= max1);
            Assert.IsTrue(result[1] >= min2 && result[1] <= max2);
            Assert.IsTrue(result[2] >= min3 && result[2] <= max3);
            Assert.IsTrue(result[3] >= min4 && result[3] <= max4);
        }

        [TestMethod]
        public void TestComprobation()
        {
            // Arrange
            float array = 5, min = 1, max = 10;

            // Act
            bool result = ModeFunc.Comprobation(array, min, max);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

