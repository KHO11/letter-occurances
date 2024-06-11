# Letter occurances 

# Tech Used 

C# and .Net

# Lessons learned 

The dictionary for storing letter counts is initialized with all lowercase letters from 'a' to 'z'. This pre-initialization ensures that each letter has an entry, avoiding potential issues with missing keys during the counting process.

The code retrieves all files in the specified directory and its subdirectories, filtering only JavaScript (.js) and TypeScript (.ts) files. This is done efficiently using Directory.GetFiles and LINQ.

The use of a try-catch block to handle FileNotFoundException ensures that the program can handle missing files gracefully. However, it could be improved by handling other potential exceptions and logging detailed information for debugging.

The character counting logic converts each character to lowercase and checks if it's in the dictionary before incrementing the count. This ensures that the counting is case-insensitive.

# Unit Testing 

A test case in the UnitTestProject1 folder of letterOccurances folder
