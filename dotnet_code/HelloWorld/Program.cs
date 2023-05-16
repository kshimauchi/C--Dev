using System;

namespace HelloWorld // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Primitives and ranges

            //Signed 8-bit integer 	-128 to 127 System.SByte
            sbyte mySbyte = 127;
            sbyte mySecondSByte = -128;
            //Unsigned 8-bit integer 0 to 255   System.Byte
            byte myByte = 255;
            byte mySecondByte = 0;

            //Signed 16-bit integer                 System.Int16
            short myShort=-32768;
            short mySecondShort = 32767;
            
            //Unsigned 16-bit integer               System.UInt16
            ushort myUshort = 65535;
            ushort myUShort = 0;
          
            //Signed 32-bit                         System.Int32
            int myInt = 2147483647;
            int mySecond = -2147483648;
        
            //UnSigned 32-bit                       System.UInt32
            uint myUnSignedInt = 0;
            uint mySecondUnSignedInt = 4294967295;

            
            //Signed 64-bit                         System.Int64
            long minLong = -9223372036854775808; 
            long maxLong = 9223372036854775807;

            //UnSigned 64-bit                       System.UInt64
            ulong minULong = 0;
            ulong maxULong = 18446744073709551615;

            //Decimals 
            float myFloat = 0.751f;
            float mySecondFloat = 0.75f;
            Console.WriteLine( myFloat - mySecondFloat);

            double myDouble = 0.751d;
            double mySecondDouble = 0.751d;
            Console.WriteLine(myDouble - mySecondDouble);

            decimal myDecimal =0.751m;
            decimal mySecondDecimal =0.751m;
            Console.WriteLine(myDecimal - mySecondDecimal); 
                       
                      
            string myString = "is a string";
            Console.WriteLine(myString);
            string myStringWithSymbols = "@!#$@@%^&A&";
            Console.WriteLine(myStringWithSymbols); 
            bool myBool = true;
            
            //Array type
            string[] myFruitsArray = new string[4];

            myFruitsArray[0]="element 1";
            myFruitsArray[1]="element 2";
            // foreach loop
            foreach(var item in myFruitsArray){
                Console.WriteLine(item);
            }
            for(int index = 0; index < myFruitsArray.Length; index++){
                Console.WriteLine(index);
            }
            int[] nums = new int[3];
            nums[0]=1;
            nums[1]=2;
            nums[2]=3;
            //nums[3]=0; outofbounds and there is no storage for this item
            foreach(var item in nums){
                Console.Write(Convert.ToByte(item));
            }
            //using count() versus .Length
            /*
              Count() goes through the elements within the array
              Length goes through all the elements that have been initialized in the array length
              
             */
            for(int i = 0;i <= nums.Count(); i++){
                Console.WriteLine(i);
            }
            //List of type string instance string is an alias
            List<string> fruits = new List<string>(){"Pear","Apple","Grape"};
            //List String refers to the class
            List<String> secondList = new List<String>();


            // Ienumerable  enumerate through collection not indexed
            /* Performance gain on looping through every item over standard loop*/
            // we assign to existing array or collection otherwise 
            // we get an assembly reference
            IEnumerable<string> myFruitsIEnumerable = fruits;     
            
            Console.WriteLine(myFruitsIEnumerable.First());
            Console.WriteLine(myFruitsIEnumerable.Last());
            
            //2-d array array of array
            string[,] twoDimensionalArray = new string[,]{
                {"Pear","Apple"},
                {"Grape","Rasins"}
            };
            Console.WriteLine(twoDimensionalArray[0,1]);

            //Dictionary with key and indexed array
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>(){
                {"Cheese",new string[]{"Dairy", "Milk","Eggs"}}
                          
            };
            Console.WriteLine(dict["Cheese"][1]);
           
        }
    }
}
