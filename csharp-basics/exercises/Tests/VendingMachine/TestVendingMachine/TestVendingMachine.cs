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
        vendingMachine.AddProduct("Pepsi", new Money { Euros = 1, Cents = 20 }, 1);

        vendingMachine.HasProducts.Should().BeTrue();
    }

    [TestMethod]
    public void VendingMachine_HasNoProducts()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

        vendingMachine.HasProducts.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_HasBalanceEurosAvailable()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

        vendingMachine.Balance.Euros.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void VendingMachine_HasBalanceEurocentsAvailable()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

        vendingMachine.Balance.Cents.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void VendingMachine_MoneyEuros()
    {
        Money money = new Money{ 
            Euros = 100,
            Cents = 50
        };

        money.Euros.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void VendingMachine_MoneyEurocents()
    {
        Money money = new Money{ 
            Euros = 100,
            Cents = 50
        };

        money.Cents.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void VendingMachine_ProductList_AddProduct()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);

        bool addedProduct = vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);

        addedProduct.Should().BeTrue();
    }

    [TestMethod]
    public void VendingMachine_ProductList_AddedProductAvailable()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);
        
        bool checkedProduct = vendingMachine.CheckProduct(0);

        checkedProduct.Should().BeTrue();
    }

    [TestMethod]
    public void VendingMachine_InsertCoin_MoneyEurosEqualZero()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        Money money = new Money{ Euros = 0, Cents = 0 };

        Money returnedMoney = vendingMachine.InsertCoin(money);
        //Debug.WriteLine("returnedMoney.Euros:" + returnedMoney.Euros);

        returnedMoney.Euros.Should().Be(0);
    }

    [TestMethod]
    public void VendingMachine_InsertCoin_MoneyEurocentsEqualZero()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        Money money = new Money{ Euros = 0, Cents = 0 };

        Money returnedMoney = vendingMachine.InsertCoin(money);
        //Debug.WriteLine("returnedMoney.Cents:" + returnedMoney.Euros);

        returnedMoney.Cents.Should().Be(0);
    }

    [TestMethod]
    public void VendingMachine_InsertCoin_MoneyEurosAboveZero()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        Money money = new Money{ Euros = 5, Cents = 0 };

        Money returnedMoney = vendingMachine.InsertCoin(money);
        //Debug.WriteLine("returnedMoney.Euros:" + returnedMoney.Euros);

        returnedMoney.Euros.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void VendingMachine_InsertCoin_MoneyEurocentsAboveZero()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        Money money = new Money{ Euros = 0, Cents = 20 };

        Money returnedMoney = vendingMachine.InsertCoin(money);
        //Debug.WriteLine("returnedMoney.Euros:" + returnedMoney.Euros);

        returnedMoney.Cents.Should().BeGreaterThan(0);
    }

    [TestMethod]
    public void VendingMachine_ReturnMoney_ReturnEuros()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 0, Cents = 80 }, 1);
        vendingMachine.InsertCoin(new Money{ Euros = 2, Cents = 0 });
        vendingMachine.ChosenProductIndex = 0;

        Money returnedMoney = vendingMachine.ReturnMoney();

        //Debug.WriteLine("returnedMoney.Euros: " + returnedMoney.Euros);
        returnedMoney.Euros.Should().Be(1);
    }

    [TestMethod]
    public void VendingMachine_ReturnMoney_ReturnCents()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);
        vendingMachine.InsertCoin(new Money{ Euros = 2, Cents = 0 });
        vendingMachine.ChosenProductIndex = 0;

        Money returnedMoney = vendingMachine.ReturnMoney();

        //Debug.WriteLine("returnedMoney.Cents: " + returnedMoney.Cents);
        returnedMoney.Cents.Should().Be(80);
    }

    [TestMethod]
    public void VendingMachine_ReturnMoney_ReturnSum()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);
        vendingMachine.InsertCoin(new Money{ Euros = 2, Cents = 0 });
        vendingMachine.ChosenProductIndex = 0;

        Money returnedMoney = vendingMachine.ReturnMoney();
        double sum = returnedMoney.Euros + returnedMoney.Cents * 0.01;

        //Debug.WriteLine("sum: " + sum);
        sum.Should().Be(0.80);
    }

    [TestMethod]
    public void VendingMachine_AddProduct_ProductIsAdded()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        
        bool addedProduct = vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);
        //Debug.WriteLine("addedProduct: " + addedProduct);
        
        addedProduct.Should().BeTrue();
    }

    [TestMethod]
    public void VendingMachine_AddProduct_AddedWithNoName()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        
        bool addedProduct = vendingMachine.AddProduct("", new Money { Euros = 1, Cents = 20 }, 1);
        //Debug.WriteLine("addedProduct: " + addedProduct);
        
        addedProduct.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_AddProduct_PriceIsZeroOrLess()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        
        bool addedProduct = vendingMachine.AddProduct("PepsiCola", new Money { Euros = 0, Cents = 0 }, 1);
        //Debug.WriteLine("addedProduct: " + addedProduct);
        
        addedProduct.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_AddProduct_AddedQuantityZeroOrLess()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        
        bool addedProduct = vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 0);
        //Debug.WriteLine("addedProduct: " + addedProduct);
        
        addedProduct.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_UpdateProduct_NoName()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);

        bool updatedProduct = vendingMachine.UpdateProduct(0, "", new Money { Euros = 1, Cents = 20 }, 1);
        //Debug.WriteLine("updatedProduct: " + updatedProduct);
        
        updatedProduct.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_UpdateProduct_PriceZeroOrLess()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);

        bool updatedProduct = vendingMachine.UpdateProduct(0, "PepsiCola", new Money { Euros = 0, Cents = 0 }, 1);
        //Debug.WriteLine("updatedProduct: " + updatedProduct);
        
        updatedProduct.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_UpdateProduct_QuantityZeroOrLess()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);

        bool updatedProduct = vendingMachine.UpdateProduct(0, "PepsiCola", new Money { Euros = 1, Cents = 20 }, 0);
        //Debug.WriteLine("updatedProduct: " + updatedProduct);
        
        updatedProduct.Should().BeFalse();
    }

    [TestMethod]
    public void VendingMachine_UpdateProduct_ProductIsUpdatedByName()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);

        bool updatedProduct = vendingMachine.UpdateProduct(0, "ColaPepsi", new Money { Euros = 1, Cents = 20 }, 1);
        //Debug.WriteLine("updatedProduct: " + updatedProduct);
        
        updatedProduct.Should().BeTrue();
    }

    [TestMethod]
    public void VendingMachine_UpdateProduct_ProductIsUpdatedByPrice()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 1);

        bool updatedProduct = vendingMachine.UpdateProduct(0, "ColaPepsi", new Money { Euros = 2, Cents = 45 }, 1);
        //Debug.WriteLine("updatedProduct: " + updatedProduct);
        
        updatedProduct.Should().BeTrue();
    }

    [TestMethod]
    public void VendingMachine_UpdateProduct_ProductIsUpdatedByQuantity()
    {
        VendingMachine vendingMachine = new VendingMachine("Coke", 100, 50);
        vendingMachine.AddProduct("PepsiCola", new Money { Euros = 1, Cents = 20 }, 5);

        bool updatedProduct = vendingMachine.UpdateProduct(0, "PepsiCola", new Money { Euros = 1, Cents = 20 }, 5);
        //Debug.WriteLine("updatedProduct: " + updatedProduct);
        
        updatedProduct.Should().BeTrue();
    }
}