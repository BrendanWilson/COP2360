using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Part 1: Contractor Class
public class Contractor
{
    // Control access to properties. Private to the Contractor
    // class.
    private string ContractorName;
    private string ContractorNumber;
    private DateTime ContractorStartDate;

    // Setting ContractorName, ContractorNumber and
    // ContractorStartDate to public.
    public string contractorname
    {
        get { return ContractorName; }
        set { ContractorName = value; }

    }

    public string contractornumber
    {
        get { return ContractorNumber; }
        set { ContractorNumber = value; }

    }

    public DateTime contractorstartdate
    {
        get { return ContractorStartDate; }
        set { ContractorStartDate = value; }
    }


// Constructor with parameters of the Contractor class to give name, number
// and start date.
    public Contractor(string name, string number, DateTime startDate)
    {
        contractorname = name;
        contractornumber = number;
        contractorstartdate = startDate;

    }
}

// Part 2: The Derived Subcontractor Class using inheritance

public class Subcontractor : Contractor // All fields, properties, and methods
// are inherited from the parent class

// Declaring new fields for the child class.
{
    private int subontractorShift;
    private double hourlyPayRate;
    

    public int Shift
    {
        get { return subontractorShift; }
        set { subontractorShift = value; }

    }

    public double HourlyPayRate
    {
        get { return hourlyPayRate; }
        set { hourlyPayRate = value; }

    }

    public Subcontractor(string name, string number, DateTime startDate, int shift, double hourlypayrate)
    :base(name, number, startDate) // New method not inherited from parent class.
    {
        subontractorShift = shift;
        HourlyPayRate = HourlyPayRate;

    }

    // To compute 3% differential pay.
    public float CalculatePay(float hoursWorked)
    {
        double basepay = hoursWorked * HourlyPayRate;
        if (Shift == 2) // Night shift
        {
            basepay = basepay * 1.03; // Night shift differential
        }
        return (float)basepay;
    }

}

//Part 3: The Subcontractor Program

public class Program
{
    public static void Main()
    {
        // Prompt user to enter number of subcontractors
        Console.Write("Enter the number of subcontractors: ");
        int numSubcontractors = int.Parse(Console.ReadLine());

        // Create an array to store subcontractors
        Subcontractor[] subcontractors = new Subcontractor[numSubcontractors];

        // Input subcontractor details
        for (int i = 0; i < numSubcontractors; i++)
        {
            Console.WriteLine($"\nSubcontractor {i + 1}:");
            Console.Write("Subcontractor Name: ");
            string name = Console.ReadLine();
            Console.Write("Subcontractor Number: ");
            string number = Console.ReadLine();
            Console.Write("Start Date (YYYY-MM-DD): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Shift (1) day or (2) night): ");
            int shift = int.Parse(Console.ReadLine());
            Console.Write("Hourly Pay Rate: $");
            double hourlyPayRate = double.Parse(Console.ReadLine());

            subcontractors[i] = new Subcontractor(name, number, startDate, shift, hourlyPayRate);
        }

        // Display subcontractor information and compute pay
        Console.WriteLine("\nSubcontractors Information:");
        foreach (var subcontractor in subcontractors)
        {
            Console.WriteLine($"\nName: {subcontractor.contractorname}");
            Console.WriteLine($"Number: {subcontractor.contractornumber}");
            Console.WriteLine($"Start Date: {subcontractor.contractorstartdate:yyyy-MM-dd}");
            Console.WriteLine($"Shift: {subcontractor.Shift}");
            Console.WriteLine($"Hourly Pay Rate: ${subcontractor.HourlyPayRate}");

        // Compute pay
        float hoursWorked = 12;
        float basepay = subcontractor.CalculatePay(hoursWorked);
        Console.WriteLine($"Pay for {hoursWorked} hours worked: ${basepay:F2}");
    }
}
}