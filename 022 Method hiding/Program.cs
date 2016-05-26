using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    string FirstName;
    string Lastname;
    string Email;

    public void printFullName()
    {
        //
    }

}
public class FullTimeEmployee : Employee
{
    /*this will hide the class employee printFullName method. note the new keyword*/
    public new void printFullName()
    {
        /*this will expicitly call the class employee printFullName method*/
        base.printFullName();
    }

}
class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        /*you can cast like here too to get FTE behave like an emplyee class*/
        ((Employee)FTE).printFullName();

        /*another method, you can change the object method like this*/
        Employee ETE = new FullTimeEmployee();
        ETE.printFullName();

    }
}

