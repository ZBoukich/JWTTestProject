using System.Collections.Generic;
using System.Reflection;
using static System.Console;

namespace ReflectionHaha
{
    public class Person
    {
        public string Name { get; private set; } = "Farid";
        public void SetName(string x) => Name = x == "Farid" ? "Zahay" : "Nothing";
             
    }

    class Program
    {
        static void Main(string[] args)
        {

            //var assembly = Assembly.GetExecutingAssembly();
            //var name = assembly.Location;
            var zahay = new Person();
            zahay.SetName("Fari");
            WriteLine(zahay.Name);


            //  var strDict = new Dictionary<string, string>();
            //  strDict.Add("birthDate", "1987 ");
            //  var dtModel = new DataModel { Requirement = "39000", Strdict = strDict };
            //  foreach (var prop in dtModel.GetType().GetProperties())
            //  {
            //      WriteLine(prop.GetValue());
            //      //if (typeof(IDictionary).IsAssignableFrom(prop.PropertyType))
            //      //{

            //      //}

            ReadLine();
            //      //PropertyInfo? propertyOfDataModel = idinDataModelType.GetProperty(propertyOfisxData.Name);
            //      //propertyOfDataModel?.SetValue(idinDataModel, propertyOfisxData.GetValue(isxData));
        }          ////  var isSubClass = typeof(IDictionary).IsAssignableFrom(strDict.GetType());
                   //////  WriteLine(isDict);
                   ////  WriteLine(isSubClass);




        static DataModel EncryptModel(DataModel dataModel)
        {

            return null;
        }

    }
}
