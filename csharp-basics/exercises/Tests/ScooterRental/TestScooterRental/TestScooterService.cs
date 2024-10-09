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
        _scooterList.Clear();

        Action action = () =>  _scooterService.GetScooters();

        action.Should().Throw<NoScootersAvailableException>();
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
    public void RemoveScooter_InvalidIdProvided_ThrowInvalidIdException()
    {
        Action action = () => _scooterService.RemoveScooter("");

        action.Should().Throw<InvalidIdException>();
    }

    [TestMethod]
    public void RemoveScooter_InvalidScootersCount_ThrowNoScootersAvailableException()
    {
        _scooterList.Clear();

        Action action = () => _scooterService.RemoveScooter("Id");

        action.Should().Throw<NoScootersAvailableException>();
    }

    [TestMethod]
    public void RemoveScooter_ValidPriceIdProvided_RemoveScooter()
    {
        var scooter = new Scooter("Id", 0.5m);
        _scooterList.Add(scooter);

        _scooterService.RemoveScooter("Id");
        
        _scooterList.Count.Should().Be(0);
    }

    [TestMethod]
    public void GetScooterById_NoIdProvided_ThrowInvalidIdException()
    {
        Action action = () => _scooterService.GetScooterById("");

        action.Should().Throw<NoInputProvidedException>();
    }

    [TestMethod]
    public void GetScooterById_InvalidIdProvided_ThrowInvalidIdException()
    {
        Action action = () => _scooterService.GetScooterById("!?%#");

        action.Should().Throw<InvalidIdException>();
    }

    [TestMethod]
    public void GetScooterById_IdNotFound_ThrowIdNotFoundException()
    {
        _scooterService.AddScooter("1", 0.5m);

        Action action = () => _scooterService.GetScooterById("2");

        action.Should().Throw<IdNotFoundException>();
    }
}