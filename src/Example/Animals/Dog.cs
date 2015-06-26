namespace Example.Core.Animals
{
    public sealed class Dog : IAnimal
    {
        public string Talk()
        {
            return "Bark";
        }
    }
}