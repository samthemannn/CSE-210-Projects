using System.Reflection.Metadata.Ecma335;

abstract class Person
{
    private string _lastName;
    private string _firstName;
    private int _age;

    public Person()
    {
        _lastName = "";
        _firstName = "";
        _age = 0;
    }

    public Person(string lastName, string firstName, int age)
    {
        _lastName = lastName;
        _firstName = firstName;
        _age = age;
    }

    public virtual string GetPersonInformation()
    {
        return $"{_firstName} {_lastName}, Age: {_age}";
    }

    public abstract double Getpay();
        

}