namespace Module1_Assignment_B
{
    public abstract class Pet
    {
        private readonly string _name;

        protected Pet(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}