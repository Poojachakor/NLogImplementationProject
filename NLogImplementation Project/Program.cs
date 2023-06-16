using System.Collections;

namespace NLogImplementation_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryOperations dictionaryOperations = new DictionaryOperations();
            dictionaryOperations.AddItem();
            dictionaryOperations.ReadItem();
            dictionaryOperations.UpdateItem();
            dictionaryOperations.DeleteItem();
        }
    }
}
    
