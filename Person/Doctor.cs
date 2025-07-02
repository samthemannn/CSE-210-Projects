

class Doctor : Person
{
    private string _tools;
    private double _salary;


    public Doctor(string firstName, string lastName, int age, string tools, double salary) 
        : base(firstName, lastName, age)
    {
        _tools = tools;
    }


    public string GetDoctorInformation()
    {
        return $"{base.GetPersonInformation()} :: Tools: {_tools}";
    }
    public override string GetPersonInformation()
    {
        return $"I am a Doctor: Tools: {_tools} :: {base.GetPersonInformation()}";
    }

    public override double Getpay()
    {
        return _salary / 12;
    }
}
