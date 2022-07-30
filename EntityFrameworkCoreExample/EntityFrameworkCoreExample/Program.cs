using EntityFrameworkCoreExample;

StudentContent dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "Brandon Carroll",
    EmailAddress = "carroll4556@students.cptc.edu",
    DateOfBirth = new DateTime(1996, 12, 05)
};

Student s2 = new()
{
    FullName = "Joe Ortiz",
    EmailAddress = "Joe.Ortiz@cptc.edu",
    DateOfBirth = new DateTime(2000, 1, 1)
};

// this is adding info to the students table
dbContext.Students.Add(s);
dbContext.SaveChanges(); // executes pending insert (Will also execute anything from the CRUD functionality)

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// retrieve students from the database
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax
//allStudents = (from stu in dbContext.Students select stu).ToList(); // Query syntax

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}