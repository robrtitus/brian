using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Problem2
    {
        static void Main( string[] args )
        {

            {

                //https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-8.php 
                
                // You are statically using the number 5 for these arrays
                // while also asking the user the length of your array
                // try to change your code to take the input from the below "ReadLine" command
                // to be the length of your initial arrays
                
                int[] arr1 = new int[5];
                int[] fr1 = new int[5];
                int n, i, j, ctr;

                Console.WriteLine( "#######################################" );
                Console.WriteLine( "WELCOME TO THE DBS CONSOLE" );
                Console.WriteLine( "#######################################" );

                Console.Write( "\n\nCount the frequency of each element of an array:\n" );
                Console.Write( "----------------------------------------------------\n" );

                Console.Write( "Input the number of elements to be stored in the array :" );
                n = Convert.ToInt32( Console.ReadLine( ) );

                Console.Write( "Input {0} elements in the array :\n", n );
                for ( i = 0; i < n; i++ )
                {
                    Console.Write( "element - {0} : ", i );
                    arr1[i] = Convert.ToInt32( Console.ReadLine( ) );
                    fr1[i] = -1;
                }
                for ( i = 0; i < n; i++ )
                {
                    ctr = 1;
                    for ( j = i + 1; j < n; j++ )
                    {
                        if ( arr1[i] == arr1[j] )
                        {
                            ctr++;
                            fr1[j] = 0;
                        }
                    }

                    if ( fr1[i] != 0 )
                    {
                        fr1[i] = ctr;
                    }
                }
                Console.Write( "\nThe frequency of all elements of the array : \n" );
                for ( i = 0; i < n; i++ )
                {
                    if ( fr1[i] != 0 )
                    {
                        Console.Write( "{0} occurs {1} times\n", arr1[i], fr1[i] );
                    }
                }
            }


            Console.ReadLine( );

        }
    }
}
