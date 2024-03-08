

using Test;
using GCLibrary.Filter;
using GCLibrary.Logger;

Console.WriteLine("Hello, World!");

/*App app = new();*/

/*app.Service.Add("whitelist");

app.Filter.Add("whiltelistvalidationObj", "wlv");
app.Filter.Add("whiltelistvalidationObj", "blv");
app.Filter.Add("whiltelistvalidationObj", "gv");



app.use("wlv");
app.use("wlv");
app.use("wlv");
app.use("wlv");*/

IFilter filter1 = new Filter(9, 1, "f1");
IFilter filter2 = new Filter(9, 2, "f2");
IFilter filter3 = new Filter(9, 10, "f3");
IFilter filter4 = new Filter(9, 4, "f4");
IFilter filter5 = new Filter(9, 5, "f5");

FilterManager filterManager = new();


filterManager.Add(filter1);
filterManager.Add(filter5);
filterManager.Add(filter3);

filterManager.Add(filter2);
filterManager.Logger = new BlankLogger();

filterManager.Add(filter4);
Response result= filterManager.Use();

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
}