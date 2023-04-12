namespace Module1_Assignment_B
{
    public abstract class Person
    {
        private readonly string _name;

        protected Person(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}