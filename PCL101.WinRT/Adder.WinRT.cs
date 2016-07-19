using System.Threading.Tasks;

namespace PCL101
{
    public sealed class Adder
    {
        private static int SpawnTaskAndAddTwoNumbers(int x, int y)
        {
            int z = 0;
            var t = Task.Run(() => z = CommonUtils.SillyAdditionImplementation(x,y));
            t.Wait();
            return z;
        }

        public static int add(int x, int y)
        {
            return SpawnTaskAndAddTwoNumbers(x, y);
        }
    }
}
