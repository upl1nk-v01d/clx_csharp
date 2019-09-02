namespace ConsoleApp1
{
    public class FuelGauge
    {
        private int _fuelLevel;
        private const int _maxLevel = 70;
        private const int _minLevel = 0;

        public int ReportLevel()
        {
            return _fuelLevel;
        }

        public void Fill()
        {
            if(_fuelLevel < _maxLevel)
                _fuelLevel++;
        }

        public void DecreaseLevel()
        {
            if(_fuelLevel > _minLevel)
                _fuelLevel--;
        }
    }
}
