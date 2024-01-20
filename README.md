# Classes d'equivalència UNIT TESTING

## ActionsTests

### TestAttack
- **Valors Vàlids:**
  - Attack = 1, Defense = 1
  - Attack = 5, Defense = 2
  - Attack = 10, Defense = 5
- **Valors Invàlids:**
  - Attack = -2, Defense = 1
  - Attack = 0, Defense = 2
  - Attack = 8, Defense = -3

### TestDeffense
- **Valors Vàlids:**
  - Defense = 1
  - Defense = 5
  - Defense = 10
- **Valors Invàlids:**
  - Defense = -2
  - Defense = 0
  - Defense = 15

### TestRestHP
- **Valors Vàlids:**
  - HP = 100, Attack = 20
  - HP = 50, Attack = 10
  - HP = 80, Attack = 5
- **Valors Invàlids:**
  - HP = -5, Attack = 20
  - HP = 100, Attack = -10
  - HP = 120, Attack = 0

### TestArraySort
- **Valors Vàlids:**
  - Array = {1, 2, 3, 4, 5}
  - Array = {10, 8, 6, 4, 2}
  - Array = {0, 0, 0, 0, 0}
- **Valors Invàlids:**
  - Array = {-1, -2, -3, -4, -5}
  - Array = {7, 5, 3, -1, 2}

### TestCritical
- **Valors Vàlids:**
  - Attack = 1
  - Attack = 5
  - Attack = 10
- **Valors Invàlids:**
  - Attack = -2
  - Attack = 0
  - Attack = 15

### TestRandomProb
- **Valors Vàlids:**
  - Probability = 0
  - Probability = 50
  - Probability = 100
- **Valors Invàlids:**
  - Probability = -5
  - Probability = 120

## StringNamesTests

### TestComprobation
- **Valors Vàlids:**
  - Names = "IlloJuan, Alejo, Pepe"
  - Names = "Carlitos, Eric, Gonzalo, David"
  - Names = "Keko"
- **Valors Invàlids:**
  - Names = ""
  - Names = "Joselu, David, Javi, Raquel, Carol, Carlos"
  - Names = "123"

### TestStringArray
- **Valors Vàlids:**
  - Names = "Kiko, Pepe, Pepa"
  - Names = "Joana, Joan, Marcelo, Jenny"
  - Names = "Luis"
- **Valors Invàlids:**
  - Names = ""
  - Names = "Joana, Marcelo, Jenny, Joselu, Carol, David"
  - Names = "123"

## ModeFuncTests

### TestEasyHardMode
- **Valors Vàlids:**
  - m1 = 1, m2 = 2, m3 = 3, m4 = 4
  - m1 = 5, m2 = 6, m3 = 7, m4 = 8
  - m1 = 10, m2 = 9, m3 = 8, m4 = 7
- **Valors Invàlids:**
  - m1 = -2, m2 = 2, m3 = 3, m4 = 4
  - m1 = 1, m2 = 6, m3 = -7, m4 = 8

### TestRandomMode
- **Valors Vàlids:**
  - min1 = 1, max1 = 10, min2 = 1, max2 = 10, min3 = 1, max3 = 10, min4 = 1, max4 = 10
  - min1 = 5, max1 = 8, min2 = 2, max2 = 6, min3 = 4, max3 = 7, min4 = 1, max4 = 10
  - min1 = 1, max1 = 2, min2 = 3, max2 = 4, min3 = 5, max3 = 6, min4 = 7, max4 = 8
- **Valors Invàlids:**
  - min1 = -2, max1 = 10, min2 = 1, max2 = 10, min3 = 1, max3 = 10, min4 = 1, max4 = 10
  - min1 = 1, max1 = 6, min2 = -7, max2 = 8, min3 = 2, max3 = 4, min4 = 1, max4 = 10

### TestComprobation
- **Valors Vàlids:**
  - array = 5, min = 1, max = 10
  - array = 8, min = 5, max = 15
  - array = 2, min = 1, max = 2
- **Valors Invàlids:**
  - array = -2, min = 1, max = 10
  - array = 12, min = 5, max = 15
  - array = 0, min = 1, max = 2
    
## Dominis

- **Actions:**
  - Attack: [-∞, +∞]
  - Defense: [-∞, +∞]
  - HP: [-∞, +∞]
  - Array elements: [-∞, +∞]
  - Probability: [0, 100]
  
- **StringNames:**
  - Names length: [0, +∞]
  
- **ModeFunc:**
  - m1, m2, m3, m4: [-∞, +∞]
  - min1, max1, min2, max2, min3, max3, min4, max4: [-∞, +∞]
  - array: [-∞, +∞]


```
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
```

  
 
