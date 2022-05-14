/*
! Value Types vs Reference Types
	- Value Types: have a specific size, and stores in stack memory.
	- Reference Types: have variable size, and sgtored in heap memory.

*/

//! Strings
string someString;
string initialized = "This is initialized";

string firstName = "Joe";
string lastName = "Schmoe";

string fullName = firstName + ' ' + lastName;
System.Console.WriteLine(fullName);

//* interpolation
string interpolatedFullName = $"{firstName} {lastName}";
System.Console.WriteLine(interpolatedFullName);

/*
! Collections
	A string is technically a collection (of character)
*/

//* Array
char firstLetter = firstName[0];
System.Console.WriteLine(firstLetter);

string extraItem = "another string";

//                         0        1       2       3        4           5              6
string[] stringArray = {"Hello", "World", "why", "is it", "always", "hello world?", extraItem};
System.Console.WriteLine(stringArray[1]);
/*
	We define the type with the square brackets. The curly brackets will detail the information within that array. Arrays do have a fixed size determined on how they are created.

	Targeting index within an array, we always start with position zero.
*/
System.Console.WriteLine(stringArray[6]);
int lengthValue = stringArray.Length;
System.Console.WriteLine(lengthValue);
System.Console.WriteLine(stringArray[stringArray.Length - 1]);

//* List
List<string> listOfStrings = new List<string>();
listOfStrings.Add("Hello");
listOfStrings.Add("World");
/*
	A List is part of a class that is built into C# which allows us various methods to manipulate it.
*/

List<int> listOfInts;

/*
*Queue
	-First in / First out
*/

Queue<string> firstInFirtsOut = new Queue<string>();
firstInFirtsOut.Enqueue("Im first");
firstInFirtsOut.Enqueue("Im next");
System.Console.WriteLine(firstInFirtsOut.Peek()); //Peek() is a method that allows us to view what item is first in queue.
firstInFirtsOut.Dequeue(); // We are using this method to remove the item currently in the first position.
System.Console.WriteLine(firstInFirtsOut.Peek()); // The second string was shown as the first was removed.

/*
* Dictionaries
	- A collection where we are signing a key to a value pair.
*/
Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

keyAndValue.Add(21, "legal drinking age");
keyAndValue.Add(18, "legal voting age");
keyAndValue.Add(19, "legal voting age");
System.Console.WriteLine(keyAndValue[21]); // We can target a key just like we target an index value in an array.
// The values can be the same; however, you cannot use the same key for different values.

Dictionary<string, string> stringDictioanry = new Dictionary<string, string>();
stringDictioanry.Add("Triangle", "the set of all points in a plane defined by the area within three points");