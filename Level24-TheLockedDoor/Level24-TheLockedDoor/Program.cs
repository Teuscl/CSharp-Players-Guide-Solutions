string inputedPass = null;
while(string.IsNullOrWhiteSpace(inputedPass))
{
    Console.Write("Enter a passcode to the door: ");
    inputedPass = Console.ReadLine();
}

Door myDoor = new Door(inputedPass);


while (true)
{
    Console.Clear();
    Console.WriteLine($"The door is {myDoor.CurrentState}. What do you want to do? ");
    Console.WriteLine(">Lock\n>Unlock\n>Close\n>Open\n>Change Passcode");
    string userChoice = Console.ReadLine();

    switch (userChoice.ToLower())
    {
        case "change passcode":
            Console.Write("Enter the actual passcode: ");
            string currentPass = Console.ReadLine();
            Console.Write("Enter the new passcode: ");
            string newPass = Console.ReadLine();
            myDoor.ChangePasscode(newPass, currentPass);
            break;
        case "close":
            myDoor.Close();
            break;
        case "lock":
            myDoor.Lock();
            break;
        case "unlock":
            myDoor.Unlock();
            break;
    }
   
   
}

public class Door
{
    public DoorState CurrentState { get; set; }
    private string _passcode;

    public Door(string passcode)
    {
        _passcode = passcode;
        CurrentState = DoorState.Closed;
        Console.WriteLine("Door created!");
    }
    public void Close()
    {
        if (this.CurrentState == DoorState.Open) this.CurrentState = DoorState.Closed;
    }
    public void Open()
    {
        if (this.CurrentState == DoorState.Closed ) this.CurrentState = DoorState.Open; 
    }
    public void Lock()
    {
        if (this.CurrentState == DoorState.Closed) this.CurrentState = DoorState.Locked;
    }
    public void Unlock()
    {
        if (this.CurrentState == DoorState.Locked)
        {
            Console.Write("Enter the passcode to unlock the door: ");
            string inputedPass = Console.ReadLine();

            if (inputedPass != null && inputedPass == this._passcode)
            {
                this.CurrentState = DoorState.Closed;
            }

        }
    }

    public void ChangePasscode(string newPasscode, string currentPasscode)
    {
        if(currentPasscode != _passcode)
        {
            Console.WriteLine("The actual passcode is wrong. Insert the correct one to change!");
            Thread.Sleep(2000);
        }
        _passcode = newPasscode;
        Console.WriteLine("Passcode successfully changed!");
        Thread.Sleep(2000);

    }
}

public enum DoorState { Locked, Open, Closed }