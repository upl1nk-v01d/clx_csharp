using FluentAssertions;
using System.Diagnostics;
using VendingMachineNS;

namespace Test.VendingMachineNS;

[TestClass]
public class TestVendingMachine
{
    [TestInitialize]
    public void Setup()
    {

    }

    [TestMethod]
    public void VendingMachine_Manufactuter()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

        vendingMachine.Manufacturer.Should().NotBeEmpty();
    }

    [TestMethod]
    public void VendingMachine_HasProducts()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

        vendingMachine.HasProducts.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_HasNoProducts()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("Pepsi", new Money { Euros = 1, Cents = 20 }, 0);

        vendingMachine.HasProducts.Should().BeTrue();
    }
}