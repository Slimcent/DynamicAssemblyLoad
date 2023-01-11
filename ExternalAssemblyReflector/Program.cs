using System.Reflection;

Console.WriteLine("***** External Assembly Viewer *****");

do
{
    Console.WriteLine("\nEnter an assembly to evaluate");
    
    // Get name of assembly.
    string asmName = Console.ReadLine();
    
    try
    {
        Assembly asm = Assembly.LoadFrom(asmName);
        DisplayTypesInAsm(asm);
    }
    catch
    {
        Console.WriteLine("Sorry, can't find assembly.");
    }
} while (true);

static void DisplayTypesInAsm(Assembly asm)
{
    Console.WriteLine("\n***** Types in Assembly *****");
    Console.WriteLine("->{0}", asm.FullName);
    Type[] types = asm.GetTypes();
    foreach (Type t in types)
    {
        Console.WriteLine("Type: {0}", t);
    }
    Console.WriteLine("");
}