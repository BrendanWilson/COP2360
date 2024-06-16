using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Module7Project
{
    class Program
    {
        /*
        Our project creates a simple editable student directory.

        Directory Structure:
            Key  : Student Number (integer)
            Value: A list with this formatting -> Last Name(50 chars max), First Name(25 chars max), Major(50 chars max) 
        
        What can be done to the Directory(dictionary)
            1) Add new students.
            2) Edit current students.
            3) Remove students.
            4) Display current students.
            5) Sort students by their student number.
        */
        static void Main()
        {
            // Creating a student dictionary
            Dictionary<int, List<string>> StudentDictionary = new Dictionary<int, List<string>>();
            // To add new keys and values to the dictionary using the add method. Keys must be unique.
            StudentDictionary.Add(1201, new List<string> { "Williams", "Grace", "Biology" });
            StudentDictionary.Add(1199, new List<string> { "Bennett", "Leslie", "Business Management" });
            StudentDictionary.Add(1202, new List<string> { "Snowson", "Alex", "Communications" });
            StudentDictionary.Add(1198, new List<string> { "Bernard", "John", "Communications" });
            StudentDictionary.Add(1200, new List<string> { "Matos", "Shella", "Electrical Engineering" });

            Console.WriteLine("What would you like to do to the Student Directory.");
            Console.WriteLine(" 1) Add a new student.");
            Console.WriteLine(" 2) Edit a student's information.");
            Console.WriteLine(" 3) Remove a student.");
            Console.WriteLine(" 4) Display current students.");
            Console.WriteLine(" 5) Sort students by their student number.");
            Console.WriteLine(" 0) Done.");
            int choice=GetInputInteger();

            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        // Add new student
                        Console.Write("Stident ID Number ");
                        int studentID = GetInputInteger();
                        break;
                    case 2:
                        // Edit a student's information.
                        Console.Write("Stident ID Number ");
                        int studentID = GetInputInteger();
                        break;
                    case 3:
                        // Remove a student.
                        Console.Write("Stident ID Number ");
                        int studentID = GetInputInteger();
                        break;
                    case 4:
                        /*
                            Display current Student Directory
                            Brought this code up from lower commented out section.
                            .Skip was used as part of a method by LINQ to make this new info the next index number.
                        */
                        Console.Write("Curent student directory:");
                        foreach (var student in StudentDictionary)
                        {
                            int studentID = student.Key;
                            List<string> studentInfo = student.Value;
                            Console.WriteLine($"Student Number: {studentID}, Last Name: {studentInfo[0]}, First Name: {studentInfo[1]}, Major: {studentInfo[2]}");
                            Console.WriteLine("Additional Information: " + string.Join(", ", studentInfo.Skip(3)));
                        }
                        break;
                    case 5:
                        // Sort students by their student number.
                        Console.Write("Sorting Directory(needs to be done).");
                        break;
                    
                }
                Console.WriteLine("What would you like to do to the Student Directory.");
                Console.WriteLine(" 1) Add a new student.");
                Console.WriteLine(" 2) Edit a student's information.");
                Console.WriteLine(" 3) Remove a student.");
                Console.WriteLine(" 4) Display current students.");
                Console.WriteLine(" 5) Sort students by their student number.");
                Console.WriteLine(" 0) Done.");
                int choice=GetInputInteger();
            }

            /*
            TO DO: move all the code below into the proper switch case above

            //To display content from the dictionary use the index operator using the key (student number).
            //Used foreach to iterate through each key value in the dictionary.
            Console.WriteLine("Original Student Dictionary");
            foreach (var student in StudentDictionary)
            {
                int studentID = student.Key;
                List<string> studentInfo = student.Value;
                Console.WriteLine($"Student Number: {studentID}, Last Name: {studentInfo[0]}, First Name: {studentInfo[1]}, Major: {studentInfo[2]}");
            }

            //To remove a key from the dictionary. Then follow through with displaying the updated dictionary.
            StudentDictionary.Remove(1200);
            
            Console.WriteLine("Modified Student Dictionary");
             foreach (var student in StudentDictionary)
            {
                int studentID = student.Key;
                List<string> studentInfo = student.Value;
                Console.WriteLine($"Student Number: {studentID}, Last Name: {studentInfo[0]}, First Name: {studentInfo[1]}, Major: {studentInfo[2]}");
            }

            //To append a value onto an existing key.
            //Then output the modified dictionary.
            //.Skip was used as part of a method by LINQ to make this new info the next index number.
            int KeyToAppend = 1198;
            string NewValue = "Returning Student";

            if (StudentDictionary.ContainsKey(KeyToAppend))
            {
                StudentDictionary[1198].Add(NewValue);
            } 
            Console.WriteLine("Appended Student Dictionary");
             foreach (var student in StudentDictionary)
            {
                int studentID = student.Key;
                List<string> studentInfo = student.Value;
                Console.WriteLine($"Student Number: {studentID}, Last Name: {studentInfo[0]}, First Name: {studentInfo[1]}, Major: {studentInfo[2]}");
                Console.WriteLine("Additional Information: " + string.Join(", ", studentInfo.Skip(3)));
            }

            //To sort the keys in the dictionary.
            */
        }
        // input controls for preventing the input of wrong data types
        int GetInputInteger()
        {
            Console.WriteLine("Enter Number:");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            /*try
            {
                Console.WriteLine("Enter Number:");
                string input = Console.ReadLine();
                int value = int.Parse(input);
            }*/
            return value;
        }
        string GetInputString()
        {
            Console.WriteLine("Enter Number:");
            string input = Console.ReadLine();
            /*try
            {
                Console.WriteLine("Enter Number:");
                string input = Console.ReadLine();
                int value = int.Parse(input);
            }*/
            return input;
        }
    }    
}
//testing