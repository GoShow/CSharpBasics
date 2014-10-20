using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
//IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single 
//bank account using the appropriate data types and descriptive names.
class Data
{
    static void Main()
    {
        string firstName = "Todor";
        string middleName = "Todorov";
        string lastName = "Todorodorov";
        decimal balance = 618000;
        string bankName = "Unicredit Bulbank";
        string iban = "BG72UNCR7685756565545525";
        string bic = "UNCRBGVT";
        long creditCardNumber1 = 1234666666666666;
        long creditCardNumber2 = 2345666666666666;
        long creditCardNumber3 = 3456666666666666;
        Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast Name: {2}\nBalance: {3}lv\n{4}\nIBAN: {5}\nBIC: {6}\nCard Number 1: {7}\nCard Number 2: {8}\nCard Number 3: {9}",firstName,middleName,lastName,balance,bankName,iban,bic,creditCardNumber1,creditCardNumber2,creditCardNumber3);

    }
}