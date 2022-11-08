
/*
Create an Organization "Employee" class that takes the employees name, title and salary as an argument
Define the following methods 
  1 => addSubordinate method which describes the Employee(s) that the current Employee supervises/manages
  2 => numberOfSubordinates method which describes the number of Employee(s) the current Employee supervises/manages
  3 => numberOfPeopleToCEO method which describes the Employee(s) between the current Employee and the CEO
  4 => employeesThatMakeOver method which describes the EMployee(s) that make over a certain defined amount
  5 => return the total number of employees in the company

  VanHack Academy To Everyone
9:18:13 PM VA


("Ada", "CEO", 30000000)
("Craig", "VP Software", 1000000)
("Arvinder", "Chief Design Officer", 1000000)
("Angela", "VP Retail", 1000000)
("Phil", "VP Marketing", 1000000)
("Jane", "Marketing Intern", 200000)
("Fran", "Lead Developer", 6000000)
("Ken", "Frontend Developer", 3000000)
("Guy", "Backend Developer", 3500000)


ada.addSubordinate(craig)
ada.addSubordinate(arvinder)
ada.addSubordinate(angela)
ada.addSubordinate(phil)

phil.addSubordinate(jane)
ada.addSubordinate(fran)

=> who is Craigs' boss?
=> how many subordinates does Ada have?
=> how many people are between Craig and the CEO?
=> how many people are between Jane and the CEO?
=> Number of subordinates Ada has
=> Number of people between Craig and the CEO
=> Number of people between Jane and the CEO
=> Number of employees that earn more than 1000000
=> The total number of employees
=> The total number of employees under craig

*/


/*
 Subordinate
 company
*/

using Console;

// public record Employee(string name, string company,string type,string role, Subordinate subordinate );
// public class Organization
// {
// }

// data & query style implementation.
public static class OrganizationConstants
{
    public static const Ceo = "CEO";
    public static const VpSoftware = "VP Software";
    public static const ChiefDesignOfficer = "Chief Design Officer";
    public static const VPRetail = "VP Retail";
    public static const VPMarketing = "VP Marketing";
    public static const MarketingIntern = "Marketing Intern";
    public static const LeadDeveloper = "Lead Developer";
    public static const FrontendDeveloper = "Frontend Developer";
    public static const BackendDeveloper = "Backend Developer";
}

public class User
{
    public string name {get; set;} 
}

public class Employee
{
    public User user {get; set;}
    public string type {get; set;}       
    public string role {get; set;}
    public string organization {get; set;}
    public Employee? subordinate {get; set;}
}

class Program
{
    void main()
    {
        var employee = new list<Employee>();
        
        // using Higher-Order Functions
        // fill all employes
        employee.add(
            new {"Ada", OrganizationConstants.Ceo, 30000000},
            new {"Craig", OrganizationConstants.VpSoftware, 1000000}
        );

        var ada = employee.Where(x => x.name == "Ada").firstOrDefault();
        ada.subordinate = new {"craig", "CEO", 30000000};

        // find stuff
        // who is Craigs' boss?
        employee.Where(x => x.type == OrganizationConstants.Ceo);

        //how many subordinates does Ada have?
        ada.Where(x => x.subordinate is { });

        //how many people are between Craig and the CEO?
        WriteLine(employee.Where(x => x.name == "Craig" && 
                                (x.type != OrganizationConstants.Ceo && x.type != OrganizationConstants.VpSoftware ))
                    .firstOrDefault());

        // how many people are between Jane and the CEO?
        employee.Where(x => x.name == "Jane") 
    }
    
}

/*

    

*/