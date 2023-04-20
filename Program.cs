namespace Home20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            string[] Array = new string[4];
            try
            {
                AddToArray(Array, name);
            }
            catch (Exception Exc)
            {

                Console.WriteLine( Exc.Meesage);
            }
        }

        static void AddToArray(string[] array, string name)
        {
            for (int i = 0; i < name.Length; i++) 
            {
                if (char.IsDigit(name[i]))
                {
                    throw new MyException("wrongg namee");
                }
            
            }
            Console.WriteLine("truee namee");
        }
    }
}