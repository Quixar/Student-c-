using System;

namespace student;

class Student
{
    string name;
    string surname;
    string middlename;
    string address;
    string phone;

    DateTime birthday;

    List<int> homeworks;
    List<int> courseworks;
    List<int> exams;

    public Student() : this("Name", "Surname", "Middlename", "Bucharest",
        "+40792883327", new DateTime(2006, 07, 17))
    {

    }

    public Student(string name, string surname, string middlename)
        : this(name, surname, middlename, "Bucharest", "+40792883327", new DateTime(2006,07,17))
    {

    }

    public Student(string name, string surname, string middlename,
        string address, string phone, DateTime birthday)
    {
        SetName(name);
        SetSurname(surname);
        SetMiddleName(middlename);
        SetAddress(address);
        SetPhone(phone);
        SetBirthday(birthday);

        homeworks = new List<int>();
        courseworks = new List<int>();
        exams = new List<int>();
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetSurname(string surname)
    {
        this.surname = surname;
    }

    public void SetMiddleName(string middlename)
    {
        this.middlename = middlename;
    }

    public void SetBirthday(DateTime birthday)
    {
        this.birthday = birthday;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public void SetPhone(string phone)
    {
        this.phone = phone;
    }

    public string GetName()
    {
        return name;
    }

    public string GetSurname()
    {
        return surname;
    }

    public string GetMiddleName()
    {
        return middlename;
    }

    public string GetAddress()
    {
        return address;
    }

    public string GetPhone()
    {
        return phone;
    }

    public DateTime GetBirthday()
    {
        return birthday;
    }

    public void Show()
    {
        Console.WriteLine(GetSurname());
        Console.WriteLine(GetName());
        Console.WriteLine(GetMiddleName());
        Console.WriteLine(GetAddress());
        Console.WriteLine(GetPhone());
        Console.WriteLine(GetBirthday());
        Console.WriteLine("Homework grades: " + string.Join(", ", homeworks));
        Console.WriteLine("Coursework grades: " + string.Join(", ", courseworks));
        Console.WriteLine("Exam grades: " + string.Join(", ", exams));
    }

    public void AddHw(int grade)
    {
        homeworks.Add(grade);
    }

    public void AddCourse(int grade)
    {
        courseworks.Add(grade);
    }

    public void AddExaxm(int grade)
    {
        exams.Add(grade);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.AddHw(12);
        s.AddHw(12);
        s.AddHw(12);
        s.AddCourse(12);
        s.AddExaxm(12);
        s.Show();

        Student s2 = new Student("Eugene", "Martynov", "Vladimirovich");
        s2.Show();

        Student s3 = new Student("Eugene", "Martynov", "Vladimirovich", "Odessa", "+3801234124", new DateTime(2000, 01, 01));
        s3.Show();
    }
}

