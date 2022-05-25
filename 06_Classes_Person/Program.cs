//! Person Class

Person person = new Person();
person.LastName = "Parker";
person.FirstName = "Peter";
person.DateOfBirth = new DateTime(1962, 6, 5);
System.Console.WriteLine($"{person.FullName} is {person.Age} years old.");

Person person2 = new Person("Bruce", "Wayne", new DateTime(1939, 5, 1));
System.Console.WriteLine($"{person2.FullName} is {person2.Age} years old.");

Person person3 = new Person(1963, "Charles", "Xavier");
System.Console.WriteLine(person3.ID);
// person3.ID = 10;
// System.Console.WriteLine(person3.ID);

//!--------------------------------------CLASS OBJECT--------------------------------------------------
public class Person {

	//PROPERTIES
	public string FirstName { get; set; }

	//Field
	private string _lastName; // fields are private

	public string LastName {
		/*
			- We have a method to get the person latname and set the person last name
			- We can customize how our get/set are detailed
			- Setting just a "get; set;" is just shorthand for what this property is doing
		*/

			get { return _lastName; }
			set {_lastName = value; } // value is a keyword specfic to this situation and equals whatever value was provided when creating the person
	}

	public string FullName { 
		get { return $"{FirstName} {LastName}";}
	}

	public DateTime DateOfBirth { get; set; }

	public int Age { 
		get {
			TimeSpan exactAge = DateTime.Now - DateOfBirth;
			double totalDays = exactAge.TotalDays;
			double yearsUnrounded = totalDays / 365.24;
			int years = (int) Math.Round(yearsUnrounded); // Math will provide us a double datetime, so we will cast it as an int that Rounds up.
			return years;
		}
	}

	//! Constructors
	/*
		- Invoked automaticlaly when object is created
		- Initializes the data members of a new object

		Has two tyoes:
			- Default constructor
			- Parameterized constructor
	*/

	public Person(){} // We have cfreated a b;ank constructor (default)
	//* ctor - emmet for constructor buoilerplate

	public Person(string firstName, string lastName, DateTime dateOfBirth)
	{
	//		1			2	
		FirstName = firstName;
		/*
			1. Property name
			2. value to be set to property
		*/
		_lastName = lastName;
		DateOfBirth = dateOfBirth;
	}

	public Person(int id, string firstName, string lastName)
	{
		_idNumber = id;
		FirstName = firstName;
		_lastName = lastName;
	}

	private int _idNumber;
	public int ID
	{
		get { return _idNumber;}
		// When we assign the iD of the person up creation (in the 3rd constructor), we cannot alter it because it is a Read Only.
	}
}