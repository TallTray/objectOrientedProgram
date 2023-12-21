namespace Lab17_Observer_
{
    public class GeneralDisplay : IObserver
    {
        private WeatherDataBase _weatherData;

        public GeneralDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.Attach(this);
        }

        public GeneralDisplay(WeatherDataEvent weatherData)
        {
            _weatherData = weatherData;
            weatherData.WeatherChanged += Update;
        }

        public void Update()
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine(_weatherData.GetTemperature() + "градусов по Фаренгейту и " + _weatherData.GetHumidity() + "% влажности");
        }
    }
}
