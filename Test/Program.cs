using GCLibrary.Filter;
using GCLibrary.Logger;

Console.WriteLine("Hello, World!");




/*

IFilter filter1 = new FilterImpl(9, 1, "f1");
IFilter filter2 = new FilterImpl(9, 2, "f2");
IFilter filter3 = new FilterImpl(9, 10, "f3");
IFilter filter4 = new FilterImpl(9, 4, "f4");
IFilter filter5 = new FilterImpl(9, 5, "f5");

FilterManager filterManager = new();


Response result = filterManager
    .Add(filter1)
    .Add(filter2)
    .Add(filter5)
    .Add(filter3)
    .Add(filter4)
    .Filter();

//result= filterManager.Filter();

if (result == null)
{
    Console.WriteLine("null");
}

else if (result.Success)
{
    Console.WriteLine("success");
    Console.WriteLine( result.Message);
}
else
{
    Console.WriteLine(result.Error);
}*/


