using ScooterRental;
using FluentAssertions;
using ScooterRental.Exceptions;
using Moq.AutoMock;
using Moq;
using System.Diagnostics;

namespace Test.Moq.ScooterRental;

[TestClass]
public class TestScooterService
{
    private RentalCompany _rentalCompany;
    private AutoMocker _mocker;
    private Mock<IScooterService> _scooterServiceMock;
    private const string Name = "Test";

    [TestInitialize]
    public void Setup()
    {
        _mocker = new AutoMocker();
        _scooterServiceMock = _mocker.GetMock<IScooterService>();
        _rentalCompany = new RentalCompany(Name, _scooterServiceMock.Object, new List<RentedScooter>());
    }

    [TestMethod]
    public void CreateRentalCompany_WithNameTest_CompanyCreated()
    {
        _rentalCompany.Name.Should().Be(Name);
    }

    [TestMethod]
    public void StartRent_ExistingScooter_ScooterIsRented()
    {
        Scooter scooter = new Scooter("1", 5m);
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(scooter);
        _rentalCompany.StartRent("1");

        scooter.IsRented.Should().BeTrue();
    }

    [TestMethod]
    public void StartRent_NonExistingScooter__ThrowInvalidOperation()
    {
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => null);

        Action action = () => _rentalCompany.StartRent("1");

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void StartRent_RentWithZeroOrLessMinutes_ThrowInvalidOperation()
    {
        Scooter scooter = new Scooter("1", 0m);
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => null);

        Action action = () => _rentalCompany.StartRent("1");

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void StartRent_RentedScooter_ScooterIsRented()
    {
        var scooter = new Scooter("1", 0.5m);
        scooter.IsRented = true;

        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => scooter);

        Action action = () => _rentalCompany.StartRent("1");

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void EndRent_ExistingScooter_ScooterRentIsEnded()
    {
        Scooter scooter = new Scooter("1", 5m);

        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(scooter);
         _rentalCompany.StartRent("1");
        _rentalCompany.EndRent("1");

        scooter.IsRented.Should().BeFalse();
    }

    [TestMethod]
    public void EndRent_NonExistingScooter_ThrowInvalidOperation()
    {
        Scooter scooter = new Scooter("1", 5m);
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => scooter);

        Action action = () => _rentalCompany.EndRent("2");

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void EndRent_NotRentedScooter_ThrowInvalidOperation()
    {
        Scooter scooter = new Scooter("1", 5m);
        scooter.IsRented = false;
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => scooter);

        Action action = () => _rentalCompany.EndRent("1");

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void CalculateIncome_NoRentedScooters_ThrowInvalidOperation()
    {        
        Action action = () => _rentalCompany.CalculateIncome(2024, true);

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void CalculateIncome_InvalidYearProvided_ThrowInvalidOperation()
    {
        RentedScooter rentedScooter = new RentedScooter("1", 1m, new DateTime(2024, 01, 01, 10, 00, 00));
        _rentalCompany._rentedScooters.Add(rentedScooter);

        Action action = () => _rentalCompany.CalculateIncome(2025, true);

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void CalculateIncome_ReturnedSum()
    {
        RentedScooter rentedScooter = new RentedScooter("1", 1, new DateTime(2024, 01, 01, 10, 00, 00));
        rentedScooter._endTime = new DateTime(2024, 01, 01, 10, 01, 00);
        _rentalCompany._rentedScooters.Add(rentedScooter);

        decimal sum = _rentalCompany.CalculateIncome(2024, true);
        Debug.WriteLine("sum: " + sum);

        sum.Should().Be(1m);
    }
}