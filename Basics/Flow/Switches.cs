using System;
using System.Collections.Generic;
using System.Linq;
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
        public static void MatchingSwitches(int[] nums)
        {

	        int average = nums.Sum() / nums.Length;

            switch(average) {
                case var n when n >= 90:
					// something
					break; 
                case var n when n >= 80:
					// something
					break;
                case var n when n >= 70:
					// something
					break; 
                case var n when n >= 60:
					// something
					break;
                case var n when n >= 50:
					// something
					break;
                default:
	                // something
                    break;
            }
        }


    }
}
