using Reflection;
using System.Reflection;

Type type = typeof(Customer);

Console.WriteLine("Class: " + type.Name);

Console.WriteLine("Namespace: " + type.Namespace);

Console.WriteLine();

GetPropertyInfo();

static void GetPropertyInfo()
{
    Type type = typeof(Customer);

    PropertyInfo[] propertyInfo = type.GetProperties();

    Console.WriteLine("The list of properties of the Customer class are:--");

    foreach (PropertyInfo pInfo in propertyInfo)
    {
        Console.WriteLine(pInfo.Name);
    }
}
