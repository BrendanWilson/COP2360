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
        get { return HourlyPayRate; }
        set { hourlyPayRate = value; }

    }

    public Subcontractor(string name, string number, DateTime startDate, int shift, double hourlypayrate)
    :base(name, number, startDate) // New method not inherited from parent class.
    {
        subontractorShift = shift;
        HourlyPayRate = hourlyPayRate;

    }

    // To compute 3% differential pay.
    public float CalculatePay(float hoursWorked)
    {
        double basepay = hoursWorked * hourlyPayRate;
        if (Shift == 2) // Night shift
        {
            basepay = basepay * 1.03; // Night shift differential
        }
        return (float)basepay;
    }

}







//Part 3: The Subcontractor Program