namespace Dolgozok.Models;

public partial class Worker
{
    public string Name { get; set; }

    public string Email { get; set; }

    public int Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Email}) - {Salary} Ft";
    }

    public Worker(string name, string email)
    {
        if (String.IsNullOrWhiteSpace(email) ||String.IsNullOrWhiteSpace(name))
        {
            throw new Exception("Nem lehet nulla");
        }
        if (!email.Contains('@'))
        {
            throw new Exception("Kell @ email címbe");
        }
        Name = name;
        Email = email;
        Salary = 0;
    }

    public void Kifizet(int amm)
    {
        if (amm<0)
        {
            throw new Exception("Nem lehet negatív");
        }

        Salary += amm;
    }
}
