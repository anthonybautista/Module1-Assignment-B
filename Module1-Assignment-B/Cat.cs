using System.Threading.Tasks;

namespace Module1_Assignment_B
{
    public class Cat : Pet, ITalkable
    {
        private int _mousesKilled;

        public Cat(int mousesKilled, string name) : base(name)
        {
            _mousesKilled = mousesKilled;
        }

        public int GetMousesKilled()
        {
            return _mousesKilled;
        }

        public void AddMouse()
        {
            _mousesKilled++;
        }

        public string Talk()
        {
            return "Meow!";
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + this.GetName() + " mousesKilled=" + _mousesKilled;
        }
    }
}