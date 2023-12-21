namespace Lab17_Observer_
{
    public class WeatherDataEvent : WeatherDataBase
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public event Action WeatherChanged;

        public override void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            OnWeatherChanged();
        }

        protected virtual void OnWeatherChanged()
        {
            WeatherChanged.Invoke();
        }

        public float GetTemperatureEvent()
        {
            return _temperature;
        }

        public float GetHumidityEvent()
        {
            return _humidity;
        }

        public float GetPressureEvent()
        {
            return _pressure;
        }

        protected override void Notify()
        { }
    }
}
