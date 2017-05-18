namespace Composition
{
    class Person
    {
        private readonly Walkable _walkable;
        private readonly Swimmable _swimmable;
        private readonly Animal _animal;

        internal Walkable Walkable => _walkable;
        internal Swimmable Swimmable => _swimmable;
        internal Animal Animal => _animal;

        public Person()
        {
            _walkable = new Walkable();
            _swimmable = new Swimmable();
            _animal = new Animal();
        }
    }
}
