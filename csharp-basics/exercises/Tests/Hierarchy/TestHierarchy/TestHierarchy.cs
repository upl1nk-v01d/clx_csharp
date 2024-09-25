using Hierarchy;
using FluentAssertions;
using System.Diagnostics;

namespace Test.Hierarchy;

[TestClass]
public class TestHierarchy
{
    [TestInitialize]
    public void Setup()
    {
        
    }
    
    [TestMethod]
    public void Animal_MakeSound()
    {
        Cat animal = new Cat("Snowbell","Cat", 3.12, 1, "Persian", "Persia", new Meat(1));
        Action action = () => animal.MakeSound();

        action.Should().NotBeNull();
    }

    [TestMethod]
    public void Cat_MakeSound_Sound()
    {
        Cat cat = new Cat("Snowbell","Cat", 3.12, 1, "Persian", "Persia", new Meat(1));

        cat.Sound.Should().NotBeNull();
    }

    [TestMethod]
    public void Cat_MakeSound_ValidSound()
    {
        Cat cat = new Cat("Snowbell","Cat", 3.12, 1, "Persian", "Persia", new Meat(1));
        
        cat.Sound.Should().Contain("meow");
        //Debug.WriteLine(cat.Sound);
    }

    [TestMethod]
    public void Cat_Eat_ValidFood()
    {
        Food meat = new Meat(1);
        Cat cat = new Cat("Snowbell","Cat", 3.12, 1, "Persian", "Persia", meat);
        
        cat.Eat(meat).Should().NotContain("not eating");
    }

    [TestMethod]
    public void Mouse_MakeSound_Sound()
    {
        Mouse mouse = new Mouse("Jerry","Mouse", 0.12, 1, "Azerbaijan", new Vegetables(1));

        mouse.Sound.Should().NotBeNull();
    }

    [TestMethod]
    public void Mouse_MakeSound_ValidSound()
    {
        Mouse mouse = new Mouse("Jerry","Mouse", 0.12, 1, "Azerbaijan", new Vegetables(1));

        mouse.Sound.Should().Contain("peeek");
    }

    [TestMethod]
    public void Tiger_MakeSound_Sound()
    {
        Tiger tiger = new Tiger("Typho","Tiger", 121.3, 1, "Africa", new Meat(1));

        tiger.Sound.Should().NotBe(null);
    }

    [TestMethod]
    public void Tiger_MakeSound_ValidSound()
    {
        Tiger tiger = new Tiger("Typho","Tiger", 121.3, 1, "Africa", new Meat(1));
        
        tiger.Sound.Should().Contain("ROAR");
        //Debug.WriteLine(tiger.Sound);
    }
    
    [TestMethod]
    public void Tiger_Eat_ValidFood()
    {
        Food meat = new Meat(2); 
        Tiger tiger = new Tiger("Typho","Tiger", 121.3, 1, "Africa", meat);
        
        tiger.Eat(meat).Should().NotContain("not eating");
    }

    [TestMethod]
    public void Vegetables_ValidTypeName()
    {
        Food vegetables = new Vegetables(1); 
        
        vegetables.GetType().Name.Should().Be("Vegetables");
        //Debug.WriteLine(vegetables.GetType().Name);
    }

    [TestMethod]
    public void Vegetables_ValidQuantity()
    {
        Food vegetables = new Vegetables(1); 
        //Zebra zebra = new Zebra("Strippy","Zebra", 55.5, 1, "Africa", vegetables); //does not work, shows as abtract class despite class Zebra is modified
        Mouse mouse = new Mouse("Jerry","Mouse", 0.12, 1, "Azerbaijan", vegetables);

        mouse._foodEaten.Should().BeGreaterThan(0);
        //Debug.WriteLine(mouse._foodEaten);
    }

    [TestMethod]
    public void Meat_ValidTypeName()
    {
        Food meat = new Meat(1); 
        
        meat.GetType().Name.Should().Be("Meat");
        //Debug.WriteLine(meat.GetType().Name);
    }

    [TestMethod]
    public void Meat_ValidQuantity()
    {
        Food meat = new Meat(1); 
        Tiger tiger = new Tiger("Typho","Tiger", 121.3, 1, "Africa", meat);

        tiger._foodEaten.Should().BeGreaterThan(0);
        //Debug.WriteLine(tiger._foodEaten);
    }
}