using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_DataStructures_Algorithms_Fundamentals
{
    public partial class RecursionIV
    {

        public static List<string> CollectStrings(Dictionary<string, object> obj)
        {
            List<string> stringsList = new List<string>();

            void GatherStrings(Dictionary<string, object> o)
            {
                foreach (var keyValuePair in o)
                {
                    if (keyValuePair.Value is string)
                    {
                        stringsList.Add((string)keyValuePair.Value);
                    }
                    else if (keyValuePair.Value is Dictionary<string, object>)
                    {
                        GatherStrings((Dictionary<string, object>)keyValuePair.Value);
                    }
                }
            }

            GatherStrings(obj);

            return stringsList;
        }



        public static List<string> CollectStringsPure(Dictionary<string, object> obj)
        {
            List<string> stringsList = new List<string>();

            foreach (var keyValuePair in obj)
            {
                if (keyValuePair.Value is string)
                {
                    stringsList.Add((string)keyValuePair.Value);
                }
                else if (keyValuePair.Value is Dictionary<string, object>)
                {
                    stringsList.AddRange(
                        CollectStringsPure(
                            (Dictionary<string, object>)keyValuePair.Value));
                }
            }

            return stringsList;
        }

    }
}

/*
CollectStrings

Write a function called collectStrings which accepts an Dictionary<string,object> and 
returns an array of all the nested values of type object that have a typeof string
*/