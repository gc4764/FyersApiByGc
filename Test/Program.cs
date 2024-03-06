

using Test;
using Test.Interfaces;

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

IFilter filter1 = new Filter(9,1,"f1");
IFilter filter3 = new Filter(9,0,"f3");
IFilter filter4 = new Filter(9,4, "f4");
IFilter filter5 = new Filter(9,5, "f5");
IFilter filter2 = new Filter(9,2, "f2");

FilterManager.Add(filter1);
FilterManager.Add(filter5);
FilterManager.Add(filter3);
FilterManager.Add(filter2);
FilterManager.Add(filter4);
FilterResponse result=  FilterManager.Use();

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