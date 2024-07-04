namespace SegregationInterface
{
    internal class Flash : ICanSwim, ICanRun
    {
        public void Swim()
        {
            Console.WriteLine("Flash is swimming");
        }

        public void Run()
        {
            Console.WriteLine("Flash is running");
        }
    }
}
