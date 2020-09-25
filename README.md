# C-Sharp-Small-Projects

## DESCRIPTION
These are very small projects designed to provide examples of basic coding concepts and commenting. Most examples were completed in less than 2 hours.    

## CONTENTS
- [Arrays and Lists](#arrays-and-lists)

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
    
