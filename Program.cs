using System;

namespace ReviewdogDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This is a demo file for testing reviewdog
            var message = "Hello, Reviewdog!";
            Console.WriteLine(message);
            
            // Intentionally added some issues for reviewdog to catch:
            // - Unused variable
            var unused = 42;
            
            // - Missing null check
            string? nullableString = null;
            var length = nullableString.Length; // Potential null reference
            
            // - Inconsistent formatting
            int x=1+2;
        }
        
        // - Missing XML documentation
        public void DoSomething()
        {
            // Method without documentation
        }
    }
}
