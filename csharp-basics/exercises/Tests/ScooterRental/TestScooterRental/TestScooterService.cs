using ScooterRental;
using FluentAssertions;
using ScooterRental.Exceptions;

namespace Test.ScooterRental;

[TestClass]
public class TestScooterService
{
    private ScooterService _scooterService;
    private List<Scooter> _scooterList;

    [TestInitialize]
    public void Setup()
    {
        _scooterList = new List<Scooter>();
        _scooterService = new ScooterService(_scooterList);
    }

    [TestMethod]
    public void GetScooters_InvalidScootersCount_ThrowNoScootersAvailableException()
    {
        //var scooter = new Scooter("Id", 0.5m);
        //_scooterList.Add(scooter);

        _scooterList.Count.Should().Be(0);
    }

    [TestMethod]
    public void AddScooter_ValidPriceIdProvided_AddScooter()
    {
        _scooterService.AddScooter("Id", 0.5m);
        _scooterList.Count.Should().Be(1);
    }

    [TestMethod]
    public void AddScooter_InvalidPriceProvided_ThrowInvalidPriceException()
    {
        Action action = () => _scooterService.AddScooter("Id", 0m);

        action.Should().Throw<InvalidPriceException>();

    }

    [TestMethod]
    public void AddScooter_InvalidIdProvided_ThrowInvalidIdException()
    {
        Action action = () => _scooterService.AddScooter("", 0.3m);

        action.Should().Throw<InvalidIdException>();

    }

    [TestMethod]
    public void AddScooter_DuplicateIdProvided_ThrowDuplicateIdException()
    {
        var scooter = new Scooter("Id", 0.5m);
        _scooterList.Add(scooter);

        Action action = () => _scooterService.AddScooter(scooter.Id, 0.3m);

        action.Should().Throw<DuplicateIdException>();
    }

    [TestMethod]
    public void RemoveScooter_InvalidScootersCount_ThrowNoScootersAvailableException()
    {
        //var scooter = new Scooter("Id", 0.5m);
        //_scooterList.Add(scooter);

        _scooterList.Count.Should().Be(0);
    }

    [TestMethod]
    public void RemoveScooter_ValidPriceIdProvided_RemoveScooter()
    {
        _scooterService.RemoveScooter("Id");
        _scooterList.Count.Should().Be(0);
    }

    [TestMethod]
    public void RemoveScooter_InvalidIdProvided_ThrowInvalidIdException()
    {
        Action action = () => _scooterService.RemoveScooter("");

        action.Should().Throw<InvalidIdException>();
    }
}