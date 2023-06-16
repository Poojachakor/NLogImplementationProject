using System.Collections;

namespace NLogImplementation_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayListOperation arrayListOperation = new ArrayListOperation();
            arrayListOperation.AddItems();
            arrayListOperation.ReadItems();
            arrayListOperation.UpdateItems();
            arrayListOperation.DeleteItem();
        }
    }
}
    
