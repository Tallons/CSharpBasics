using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics.Basics {
    class Switches {

        public static void switches(string action, object item, string[] items) {
            const string ADD = "add";
            const string REMOVE = "remove";
            const string EDIT = "edit";
            const string SORT = "sort";
            switch(action.ToLower()) {
                case ADD:
                    // add item to array
                        break;
                case REMOVE:
                    //remove item from array
                    break;
                case EDIT:
                    //replace Item in array with updated info
                    break;
                case SORT:
                    //sort array
                    break;
                default:
                    Console.WriteLine("Error in Switch - action was: " + action);
                    break;
            }
        }
    }
}
