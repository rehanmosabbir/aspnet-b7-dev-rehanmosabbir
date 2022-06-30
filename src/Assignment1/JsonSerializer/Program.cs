using JsonSerializer;

Course course = new Course();
course.Title = "Asp.net";
course.Fees = 30000;
course.Teacher = new Instructor()
{
    Name = "Jalaluddin",
    Email = "jalaluddin@gmail.com",
    PresentAddress = new Address()
    {
        City = "Dhaka",
        Country = "Bangladesh",
        Street = "37/A,Green Road"
    },
    PermanentAddress = new Address()
    {
        City = "Dhaka",
        Country = "Bangladesh",
        Street = "37/A, Green Road"
    },
    PhoneNumbers = new List<Phone> {
        new Phone(){Number="1749291863",Extension="", CountryCode="+880"},
        new Phone(){Number="1835853215",Extension="",CountryCode="+880"}
    }
};

course.Topics = new List<Topic>()
{
    new Topic()
    {
        Title = "Getting Ready",
        Description="Get to know each other, Purpose of learning, Proper way of learning",
        Sessions = new List<Session>()
        {
            new Session(){DurationInHour=1,LearningObjective="Get to know each other"},
            new Session(){DurationInHour=1,LearningObjective="Purpose of learning, Proper way of learning"},
        }
    }
};

course.Tests = new List<AdmissionTest>()
{
    new AdmissionTest(){StartDateTime=new DateTime(2022,1,21,10,0,0), EndDateTime=new DateTime(2022,1,21,11,0,0),TestFees=100},
    new AdmissionTest(){StartDateTime=new DateTime(2022,1,29,10,0,0), EndDateTime=new DateTime(2022,1,29,11,0,0),TestFees=100},

};

string json = JsonFormatter.Convert(course);
Console.WriteLine(json);
