using System;

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Vazov";
        byte age = 134;
        char gender = 'm';
        uint idNumber = 642343297;
        int uniqueEmployeeNumber = 27561200;
        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\ngender: {3}\nID Number: {4}\nUnique Employee Number {5}",firstName,lastName,age,gender,idNumber,uniqueEmployeeNumber);
    }
}

