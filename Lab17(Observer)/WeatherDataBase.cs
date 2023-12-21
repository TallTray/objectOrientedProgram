namespace Lab17_Observer_
{
    public abstract class WeatherDataBase
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        protected abstract void Notify();

        public virtual void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Notify();
        }

        public float GetTemperature()
        {
            return _temperature;
        }

        public float GetHumidity()
        {
            return _humidity;
        }

        public float GetPressure()
        {
            return _pressure;
        }
    }
}
