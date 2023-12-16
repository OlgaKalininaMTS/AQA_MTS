namespace Collections;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //public int Age { get; set; }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, LastName);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person otherPerson = (Person)obj;
        return FirstName == otherPerson.FirstName && LastName == otherPerson.LastName;
    }
}