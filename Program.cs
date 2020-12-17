using System;

namespace empentr
{
    public delegate void NewEmployeeEventHandler(object sender, NewEmployeeEventArgs e);

class HR
{
    public event NewEmployeeEventHandler NewEmployee;

    protected virtual void OnNewEmployee(NewEmployeeEventArgs e)
    {
        if (NewEmployee != null)
            NewEmployee(this, e);
    }

    public void RegisterEmployee(string name, string sex, int age)
    {
        NewEmployeeEventArgs e = new NewEmployeeEventArgs(name, sex, age);
        OnNewEmployee(e);
    }
}
public class NewEmployeeEventArgs
{
    public string Name;
    public string Sex;
    public int Age;

    public NewEmployeeEventArgs(string name, string sex, int age)
    {
        Name = name;
        Sex = sex;
        Age = age;
    }
}
class EmployeeCare
{
    public EmployeeCare(HR hr)
    {
        hr.NewEmployee += CallEmployee;
    }

    private void CallEmployee(object sender, NewEmployeeEventArgs e)
    {
        Console.WriteLine("Sender of event: " + sender.ToString());
        Console.WriteLine("Cusomer Info: " + e.Name + 
                          "," + e.Sex + "," + e.Age.ToString());
        //do call Employee stuff
    }
    static void Main(string[] args)
{
    HR hr = new HR(); //line1
    EmployeeCare cc = new EmployeeCare(hr); //line2
    hr.RegisterEmployee("pranathi", "female", 22); //line3
    hr.RegisterEmployee("prana", "female", 22);
    hr.RegisterEmployee("prem", "male", 25);
    Console.ReadLine(); //line4
}
}

}
