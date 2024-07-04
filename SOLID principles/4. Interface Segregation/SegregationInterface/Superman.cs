namespace SegregationInterface
{
    public class Superman : IHasSuperStrength,ICanFly,ICanSwim,ICanRun
    {
        public void Fly()
        {
            Console.WriteLine("Superman is flying");
        }

        public void Swim()
        {
            Console.WriteLine("Superman is swimming");
        }

        public void UseSuperStrength()
        {
            Console.WriteLine("Superman is using super strength");
        }

        public void Run()
        {
            Console.WriteLine("Superman is running");
        }
    }
}
