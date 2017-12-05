using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Problem3
    {
        static void Main( string[] args )
        {
            {
                Console.WriteLine( "################################" );
                Console.WriteLine( "WELCOME TO THE DBS CONSOLE" );
                Console.WriteLine( "###################################" );

                //declaration of variables

                int i;
                string[] movies;

                //initialising array
                movies = new string[5];

                //prompt the user for no of students' names to store
                for ( i = 0; i < movies.Length; i++ )
                {
                    Console.Write( "Enter movie name: ", ( i + 1 ), movies[i] );
                    movies[i] = Console.ReadLine( );

                    //if string is equal to exit end loop
                    if ( movies[i] == "exit" )
                    {
                        break;
                    }
                }

                //displaying all elements of array
                for ( i = 0; i < movies.Length; i++ )
                {
                    if ( string.IsNullOrEmpty( movies[i] ) || movies[i] == "exit" )  //if string is blank or equal to exit end loop
                    {
                        break;
                    }

                    Console.WriteLine( string.Format( "Movie {0} is {1}" , ( i + 1 ), movies[i] ) );
                }

                //you can 'start without debugging' (ctrl + F5)
                //you won't need the readline
                Console.ReadLine( );
            }
        }
    }
}
