using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Operators {
    class Equality {
        public static void equality(int[] array) {
            PrimitiveEquality(array[0], array[1]);

            int[] arraySlice1 = array[..3];
            int[] arraySlice2 = array[3..];

            ArrayEquality(arraySlice1, arraySlice2);
        }


        static void PrimitiveEquality(int num1, int num2) {
            Console.WriteLine("{0} > {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} < {1} = {2}", num1, num2, num1 < num2);
            Console.WriteLine("{0} == {1} = {2}", num1, num2, num1 == num2);
            Console.WriteLine("{0} <= {1} = {2}", num1, num2, num1 <= num2);

        }

        static void ArrayEquality(int[] array1, int[] array2) {
           Console.WriteLine("First half of Array: {0}" , array1);
           Console.WriteLine("Second half of Array: {0}", array2);
           Console.WriteLine("First half and Second half are equal: {0}", Object.Equals(array1, array2));


			Object[] obj1 = { array1 };
            Object[] obj2 = { array2 };
            var obj3 = obj2; // This is a pointer

            //Console.WriteLine("arrayObject1 and arrayObject2 are equal: {0}", Arrays.deepEquals(obj1, obj2));
           Console.WriteLine("object 2 and object 3 have same reference: {0}", Object.ReferenceEquals(obj2, obj3));
        }

    }
}
