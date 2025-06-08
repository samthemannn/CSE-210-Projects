class Person
{
    private string _firstName; // Corrected casing to _firstName
    private string _lastName;  // Corrected casing to _lastName
    private int _age;

    // Default constructor
    public Person()
    {
        _firstName = "";
        _lastName = "";
        _age = 0;
    }

    // Parameterized constructor
    public Person(string firstName, string lastName, int age) // Changed parameter names
    {
        _firstName = firstName; // Assign parameter to field
        _lastName = lastName;   // Assign parameter to field
        _age = age;             // Assign parameter to field
    }

    // Method to get basic person information
    public virtual string GetPersonInformation() // Added 'virtual' to allow overriding
    {
        return $"Name: {_firstName} {_lastName}, Age: {_age}";
    }
}
