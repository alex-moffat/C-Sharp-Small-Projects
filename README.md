# C-Sharp-Small-Projects

## DESCRIPTION
These are very small projects designed to provide examples of basic coding concepts and commenting. Most examples were completed in less than 2 hours.    

## CONTENTS
- [Arrays and Lists](#arrays-and-lists)
- [Basic Console App](#basic-console-app)

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
