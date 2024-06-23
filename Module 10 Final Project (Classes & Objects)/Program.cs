using System;


// Part 1: Contractor Class
public class Contractor
{
    // Control access to properties. Private to the Contractor
    // class.
    private string contractorName;
    private string contractorNumber;
    private DateTime contractorStartDate;

    // Setting ContractorName, ContractorNumber and
    // ContractorStartDate to public.
    public string ContractorName
    {
        get { return contractorName; }
        set { contractorName = value; }

    }

    public string ContractorNumber
    {
        get { return contractorNumber; }
        set { contractorNumber = value; }

    }

    public DateTime ContractorStartDate
    {
        get { return contractorStartDate; }
        set { contractorStartDate = value; }
    }


// Constructor with parameters of the Contractor class to give name, number
// and start date.
    public Contractor(string name, string number, DateTime startDate)
    {
        ContractorName = name;
        ContractorNumber = number;
        ContractorStartDate = startDate;

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

    public Subcontractor(string name, string number, DateTime startDate, int shift, double hourlyPayRate)
    :base(name, number, startDate) // New method not inherited from parent class.
    {
        subontractorShift = shift;
        HourlyPayRate = hourlyPayRate;
        // hourpayrate testing to fix problem
    }

    // To compute 3% differential pay.
    public float CalculatePay(float hoursWorked)
    {
        double basePay = hoursWorked * hourlyPayRate;
        if (Shift == 2) // Night shift
        {
            basePay = basePay * 1.03; // Night shift differential
        }
        return (float)basePay;
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
            Console.WriteLine($"\nName: {subcontractor.ContractorName}");
            Console.WriteLine($"Number: {subcontractor.ContractorNumber}");
            Console.WriteLine($"Start Date: {subcontractor.ContractorStartDate:yyyy-MM-dd}");
            Console.WriteLine($"Shift: {subcontractor.Shift}");
            Console.WriteLine($"Hourly Pay Rate: ${subcontractor.HourlyPayRate:F2}");

        // Compute pay
        float hoursWorked = 12;
        float basepay = subcontractor.CalculatePay(hoursWorked);
        Console.WriteLine($"Pay for {hoursWorked} hours worked: ${basepay:F2}");
    }
}
}