namespace Generic
{
    public class Nullables<T> where T : struct
    {
        private object _value;
        public Nullables()
        {

        }
        public Nullables(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }
        public T GetVaueOrDefault()
        {
            if (HasValue)
                return (T)_value;
            return default(T);
        }
    }
}
