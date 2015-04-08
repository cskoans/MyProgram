using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            String lastName;
            DateTime birthDate;
            String address1;
            String address2;
            String city;
            String state;
            String zip;
            String country;

            String profFirstName;
            String profLastName;

            String degree;

            String programName;
            String programDegree;
            String programHead;

            firstName = "Calvin";
            lastName = "Cheng";
            birthDate = new DateTime(1976, 1, 1);
            address1 = "3 Woodhaven";
            address2 = "01-01";
            city = "Singapore";
            state = "Singapore";
            zip = "293293";
            country = "Singapore";

            profFirstName = "Min Yan";
            profLastName = "Kan";

            degree = "Ph. D";

            programName = "Computer Science";
            programDegree = "Bachelor's";
            programHead = "Dr Leong";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthDate);
            Console.WriteLine(address1);
            Console.WriteLine(address2);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(zip);
            Console.WriteLine(country);
            Console.WriteLine(profFirstName);
            Console.WriteLine(profLastName);
            Console.WriteLine(degree);
            Console.WriteLine(programName);
            Console.WriteLine(programDegree);
            Console.WriteLine(programHead);
        }
    }
}
