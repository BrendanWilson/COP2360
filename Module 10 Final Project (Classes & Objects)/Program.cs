using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Part 1: Contractor Class
public class Contractor
{
    // Control access to properties.
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


// Constructor of the Contractor class to give name, number
// and start date.
    public Contractor(string name, string number, DateTime startDate)
    {
        contractorname = name;
        contractornumber = number;
        contractorstartdate = startDate;

    }
}

// Part 2: The Derived Subcontractor Class using inheritance

public class Subcontractor : Contractor
{
    public static int Shift;
    public static double HourlyPayRate;







//Part 3: The Subcontractor Program