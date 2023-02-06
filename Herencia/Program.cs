
//========= HERENCIA ===============
// Sin una clase puedes heredar las caracetristicas de otra clase.
// Ayuda a no reescrbir mucho codigo.
// =================================

using System.Reflection.Metadata.Ecma335;

Doctor doctor = new Doctor("fernando", 20, "Nutriologia");
Console.WriteLine(doctor.GetData());

Developer dev = new Developer("Jesus", 22, "Javascript");
Console.WriteLine(dev.GetData());

Teacher teacher = new Teacher("Rosa", 45, new string[] { "Math", "English", "C.N." });
Console.WriteLine(teacher.GetSubjects());

class Person 
{
    //* Cuando un atributo sea privado normalmente se pone con _atributo.
    private string _name;
    private int _age;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public string GetInfo() { return _name + ' ' + _age; }
}

class Doctor : Person 
{
    private string _speciality;
    // con base() le pasamos los parametros (name, age) a la clase padre(Person)
    public Doctor(string name, int age,string speciality) : base(name, age)
    {
        _speciality = speciality;
    }
    public string GetData()
    {
        return GetInfo() + " " + _speciality;
    }
}

class Developer : Person 
{
    private string _language;
    public Developer(string name, int age, string language) : base(name, age)
    {
        _language = language;
    }

    public string GetData() 
    { 
        return GetInfo() + " " + _language;
    }
}

class Teacher : Person
{
    private string[] _subjects;
    public string[] Subjects { get { return _subjects; } set { _subjects = value; } }

    public Teacher(string name, int age, string[] subjects) : base(name, age)
    {
        _subjects = subjects;
    }

    public string[] GetSubjects() 
    {
        return Subjects;    
    }
}