using ScooterRental;
using FluentAssertions;
using ScooterRental.Exceptions;
using Moq.AutoMock;
using Moq;

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
        _rentalCompany = new RentalCompany(Name, _scooterServiceMock.Object);
    }

    [TestMethod]
    public void CreateRentalCompany_WithNameTest_CompanyCreated()
    {
        _rentalCompany.Name.Should().Be(Name);
    }

    [TestMethod]
    public void StartRent_RentExistingScooter_ScooterIsRented()
    {
        Scooter scooter = new Scooter("1", 5m);
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(scooter);
        _rentalCompany.StartRent("1");

        scooter.IsRented.Should().BeTrue();
    }

    [TestMethod]
    public void StartRent_RentNonExistingScooter__ThrowInvalidOperation()
    {
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => null);

        Action action = () => _rentalCompany.StartRent("1");

        action.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void StartRent_RentRentedScooter_ScooterIsRented()
    {
        var scooter = new Scooter("1", 0.5m)
        {
            IsRented = true
        };

        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => scooter);

        Action action = () => _rentalCompany.StartRent("1");

        action.Should().Throw<InvalidOperationException>();
    }

    public void EndRent_EndRentExistingScooter_ScooterIsNotRented()
    {
        Scooter scooter = new Scooter("1", 5m);

        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(scooter);
        _rentalCompany.EndRent("1");

        scooter.IsRented.Should().BeTrue();
    }

    public void EndRent_RentNonExistingScooter_ThrowInvalidOperation()
    {
        Scooter scooter = new Scooter("2", 5m);
        _scooterServiceMock.Setup(service => service.GetScooterById("2")).Returns(() => null);

        Action action = () => _rentalCompany.StartRent("1");

        action.Should().Throw<InvalidOperationException>();
    }

    public void EndRent_RentNotRentedExistingScooter_ThrowInvalidOperation()
    {
        Scooter scooter = new Scooter("2", 5m);
        scooter.IsRented = true;
        _scooterServiceMock.Setup(service => service.GetScooterById("1")).Returns(() => null);

        Action action = () => _rentalCompany.StartRent("1");

        action.Should().Throw<InvalidOperationException>();
    }
}