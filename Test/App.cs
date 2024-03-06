
using System.Runtime.Serialization;
using Test.BaseClasses;
using Test.Interfaces;

public class App
{
    public  class Service : ServiceBase
    {

    }
    


    public  class Filter : FilterManager
    {
        private List<IFilter> _filters;


    }

}