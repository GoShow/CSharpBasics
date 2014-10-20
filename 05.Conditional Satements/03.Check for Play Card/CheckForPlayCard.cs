using System;

//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("Enter a symbol to check if it's a play card: ");
        string input = Console.ReadLine();
        string isCard = "";

        switch (input)
        {
            case "2":
                isCard = "Yes";
                break;
            case "3":
                isCard = "Yes";
                break;
            case "4":
                isCard = "Yes";
                break;
            case "5":
                isCard = "Yes";
                break;
            case "6":
                isCard = "Yes";
                break;
            case "7":
                isCard = "Yes";
                break;
            case "8":
                isCard = "Yes";
                break;
            case "9":
                isCard = "Yes";
                break;
            case "10":
                isCard = "Yes";
                break;
            case "J":
                isCard = "Yes";
                break;
            case "Q":
                isCard = "Yes";
                break;
            case "K":
                isCard = "Yes";
                break;
            case "A":
                isCard = "Yes";
                break;
            default:
                isCard = "No";
                break;
        }

        Console.WriteLine(isCard);
    }
}

