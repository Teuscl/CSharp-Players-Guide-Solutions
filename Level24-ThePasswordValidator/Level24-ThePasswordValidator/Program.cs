PasswordValidator validator = new PasswordValidator();
while (true)
{
    Console.Clear();
    Console.Write("Enter a password:");
    string? pw = Console.ReadLine();   
    if (validator.AllowedPassword(pw))
    {
        Console.WriteLine("Valid password!");
        Thread.Sleep(1000);
    }
    else
    {
        Console.WriteLine("Invalid password! Try another one.");
        Thread.Sleep(1000);
    }
}



public class PasswordValidator
{
    public bool AllowedPassword(string password) 
    {
        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;

        if (string.IsNullOrEmpty(password)) return false;
        if(password.Length<6 || password.Length>13) return false;
        if(password.Contains('T') || password.Contains('&')) return false;

        foreach (char letter in password) 
        {
            if (char.IsUpper(letter)) hasUpper = true;
            else if (char.IsLower(letter)) hasLower = true;
            else if(char.IsDigit(letter)) hasDigit = true;

        }       

        return hasUpper && hasLower && hasDigit;
    }
}

