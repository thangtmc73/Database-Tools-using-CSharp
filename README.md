# Database Tools using CSharp

## About

Help you find all available closures from a set of attributes and functional dependency, connect to a database to make a SQL query and to find all FDs from the database.

When I was a sophomore in Univeristy, I studied Databases there. My lecturer, Mr. Do Phuc supported us to get motivated developing a software like this. He want the students improving programming skills. So this project was created.

This project is developed by using C# and Windows Form Application with Visual Studio 2015 Community.

## Requirement:

* Install [Microsoft Access Database Engine 2010 Redistributable](https://www.microsoft.com/en-us/download/details.aspx?id=13255)

## Features:

* Find all superkeys and keys from a set of attributes and functional dependencies (available).
* Find all available closures from a set of attributes and functional dependencies (available).
* Find the closure of the specified attributes from a set of attributes and functional dependency (available).
* Make a SQL query from a database (.mdb or .accdb) (available).
* Find all FDs from a database (unavailable).

## Examples:

![What you see when you run the program.](/images/examples/1.png "What you see when you run the program.")

### Tab Calculate

No space between attributes and commas. For example: "A,B,C,D", not "A ,    B , C, D , E".

This program use "-" instead of "->" in input. The semi-colons are used to separate the set of functional dependencies into elements. For example: "A-B;A,B-C" represents for "A -> B; AB -> C".

With n attributes, we have 2^n - 1 sets of attributes to calculate the closures. But you only want to find the closure of one set of attributes. In the field "Find Closure of Attributes", you can choose the sets of attributes you want.

I have the set F of functional dependencies for relation schema R {A, B, C, D, E}:
{ A -> BC, CD -> E, B -> D, E -> A}. I choose the sets of attributes B and D to find the closure specifically. Here is the input.

![The input](/images/examples/2.png "the input")

Click the button Execute in the section Control to calculate. You will see the result you need in the section Result. Here is the result.

![All superkeys](/images/examples/3.png "All superkeys")

![All keys](/images/examples/4.png "All keys")

![All closures](/images/examples/5.png "All closures")

![The closure of specified set of attributes](/images/examples/6.png "The closure of specified set of attributes")

### Tab Connect

You browse the database file (.mdb or .accdb). Click the  button Connect to connect the database. In the section Query, type the SQL query you want and click the button Execute.

The feature Find FDs is not available. Sorry for the inconvenience!