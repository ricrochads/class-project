# Class Project
This project aims for the practical application of the fundamentals of the C# programming language.

## Module 01
### Variables
A variable in C# is a memory space reserved for storing data. Variables are used to store information that can be manipulated and utilized in a program. In C#, variables need to be declared with a specific data type before they can be used.
Some examples of variables in C#:

#### String
``` csharp
string dogName = "Panda";
Console.WriteLine("Dog name: " + dogName);
```

#### Integer (int)
``` csharp
int dogAge = 5;
Console.WriteLine("Age: " + dogAge);
```

#### Double
``` csharp
double dogWeight = 8.2;
Console.WriteLine("Weight: " + dogWeight);
```

#### Floating-point (float)
``` csharp
float dogHeight = 0.25f;
Console.WriteLine("Dog height: " + dogHeight + " meters");
```

#### Boolean (bool)
``` csharp
bool isVaccinated = true;
Console.WriteLine("Is vaccinated? " + isVaccinated);
```

#### Character (char)
``` csharp
char letter = 'P';
Console.WriteLine("Letter: " + letter);
```

#### Date (DateTime)
``` csharp
DateTime dogBirthDate = new DateTime(2017, 11, 9);
Console.WriteLine("BirthDate: " + dogBirthDate.ToShortDateString());
```

### Constants
Constants are fields and locations whose values are fixed and cannot be changed once they have been defined. 
These values can be strings, numbers, boolean values or a null reference.
``` csharp
const string description = "CSharp Course";
Console.WriteLine("Const string: " + description);
```
### Arithmetic Operators
The mathematical operations are executed with special symbols, arithmetic operators, on variables and values that allow it to perform common operations such as addition, subtraction, multiplication and division. The main arithmetic operators in C# are:

#### Addition (+)
``` csharp
int result = 1 + 2;
```

#### Subtraction (-)
``` csharp
int result = 3 - 4;
```

#### Multiplication (*)
``` csharp
int result = 5 * 6;
```

#### Division (/)
``` csharp
int result = 7 / 2;
```

### Relational Operators
Relational Operators are used to comparing two variables and return a boolean value (true or false). Here are the main ones:

#### Equal to (==)
``` csharp
int a = 1;
int b = 2;
bool result = (a == b); // result will be false
```

#### Not equal to (!=)
``` csharp
int a = 1;
int b = 2;
bool result = (a != b); // result will be true
```

#### Greater than (>)
``` csharp
int a = 40;
int b = 5;
bool result = (a > b); // result will be true
```

#### Less than (<)
``` csharp
int a = 5;
int b = 40;
bool result = (a < b); // result will be true
```

#### Greater than or equal to (>=)
``` csharp
int a = 30;
int b = 30;
bool result = (a >= b); // result will be true
```

#### Less than or equal to (<=)
``` csharp
int a = 5;
int b = 10;
bool result = (a <= b); // result will be true
```

### Logical Operators
Used to perform logical operations with boolean operands. Common logical operators include:

#### Operador AND (&&)
``` csharp
int number1 = 1;
var number2 = 2;
var result1 = number2 > number1 && 6 < 7; // result will be true
```

#### Operador OR (||)
``` csharp
int number1 = 1;
var number2 = 2;
var result2 = number2 > number1 || 8 > 10; // result will be true
```

#### Operador NOT (!)
``` csharp
int number1 = 1;
var number2 = 2;
var result3 = !(number2 > 3); // result will be true
```

### Ternary Operators
It's a resource for validating a condition that must be true or false. The general syntax of the ternary operator is as follows:

``` csharp
result = condition ? valueIfTrue : valueIfFalse;
```

## Module 02
### Functions
Functions, also known as methods, are blocks of code that perform a specific task and provide structure, organization and code reuse. Below is a basic structure of a function:

``` csharp
accessModifier returnType FunctionName()
{
    // Function body (logic)
    // Variable declarations, control structures, etc.

    return returnValue;
}
```

Example:
``` csharp
public string FullName()
{
    string firstName = "Ricardo"; 
    string lastName = "Rocha";
            
    return $"Full Name: {firstName} {lastName}";
}
```

### Functions Parameters
The parameters of a function are pieces of information that are passed to the function so that it can process or manipulate the data in some way according to the logic defined. Here is a simple example of a function with parameters:

``` csharp
static int Sum(int a, int b)
{
    return a + b;
}
```

## Module 03
### Array List
### Typed Array
### String Array
### Lists
### Dictionary
### Queue
### Stack

## Module 04
### If/Else If/Else
### Switch
### For
### Foreach
### While/Do While
### Break/Continue

## Module 05
### Inheritance
### Sealed Class
### Abstract Class
### Record
### Interface

## Module 06
### Convert/Parse
### TryParse

## Module 07
### ToLower
### ToUpper
### Substring / Range
### Contains
### Trim, TrimEnd e TrimStart
### StartWith e EndsWith
### Replace
### Length

## Module 08
### DateTime
### Subtracting dates
### Adding day, month and year
### Adding hours, minutes and seconds
### Retrieving day of the week
### DataOnly
### TimeOnly

## Module 09
### What is an exception?
### Generating an exception
### Handling an exception

## Module 10
### Creating a file
### Reading a file
### Deleting a file

## Module 11
### Introdução ao LINQ
### Where
### Order By
### Take
### Count
### FirstOrDefault
