/*
! Arithmetic Operators
	Math and logic operators
*/

int a = 10;
int b = 3;
System.Console.WriteLine(a + b);

int difference = a - b;
System.Console.WriteLine(difference);
System.Console.WriteLine(a * b);
System.Console.WriteLine(a / b);

int numberA = 22;
int numberB = 15;
System.Console.WriteLine(numberA / numberB); // Provides an incorrect value because return ia an "int".
System.Console.WriteLine((decimal) numberA / (decimal) numberB);
System.Console.WriteLine(numberA % numberB); // Modulus - the remainder of what has been divided

DateTime now = DateTime.Now;
DateTime someDay = new DateTime(1985, 10, 26);
TimeSpan timeSpan = now - someDay;
System.Console.WriteLine(timeSpan / 365);

/*
! Comparison Operators
	Compare two different values in a certain way.
*/

string name = "Peter";
string anotherName = "peter"; // ME: got false when changed first letter to lowercase (Peter doesn't = peter)
System.Console.WriteLine(name == "Peter");
System.Console.WriteLine(name == anotherName);

int age = 30;
bool notEqual = age != 123;
System.Console.WriteLine(notEqual); // Provides us a True value because age is NOT equal to 123

List<string> firstList = new List<string>();
List<string> secondList = new List<string>();

firstList.Add(name);
secondList.Add(name);

System.Console.WriteLine(firstList == secondList);
// Returns false because they have different addresses in memory. If you were to compare something like this, you would need to compare the exact items within the list (done with a loop)

bool greaterThan = age > 12; // True
bool greaterThanOrEqual = age >= 18;
bool lessThan = age < 100; // True
bool lessThanOrEqual = age <= 20; // False

//* OR
bool orValue = lessThan || lessThanOrEqual; // One must be true to return back true statement
System.Console.WriteLine($"OR: {orValue}");

//* ANd
int x = 3;
bool andValue = x < 5 && greaterThan; // ME: if x > 5 will return false because frist statement is false so it makes whole false?
System.Console.WriteLine($"AND: {andValue}");



if (x > 5 && x > 2 || x < 50) // ME: first AND is false (x > 5 && x > 2) but then looks at OR which shows true on other side so will return as "Yup" (true) 
{
	System.Console.WriteLine("Yup");
}
else
{
	System.Console.WriteLine("Nope");
}