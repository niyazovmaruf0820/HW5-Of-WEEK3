List<Person> people = new List<Person>(){};
System.Console.WriteLine("first student :");
var student1 = new Student(Console.ReadLine());
System.Console.WriteLine("second student :");
var student2 = new Student(Console.ReadLine());
System.Console.WriteLine("the teacher :");
var techer = new Teacher(Console.ReadLine());

student1.Study();
student2.Study();
techer.Explain();
