namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int [] {4,5,1,4,6,8,9,1 };
            Bubble bubble = new Bubble(nums);
            bubble.Sort();
            Choice choice = new Choice(nums);
            choice.Sort();
        }
    }
}
