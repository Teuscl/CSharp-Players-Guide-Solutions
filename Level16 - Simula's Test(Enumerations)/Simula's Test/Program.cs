//Minha solução

//State currentState = State.Locked;
//String userChoice;

//while (true)
//{
//    switch (currentState)
//    {
//        case State.Locked:
//            Console.Write("The chest is locked. What do you want to do? ");
//            userChoice = Console.ReadLine();
//            if (userChoice.ToLower() == "unlock")
//            {
//                currentState = State.Closed;
//            }            
//            break;

//        case State.Closed:
//            Console.Write("The chest is unlocked. What do you want to do? ");
//            userChoice = Console.ReadLine();
//            if (userChoice.ToLower() == "open")
//            {
//                currentState = State.Open;
//            }
//            else if(userChoice.ToLower() == "lock")
//            {
//                currentState = State.Locked;
//            }            
//            break;

//        case State.Open:
//            Console.Write("The chest is open. What do you want to do? ");
//            userChoice = Console.ReadLine();
//            if (userChoice.ToLower() == "close")
//            {
//                currentState = State.Closed;
//            }
//            else { Console.WriteLine("Invalid option!"); }
//            break;

//        default: 
//            break;

//    }
//}

//enum State { Open, Closed, Locked };

//Solução legivel do livro

State currentState = State.Locked;
String userChoice;



while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    userChoice = Console.ReadLine();

    if ( currentState == State.Locked && userChoice == "unlock") { currentState = State.Closed; }
    if ( currentState == State.Closed && userChoice == "open") { currentState = State.Open; }
    if ( currentState == State.Open && userChoice == "close") { currentState = State.Closed; }
    if ( currentState == State.Closed && userChoice == "lock") { currentState = State.Locked; }


}

enum State { Open, Closed, Locked };