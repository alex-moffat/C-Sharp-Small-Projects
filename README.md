# C-Sharp-Small-Projects

## DESCRIPTION
These are very small projects designed to provide examples of basic coding concepts and commenting. Most examples were completed in less than 2 hours.    

## CONTENTS
- [Arrays and Lists](#arrays-and-lists)
- [Basic Console App](#basic-console-app)
- [Boolean Logic](#boolean-logic)
- [Branch shipping cost estimator](#branching-program)
- [Class_Demo](#class-demo)

## Arrays and Lists

### Commit
- Create a one-dimensional Array of strings.
- Ask the user to select an index of the Array and then display the string at that index on the screen.
- Create a one-dimensional Array of integers.
- Ask the user to select an index of the Array and then display the integer at that index on the screen.
- Create a List of strings.
- Ask the user to select an index of the List and then display the content at that index on the screen.
- Add a message that displays when the user selects an index that doesn’t exist.

### Output
![alt text](https://github.com/alex-moffat/C-Sharp-Small-Projects/blob/master/Arrays_Lists/Screenshot_Arrays_Lists.jpg "Arrays_Lists")

### Code
```CS
static void Main()
{
    //===== VARIABLES
    int[] presTerms = { 1969, 1974, 1977, 1981, 1989, 1993, 2001, 2009, 2017 };
    string[] presNames = { "Richard Nixon", "Gerald Ford", "Jimmy Carter", "Ronald Reagan", "George H. W. Bush", "Bill Clinton", "George W. Bush", "Barack Obama", "Donald Trump" };
    List<string> poem = new List<string>();
    string[] stanza2 = { "A row can be identified by it,", "a telephone number of kind.", "A fine way to get data I admit,", "the correct data it will find." };
    string[] stanza3 = { "A primary key must never be null,", "it's there so it must be legit.", "A modest integer field might seem dull,", "but I don't see a better fit." };
    //===== ADD - lines to list
    poem.Add("A table can have one primary key,");
    poem.Add("it should be unique for each row.");
    poem.Add("On one or many columns it might be,");
    poem.Add("two a composite key you know.");
    foreach (string i in stanza2)
    {
        poem.Add(i);
    }
    foreach (string i in stanza3)
    {
        poem.Add(i);
    }

    //===== INPUT - pick string list item
    int index;
    bool isValid = false;
    while (!isValid)
    {
        Console.WriteLine("Please select a line number from the PRIMARY KEYS poem:");
        index = Convert.ToInt32(Console.ReadLine()) - 1;
        if (index >= 0 && index < poem.Count)
        {
            Console.WriteLine(poem[index]);
            isValid = true;
        }
        else
        {
            Console.WriteLine("Your selection is out of range. Please select line number 1 to {0}.", poem.Count);
        }
    }

    //===== INPUT - pick string array item
    isValid = false;
    while (!isValid)
    {
        Console.WriteLine("Please select a line number from second stanza of the poem PRIMARY KEYS");
        index = Convert.ToInt32(Console.ReadLine()) - 1;
        if (index >= 0 && index < stanza2.Length)
        {
            Console.WriteLine(stanza2[index]);
            isValid = true;
        }
        else
        {
            Console.WriteLine("Your selection is out of range. Please select line number 1 to {0}.", stanza2.Length);
        }
    }

    //===== INPUT - pick string array item
    isValid = false;
    while (!isValid)
    {
        Console.WriteLine("Select a number from the last nine presidents to find out term start and name:");
        index = Convert.ToInt32(Console.ReadLine()) - 1;
        if (index >= 0 && index < presTerms.Length)
        {
            Console.WriteLine("President {0} started his presidency in {1}.", presNames[index], presTerms[index]);
            isValid = true;
        }
        else
        {
            Console.WriteLine("Your selection is out of range. Please select line number 1 to {0}.", presTerms.Length);
        }
    }

    //=============== EXAMPLES ===============

    ////========== ARRAYS - three ways to instantiate an array, FIXED predefined length, all the same datatype stored at each index
    //int[] numArray = new int[5];
    //numArray[0] = 5;
    //numArray[1] = 2;
    //numArray[2] = 10;
    //numArray[3] = 200;
    //numArray[4] = 5000;

    //ushort[] numArray2 = { 5, 2, 10, 200, 5000 };
    //short[] numArray3 = new short[] { 5, 2, 10, 200, 5000 };
    ////----- change an item in an array
    //numArray3[4] = 112; 
    ////----- print objects to screen
    //Console.WriteLine(numArray);
    //Console.WriteLine(numArray2);
    //Console.WriteLine(numArray3);
    ////----- print objects to screen
    //Console.WriteLine(numArray[3]);
    //Console.WriteLine(String.Format("{0}, {1}", numArray2[3], numArray2[4]));
    //Console.WriteLine(String.Format("{0}, {1}", numArray3[3], numArray3[4]));

    ////========== LISTS - three ways to instantiate a list, NO predefined length, still same datatype at each index
    //List<int> intList = new List<int>();
    //intList.Add(4);
    //intList.Add(4);
    //intList.Add(10);
    //intList.Add(4);
    //Console.WriteLine(String.Format("{0}, {1}, {2}, {3}", intList[0], intList[1], intList[2], intList[3]));
    //intList.Remove(4); // removes first instance of value in the list
    //Console.WriteLine(String.Format("{0}, {1}, {2}", intList[0], intList[1], intList[2]));
    //intList.Remove(4);
    //Console.WriteLine(String.Format("{0}, {1}", intList[0], intList[1]));
    //intList.Remove(4);
    //Console.WriteLine(String.Format("{0}", intList[0]));


    //===== HOLD OPEN - till enter is pressed
    Console.ReadLine();
}
  ```
 
## Basic Console App

### Commit
Create multiple Loops with lists and arrays:
- Create a one-dimensional Array of strings.
- Ask the user to input text.
- Create a loop that goes through each string in the Array, adding the user’s text to the string.
- Create a loop that prints off each string in the Array on a separate line.
- Create and fix an infinite loop.
- Determine whether to continue iterating the loop uses “<” operator.
- Determine whether to continue iterating the loop uses “<=” operator.
- Create a List of strings where each item in the list is unique.
- Ask the user to input text to search for in the List.
- Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
- Stop loop from executing once a match has been found.
- Create a list of strings that has at least two identical strings in the List.
- Display the indices of the array that contain matching text on the screen.
- Add feedback to user if entered text not in a list.
- Ask user if they want to try to match to list again.
- Create a foreach loop that evaluates each item in a string list, and displays a message showing the string and if it has already appeared in the list.

### Output
![alt text](https://github.com/alex-moffat/C-Sharp-Small-Projects/blob/master/Basic_Console_App1/Screenshot_console_app.jpg "Basic_Console_App")

### Code
```CS
static void Main(string[] args)
{
    //===== ARRAY - movies
    Console.WriteLine("===== ARRAY");
    string[] movies = { "Black Panther (2018)", "Avengers: Endgame (2019)", "Us (2019)", "Toy Story 4 (2019)", "The Wizard of Oz (1939)", "Mission: Impossible - Fallout (2018)", "Lady Bird (2017)", "Citizen Kane (1941)", "The Irishman (2019)", "BlacKkKlansman (2018)" };
    //===== USER INPUT
    Console.WriteLine("Please enter some text to be added to a list of movies:");
    string userText = Console.ReadLine();
    //===== ITERATIONS - add user input to each item in array, print each item in array on seperate line
    for (int i=0; i < movies.Length; i++)
    {
        movies[i] = movies[i] + userText;
    }
    foreach (string m in movies)
    {
        Console.WriteLine(m);
    }
    //===== INFINITE LOOPS
    Console.WriteLine("\n===== LOOPS");
    bool fix = false;
    int loopCount = 0;
    while (!fix)
    {
        if (loopCount < int.MaxValue/100000000)
        {
            loopCount++;
            Console.WriteLine("Infinite loop on loop number: " + loopCount);                    
        }
        else
        {
            fix = true;
            Console.WriteLine("Applied fix: Infinite loop stopped at {0} loops", loopCount);
        }                
    }
    fix = false;
    loopCount = 0;
    while (!fix)
    {
        if (loopCount <= int.MaxValue / 100000000)
        {
            loopCount++;
            Console.WriteLine("Infinite loop on loop number: " + loopCount);
        }
        else
        {
            fix = true;
            Console.WriteLine("Applied fix: Infinite loop stopped at {0} loops", loopCount);
        }
    }

    //===== LIST - pets
    Console.WriteLine("\n===== LIST - pets");
    //--- variables
    bool onList;
    bool valid = false;
    string cont, userSelect;
    List<string> pets = new List<string>() { "Albert", "Zuli", "Barbus", "Plurp", "Peep", "Nug", "Pillar", "Batman", "Papaya", "Supreme", "Gucci" };
    //--- Print pet list
    Console.WriteLine("\nMOFFAT FAMILY FARM:");
    foreach (string p in pets)
    {
        Console.WriteLine(p);
    }
    //--- get user input
    while (!valid)
    {
        Console.WriteLine("\nSelect a pet name to print the index of:");
        userSelect = Console.ReadLine().ToLower();
        //--- check user selection in list using Exists method
        onList = pets.Exists(x => x.ToLower() == userSelect);
        if (onList) //--- print index of user select
        {
            valid = true;
            for (int i = 0; i < pets.Count; i++)
            {
                if (userSelect == pets[i].ToLower())
                {
                    Console.WriteLine("The index of name you selected is " + i);
                    break;
                }
            }
        }
        else //--- user selection not in list, check if user wants to try again
        {
            Console.WriteLine("You did not pick a pet name from the Moffat Family Farm");
            Console.WriteLine("Do you want to try again (y/n)?");
            cont = Console.ReadLine().ToLower();
            if (cont == "n" || cont == "no") { valid = true; }
        }                       
    }

    //===== LIST - words
    Console.WriteLine("\n===== LIST - words");
    //--- variables
    List<string> words = new List<string>() { "tree", "house", "bush", "grass", "house", "tree", "lake", "stream", "pond", "mountain", "road", "bush", "stream", "river", "lake", "house" };
    List<string> dupWords = new List<string>();
    StringBuilder indices = new StringBuilder();
    //--- iterate through list, find duplicates on list, create printable list
    StringBuilder wordsDisplay = new StringBuilder("[");
    foreach (string w in words)
    {
        wordsDisplay.Append(" " + w + ",");
        if (dupWords.Exists(x => x == w))
        {
            Console.WriteLine(w + " has already appeared in the list");
        }
        else
        {
            dupWords.Add(w);
            Console.WriteLine(w + " has NOT appeared in the list before");
        }
    }
    wordsDisplay.Length = (wordsDisplay.Length - 1);
    wordsDisplay.Append(" ]");
    Console.WriteLine("\nWORDS LIST:\n" + wordsDisplay);
    //--- get user input 
    valid = false;
    while (!valid)
    {
        Console.WriteLine("\nSelect a word from the list to print the indices of occurance:");
        userSelect = Console.ReadLine().ToLower();
        //--- check user selection in list using Exists method
        onList = words.Exists(x => x.ToLower() == userSelect);
        if (onList) //--- print indices of user selection
        {
            valid = true;
            for (int i = 0; i < words.Count; i++)
            {
                if (userSelect == words[i].ToLower())
                {
                    indices.Append(i + ", ");                            
                }
            }
            indices.Length = (indices.Length - 2);
            Console.WriteLine("The word \"{0}\" occurs in the list at index: {1}", userSelect, indices);
        }
        else //--- user selection not in list, check if user wants to try again
        {
            Console.WriteLine("You did not pick a word from the list.");
            Console.WriteLine("Do you want to try again (y/n)?");
            cont = Console.ReadLine().ToLower();
            if (cont == "n" || cont == "no") { valid = true; }
        }
    }

    //===== HOLD OPEN - till enter is pressed
    Console.ReadLine();
}
```

## Boolean Logic

### Commit
- Car insurance approval program
- Take age, DUI, number of tickets input
- Apply business logic
- Print approval true/false

### Code
```CS
static void Main()
{
    //===== INPUTS
    Console.WriteLine("=== Car Insurance Approval Check ===");
    Console.WriteLine("What is your age?");
    ushort iAge = Convert.ToUInt16(Console.ReadLine());
    Console.WriteLine("Have you ever had a DUI (true/false)?");
    bool iDUI = Convert.ToBoolean(Console.ReadLine());
    Console.WriteLine("How many speeding tickets do you have?");
    ushort iTickets = Convert.ToUInt16(Console.ReadLine());
    //===== DECISION
    Console.WriteLine("Qualified?\n{0}", (iAge>15 && iDUI != true && iTickets <= 3));

    //========== EXAMPLES
    //Console.WriteLine("===== Boolean AND");
    //Console.WriteLine(false && false);
    //Console.WriteLine(true && false);
    //Console.WriteLine(false && true);
    //Console.WriteLine(true && true);
    //Console.WriteLine("===== Boolean OR");
    //Console.WriteLine(false || false);
    //Console.WriteLine(true || false);
    //Console.WriteLine(false || true);
    //Console.WriteLine(true || true);
    //Console.WriteLine("===== Boolean ==");
    //Console.WriteLine(false == false);
    //Console.WriteLine(true == false);
    //Console.WriteLine(false == true);
    //Console.WriteLine(true == true);
    //Console.WriteLine("===== Boolean !=");
    //Console.WriteLine(false != false);
    //Console.WriteLine(true != false);
    //Console.WriteLine(false != true);
    //Console.WriteLine(true != true);
    //// evaluates to true if one or the other are true but not both
    //Console.WriteLine("===== Boolean ^");
    //Console.WriteLine(false ^ false);
    //Console.WriteLine(true ^ false);
    //Console.WriteLine(false ^ true);
    //Console.WriteLine(true ^ true);
    //Console.WriteLine("===== Boolean multiples on one line");
    //Console.WriteLine(false || true && true);
    //Console.WriteLine(false || true ^ false);
    //Console.WriteLine(false && false ^ true);
    //Console.WriteLine(true && true && true || false);

    //===== HOLD OPEN - till enter is pressed
    Console.ReadLine();
}
```

## Branching Program

### Commit
Create Shipping Estimate program:
- Display Header
- Take user input weight, height, width, length
- Check against weight limit
- Check against size limit
- Display shipping cost estimate

### Output
![alt text](https://github.com/alex-moffat/C-Sharp-Small-Projects/blob/master/Branching/Screenshot_branching.jpg "Branching_Program")

### Code
```CS
static void Main(string[] args)
{
    //===== GREETING
    Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
    //===== INPUTS
    Console.WriteLine("Please enter the package weight:");
    float iWeight = float.Parse(Console.ReadLine());
    if (iWeight > 50) //===== OVER WEIGHT TEST
    {
        Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    }
    else
    {
        Console.WriteLine("Please enter package width:");
        float iWidth = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter package height:");
        float iHeight = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter package length:");
        float iLength = float.Parse(Console.ReadLine());
        if (iWidth + iHeight + iLength > 50) //===== OVER DIMENSION TEST
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
        }
        else //===== TOTAL DISPLAY
        {
            float total = (iWidth * iHeight * iLength * iWeight) / 100;
            Console.WriteLine("\nYour estimated total for shipping this package is: {0:c}\nThank you.", total);
        }
    }


    ////=============== IF/THEN EXAMPLES ===============
    //Console.WriteLine("What is your name?");
    //string name = Console.ReadLine();
    //Console.WriteLine("Hi {0}, what is the current temperature?", name);
    //short currentTemp = Convert.ToInt16(Console.ReadLine());

    //int roomTemp = 70;
    //if (currentTemp == roomTemp)
    //{
    //    Console.WriteLine("It is exactly room temperature");
    //}
    //else if (currentTemp > roomTemp)
    //{
    //    Console.WriteLine("It is warmer than room temperature");
    //}
    //else if (currentTemp < roomTemp)
    //{
    //    Console.WriteLine("It is cooler than room temperature");
    //}
    //else
    //{
    //    Console.WriteLine("It is not exactly room temperature");
    //}
    ////===== TERNARY OPERATOR
    //string tempCompare = (currentTemp == roomTemp) ? "It is exactly room temperature" : "It is not exactly room temperature";
    //Console.WriteLine(tempCompare);

    //Console.WriteLine("\n{0}, what is your favorite whole number?", name);
    //int favNum = Convert.ToInt32(Console.ReadLine());
    //string result = favNum == 13 ? "You have an awesome favorite number" : "You do NOT have an awesome favorite number";
    //Console.WriteLine(result);

    //===== HOLD OPEN - till enter is pressed
    Console.ReadLine();            
}
```

## Class Demo

### Commit
- Create multiple classes that program references.
- Create three methods in the class that take two integer parameters
- Methods perform addition, multiplication, and power opertions
- Ask the user what numbers they want to do the math operations with.
- Call each method, passing the user input to the method.
- Display the returned integer/decimal to the screen.

### Output
![alt text](https://github.com/alex-moffat/C-Sharp-Small-Projects/blob/master/Class_Demo/Screenshot_class_demo.jpg "Class_Demo")

### Code
```CS
static void Main(string[] args)
{
    //===== CONSOLE COLOR
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();

    //===== STEP 179 =====
    Console.WriteLine("\n========== STEP 179 ==========");
    Employee<string> employee1 = new Employee<string> { FirstName = "Sample", LastName = "Student", Id = 1, Things = { "Study Hard", "Play Hard", "Take Breaks" } };
    employee1.SayName();
    Console.WriteLine("Employee Id: " + employee1.Id);

    //===== STEP 182 =====
    Console.WriteLine("\n========== STEP 182 ==========");
    Employee<string> employee2 = new Employee<string> { FirstName = "Alexander", LastName = "Hamilton", Id = 2, Things = { "Those who stand for nothing fall for everything.", "I never expect a perfect work from an imperfect man.", "A nation which can prefer disgrace to danger is prepared for a master, and deserves one." } };
    employee2.Quit(); //uses default message from employee class method
    IQuittable iQuittable = new Employee<string> { FirstName = "Aaron", LastName = "Burr", Id = 3 };
    iQuittable.Quit(); // uses default message from IQuittable interface method (even though it can't be implemented)
    IQuittable iQuittable2 = new Employee<string> { FirstName = "Donald", LastName = "Duck", Id = 4 };
    iQuittable2.Quit("Can you be the president");

    //===== STEP 187 =====
    Console.WriteLine("\n========== STEP 187 ==========");
    Employee<string> employee3 = new Employee<string> { FirstName = "George", LastName = "Washington", Id = 3, Things = { "It is better to offer no excuse than a bad one.", "Human happiness and moral duty are inseparably connected.", "Guard against the impostures of pretended patriotism." } };
    Employee<string> employee4 = new Employee<string> { FirstName = "Donald", LastName = "Trump", Id = 4, Things = { "Despite the constant negative press covfefe.", "There was no collusion. Everybody knows there was no collusion.", "I think we've done more than perhaps any president in the first 100 days." } };
    Console.WriteLine("{0} {1} == {2} {3} = {4}", employee2.FirstName, employee2.LastName, employee3.FirstName, employee3.LastName, employee2 == employee3);
    //--- created ReturnName() method in Employee abstract class to access IQuittable interface properties, can't access direcly like above
    Console.WriteLine("{0} == {1} = {2}", employee3.ReturnName(), employee4.ReturnName(), employee3 == employee4);
    Console.WriteLine("{0} != {1} = {2}", employee3.ReturnName(), employee4.ReturnName(), employee3 != employee4);
    //--- NOTE: can cast interface object to employee class object to make comparison to an Employee class object 
    Console.WriteLine("{0} == {1} = {2}", employee4.ReturnName(), iQuittable2.ReturnName(), employee4 == (Employee<string>)iQuittable2);

    //===== STEP 190 =====
    Console.WriteLine("\n========== STEP 190 ==========");
    Employee<string> employee16 = new Employee<string> { FirstName = "Abraham", LastName = "Lincoln", Id = 16, Things = { "America will never be destroyed from the outside. If we falter and lose our freedoms, it will be because we destroyed ourselves.", "Nearly all men can stand adversity, but if you want to test a man's character, give him power.", "I would rather be a little nobody, then to be a evil somebody." } };
    Employee<int> employee5 = new Employee<int> { FirstName = "Leonardo", LastName = "\"Fibonacci\" Bonacci", Id = 16, Things = { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 } };

    Console.WriteLine("{0} is know for these quotes:", employee1.ReturnName());
    employee1.SayThings();
    Console.WriteLine("\nFounding father {0} is know for these quotes:\n{1}", employee2.ReturnName(), employee2.ReturnThings());
    Console.WriteLine("President {0} is know for these quotes:\n{1}", employee3.ReturnName(), employee3.ReturnThings());
    Console.WriteLine("President {0} is know for these quotes:\n{1}", employee16.ReturnName(), employee16.ReturnThings());
    Console.WriteLine("President {0} is know for these quotes:\n{1}", employee4.ReturnName(), employee4.ReturnThings());
    Console.WriteLine("{0} is know for these numbers: {1}", employee5.ReturnName(), employee5.ReturnThings(newline: false));

    //===== STEP 200 =====
    Console.WriteLine("\n========== STEP 200 ==========");
    Number piNum = new Number() { Amount = 3.14159265359m };
    Console.WriteLine("My STRUCT Number (piNum) Amount = {0}", piNum.Amount);
    Console.WriteLine("===== COPY piNum --> piSqu");
    Number piSqu = piNum;
    Console.WriteLine("My STRUCT Number (piSqu) Amount = {0}", piSqu.Amount);
    Console.WriteLine("===== SQUARE piSqu Amount");
    piSqu.Amount *= piSqu.Amount;
    Console.WriteLine("My STRUCT Number (piNum) Amount = {0:f5}", piNum.Amount);
    Console.WriteLine("My STRUCT Number (piSqu) Amount = {0:f5}", piSqu.Amount);

    //===== STEP 203 =====
    Console.WriteLine("\n========== STEP 203 ==========");
    Employee<int> e1 = new Employee<int> { FirstName = "Joe", LastName = "Montana", Id = 1, Things = { 1979, 1994 } };
    Employee<int> e2 = new Employee<int> { FirstName = "Joe", LastName = "Namath", Id = 2, Things = { 1965, 1977 } };
    Employee<int> e3 = new Employee<int> { FirstName = "Joe", LastName = "Flacco", Id = 3, Things = { 2008, 2020 } };
    Employee<int> e4 = new Employee<int> { FirstName = "Tom", LastName = "Brady", Id = 4, Things = { 2000, 2020 } };
    Employee<int> e5 = new Employee<int> { FirstName = "Payton", LastName = "Manning", Id = 5, Things = { 1998, 2015 } };
    Employee<int> e6 = new Employee<int> { FirstName = "John", LastName = "Elway", Id = 6, Things = { 1983, 1998 } };
    Employee<int> e7 = new Employee<int> { FirstName = "Roger", LastName = "\"Staubach", Id = 7, Things = { 1964, 1980 } };
    Employee<int> e8 = new Employee<int> { FirstName = "Dan", LastName = "Marino", Id = 8, Things = { 1983, 2000 } };
    Employee<int> e9 = new Employee<int> { FirstName = "Steve", LastName = "Young", Id = 9, Things = { 1984, 1999 } };
    Employee<int> e10 = new Employee<int> { FirstName = "Brett", LastName = "Favre", Id = 10, Things = { 1991, 2010 } };
    //--- Created new class 'Staff' to hold employees
    Staff<int> nfl = new Staff<int>();
    //--- Use overloaded operator in staff class to add new employees to staff
    nfl = nfl + e1 + e2 + e3 + e4 + e5 + e6 + e7 + e8 + e9 + e10;
    Console.WriteLine("NFL quarterbacks added to staff: {0}", nfl.Employees.Count());

    //--- Use foreach loop to create filtered list by first name
    Console.WriteLine("\n//===== Use foreach loop to create list of employees filtered by first name");
    List<Employee<int>> joeList = nfl.GetEmployees(fName: "Joe", lamb: false);
    Console.WriteLine("Listing {0} employees with the first name \"Joe\":", joeList.Count());
    foreach (Employee<int> e in joeList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }

    //--- Use lambda expression to create filtered list by first name
    Console.WriteLine("\n//===== Use lambda expression to create list of employees filtered by first name");
    joeList = nfl.GetEmployees(fName: "Joe", lamb: true);
    Console.WriteLine("Listing {0} employees with the first name \"Joe\":", joeList.Count());
    foreach (Employee<int> e in joeList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }

    //--- Use lambda expression to create filtered list, created overloaded operator in staff class
    Console.WriteLine("\n//===== Use lambda expression to create a filtered list by ID");
    List<Employee<int>> IDList = nfl > 5;
    Console.WriteLine("\nListing {0} employees with ID > 5:", IDList.Count());
    foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
    IDList = nfl >= 5;
    Console.WriteLine("\nListing {0} employees with ID >= 5:", IDList.Count());
    foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
    IDList = nfl < 5;
    Console.WriteLine("\nListing {0} employees with ID < 5:", IDList.Count());
    foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
    IDList = nfl <= 5;
    Console.WriteLine("\nListing {0} employees with ID <= 5:", IDList.Count());
    foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
    IDList = nfl == 5;
    Console.WriteLine("\nListing {0} employees with ID == 5:", IDList.Count());
    foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }
    IDList = nfl != 5;
    Console.WriteLine("\nListing {0} employees with ID != 5:", IDList.Count());
    foreach (Employee<int> e in IDList) { Console.WriteLine("{0} played in the NFL from {1} through {2}", e.ReturnName(), e.Things[0], e.Things[1]); }

    //===== STEP 203 =====
    const string stepNum = "STEP 230";
    Console.WriteLine("\n========== {0} ==========", stepNum);
    var title = "Installing a new software";
    var body = new List<string>()
    {
        "See the license agreement,",
        "skip reading,",
        "click\"I agree\".",
        "Install."
    };
    Poem poem = new Poem(title, body);
    poem.DisplayPoem();


    //===== MULTIPLE STEPS DEMONSTRATED
    Console.WriteLine("\n========== MULTIPLE EXAMPLES ==========");
    //--- CREATE CLASS OBJECT
    BasicMath basic = new BasicMath();
    bool valid = false;
    while (!valid)
    {
        try
        {
            Console.WriteLine("Pick a number to do some math with:");
            string s1 = Console.ReadLine();
            int pick1 = Convert.ToInt32(s1);
            decimal d1 = Convert.ToInt64(pick1);
            Console.WriteLine("OPTIONAL: Pick a another number to do some math with:");
            string s2 = Console.ReadLine();
            //===== RANDOM - assigned to second number if not selected
            int pick2 = (s2 == "") ? basic.RandomNumber(1, 10) : Convert.ToInt32(s2);
            decimal d2 = Convert.ToInt64(pick2);
            //===== CALL METHODS - with and without second value print results to console
            Console.WriteLine("========== basic.Add()");
            Console.WriteLine("{0:n0} + {1:n0} = {2:n0}", pick1, pick2, basic.Add(pick1, pick2));
            Console.WriteLine("{0} + default = {1:n0}", pick1, basic.Add(pick1));
            Console.WriteLine("========== basic.Multiply()");
            Console.WriteLine("{0:n0} x {1:n0} = {2:n0}", pick1, pick2, basic.Multiply(pick1, pick2));
            Console.WriteLine("{0} x default = {1:n0}", pick1, basic.Multiply(pick1));
            Console.WriteLine("{0} multiplied by the reciprocal of {1} = {2:n0}", d1, d2, basic.Multiply(d1, d2, true));
            Console.WriteLine("{0} multiplied by the reciprocal of default = {1:n0}", d1, basic.Multiply(num1:d1, reciprocal:true));
            Console.WriteLine("({0} x {1}) + {0} + {1} = {2:n0}", s1, s2, basic.Multiply(s1, s2));
            Console.WriteLine("({0} x default) + {0} + default = {1:n0}", s1, basic.Multiply(s1));
            Console.WriteLine("========== basic.Power()");
            Console.WriteLine("{0:n0} to the power of {1:n0} = {2:n0}", pick1, pick2, basic.Power(pick1, pick2));
            Console.WriteLine("{0:n0} to the power of default = {1:n0}", pick1, basic.Power(pick1));
            //--- VOID METHOD
            basic.PrintRandom(pick1, pick2);
            basic.PrintRandom(num1: pick1, num2: 4, max: 50);
            basic.PrintRandom(num1: 2, num2: 6, min: 20, max: 50);
            basic.PrintRandom(num1: 5, num2: 13, msg: "Having fun with C#... But not as much as Python!");

            valid = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Oops...something went wrong:");
            Console.WriteLine(e.Message);
        }
    }

    //===== STEP 169
    Console.WriteLine("\n========== STEP 169 ==========");
    Step169 step169 = new Step169();
    string outText;
    valid = false;
    while (!valid)
    {
        try
        {
            Console.WriteLine("Pick a number to divide by 2:");
            int pick1 = Convert.ToInt32(Console.ReadLine());
            //--- calling void method
            step169.FunWith2(pick1);
            //--- calling overloaded method
            step169.FunWith2();
            valid = true;
            //--- calling method with output parameter
            step169.FunWith2(pick1, out int value, out outText);
            Console.WriteLine(outText);
            //--- calling method in a static class
            float C = ConvertTemp.FahrenheitToCelsius((float)value);
            float F = ConvertTemp.CelsiusToFahrenheit((float)value);
            Console.WriteLine("Sending output parameter from FunWith2 to ConvertTemp static Class:\n{0:n0}F is {1:n}C\n{0:n0}C is {2:n}F", value, C, F);
        }
        catch (Exception e)
        {
            Console.WriteLine("Oops...something went wrong:");
            Console.WriteLine(e.Message);
        }
    }


    //===== HOLD OPEN - till enter is pressed
    Console.ReadLine();
}
```
