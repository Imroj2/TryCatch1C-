class Program
{
    static void Main()
    {
        try
        {
            int[] array = new int[6];
            int value = array[10];
            try
            {
                //nested try block
                int x = 10;
                Console.WriteLine(x / 0);        
            }
            catch (Exception e)
            {
                   Console.WriteLine("Exception caught: {0}", e);
            
            }
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException:" + ex.Message);
        }
        finally
        {
            //cleanup code {always executed
            Console.WriteLine("Finnaly block is executed");
        }
    }
}