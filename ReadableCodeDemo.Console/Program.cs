namespace ReadableCodeDemo.Console
{
    internal class Program
    {
        public int DoOperation()
        {
            BusinessManager businessManager = new BusinessManager();

            //return businessManager.ClientState.Value1 + businessManager.ClientState.Value2
            //    * businessManager.ClientState.Value3 + businessManager.ClientState.Value4
            //    / businessManager.ClientState.Value5;

            //-----------------------------------------------------------------------
            //int value1 = businessManager.ClientState.Value1;
            //int value2 = businessManager.ClientState.Value2;
            //int value3 = businessManager.ClientState.Value3;
            //int value4 = businessManager.ClientState.Value4;
            //int value5 = businessManager.ClientState.Value5;
            //int result = value1 + (value2 * value3) + (value4 / value5);
            //return result;

            //----------------------------------------------------------------------

            ClientState cs = businessManager.ClientState;
            return cs.Value1 + cs.Value2 * (cs.Value3 + cs.Value4) / cs.Value5;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
        }
    }
}
