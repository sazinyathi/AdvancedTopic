namespace Generic
{
    public class GenericInitializerObject<T> where T: new()
    {
        private T _object;
        public GenericInitializerObject()
        {
            _object = new T ();
        }
        public T CreateInitializerObjectGeneric()
        {
            return _object;
        }
    }
}
