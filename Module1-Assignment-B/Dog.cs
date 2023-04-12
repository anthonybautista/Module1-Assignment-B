﻿namespace Module1_Assignment_B
{
    public class Dog : Pet, ITalkable
    {
        private readonly bool _friendly;

        public Dog(bool friendly, string name) : base(name)
        {
            _friendly = friendly;
        }

        public bool IsFriendly()
        {
            return _friendly;
        }

        public string Talk()
        {
            return "Bark!";
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + this.GetName() + " friendly=" + _friendly;
        }
    }
}