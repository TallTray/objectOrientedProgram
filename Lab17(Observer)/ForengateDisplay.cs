namespace Lab17_Observer_
{
    public class ForengateDisplay : IObserver
    {
        private WeatherDataBase _weatherData;
        private float _lastPressure;
        private float _currentPressure;

        public ForengateDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.Attach(this);
        }

        public ForengateDisplay(WeatherDataEvent weatherData)
        {
            _weatherData = weatherData;
            weatherData.WeatherChanged += Update;
        }

        public void Update()
        {
            if (_weatherData != null)
            {
                _lastPressure = _currentPressure;
                _currentPressure = _weatherData.GetPressure();
                Display();
            }
        }

        public void Display()
        {
            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Давление растет");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("Изменений в давлении нет");
            }
            else
            {
                Console.WriteLine("Давление падает");
            }
        }
    }
}
