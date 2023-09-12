using Dates;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MODULE 01");
        Module01Variables();
        Module01Constants();
        Module01ArithmeticOperators();
        Module01RelationalOperators();
        Module01LogicalOperators();
        Module01TernaryOperators();
        Console.WriteLine("MODULE 02");
        Module02Functions();
        Module02FunctionsParameters();
        Console.WriteLine("MODULE 03");
        Module03ArrayList();
        Module03TypedArrays();
        Module03StringArrays();
        Module03Lists();
        Module03Dictionary();
        Module03Queue();
        Module03Stack();
        Console.WriteLine("MODULE 04");
        Module04IfElse();
        Module04Switch();
        Module04For();
        Module04Foreach();
        Module04WhileDoWhile();
        Module04BreakContinue();
        Console.WriteLine("MODULE 05");
        Module05ClassesAndOtherTypes();
        Console.WriteLine("MODULE 06");
        Module06Converters();
        Console.WriteLine("MODULE 07");
        Module07Strings();
        Console.WriteLine("MODULE 08");
        Module08Date();
        Console.WriteLine("MODULE 09");
        Module09ExceptionHandling();
        Console.WriteLine("MODULE 10");
        Module10WorkingWithFiles();
        Console.WriteLine("MODULE 11");
        Module11LINQ();
    }

    private static void Module01Variables()
    {
        Console.WriteLine("Variables");
        var demoVariables = new Variables.Variable();
        demoVariables.DemonstrateVariables();
    }

    private static void Module01Constants()
    {
        Console.WriteLine("Constants");
        var demoConstants = new Constants.Constant();
        demoConstants.DemonstrateConstants();
    }

    private static void Module01ArithmeticOperators()
    {
        Console.WriteLine("Arithmetic Operators");
        var demoArithmeticOperators = new ArithmeticOperators.ArithmeticOperator();
        demoArithmeticOperators.DemonstrateArithmeticOperators();
    }

    public static void Module01RelationalOperators()
    {
        Console.WriteLine("Relational Operators");
        var demoRelationalOperators = new RelationalOperators.RelationalOperator();
        demoRelationalOperators.DemonstrateRelationalOperators();
    }

    public static void Module01LogicalOperators()
    {
        Console.WriteLine("Logical Operators");
        var demoLogicalOperators = new LogicalOperators.LogicalOperator();
        demoLogicalOperators.DemonstrateLogicalOperator();
    }

    public static void Module01TernaryOperators()
    {
        Console.WriteLine("Ternary Operators");
        var demoTernaryOperators = new TernaryOperators.TernaryOperator();
        demoTernaryOperators.DemonstrateTernaryOperators();
    }

    public static void Module02Functions()
    {
        Console.WriteLine("Functions");
        var demoFunctions = new Functions.Function();
        demoFunctions.DemonstrateFunctions();
    }

    public static void Module02FunctionsParameters()
    {
        Console.WriteLine("Functions Parameters");
        var demoFunctionsParameters = new FunctionsParameters.FunctionsParameter();
        demoFunctionsParameters.DemonstrateFunctionsParameters();
    }

    public static void Module03ArrayList()
    {
        Console.WriteLine("Array List");
        var demoArrayLists = new ArrayLists.ArrayLists();
        demoArrayLists.DemonstrateArrayList();
    }

    public static void Module03TypedArrays()
    {
        Console.WriteLine("Typed Arrays");
        var demoTypedArrays = new TypedArrays.TypedArray();
        demoTypedArrays.DemonstrateTypedArray();
    }

    public static void Module03StringArrays()
    {
        Console.WriteLine("String Arrays");
        var demoStringArrays = new StringArrays.StringArray();
        demoStringArrays.DemonstrateStringArray();
    }

    public static void Module03Lists()
    {
        Console.WriteLine("List");
        var demoLists = new Lists.List();
        demoLists.DemonstrateList();
    }

    public static void Module03Dictionary()
    {
        Console.WriteLine("Dictionary");
        var demoDictionaries = new Dictionaries.Dictionary();
        demoDictionaries.DemonstrateDictionaries();
    }

    public static void Module03Queue()
    {
        Console.WriteLine("Queue");
        var demoQueues = new Queues.Queue();
        demoQueues.DemonstrateQueue();
    }

    public static void Module03Stack()
    {
        Console.WriteLine("Stack");
        var demoStack = new Stacks.Stack();
        demoStack.DemonstrateStacks();
    }

    public static void Module04IfElse()
    {
        Console.WriteLine("If/Else If/Else");
        var demoIfElse = new IfElseIfElse.IfElse();
        demoIfElse.DemonstrateIfElse();
    }

    public static void Module04Switch()
    {
        Console.WriteLine("Switch");
        var demoSwitch = new Switch.Switch();
        demoSwitch.DemonstrateSwitch();
    }

    public static void Module04For()
    {
        Console.WriteLine("For");
        var demoFor = new For.For();
        demoFor.DemonstrateFor();
    }

    public static void Module04Foreach()
    {
        Console.WriteLine("Foreach");
        var demoForeach = new Foreach.Foreach();
        demoForeach.DemonstrateForeach();
    }

    public static void Module04WhileDoWhile()
    {
        Console.WriteLine("While/Do While");
        var demoWhileDoWhile = new WhileDoWhile.WhileDoWhile();
        demoWhileDoWhile.DemonstrateWhileDoWhile();
    }

    public static void Module04BreakContinue()
    {
        Console.WriteLine("Break/Continue");
        var demoBreakContinue = new BreakContinue.BreakContinue();
        demoBreakContinue.DemonstrateBreakContinue();
    }

    public static void Module05ClassesAndOtherTypes()
    {
        Console.WriteLine("Classes And Other Types");
        var studentGradeAverage = ClassesAndOtherTypes.CalculationUtility.EstimateGradeAverage(8,9);
        Console.WriteLine(studentGradeAverage);

        Console.WriteLine("\nAcademic Supplies");
        var academicSupply = new ClassesAndOtherTypes.AcademicSupplies("Notebook");
        Console.WriteLine("Description: " + academicSupply.Description);
        Console.WriteLine("Quantity: " + academicSupply.Quantity);
        academicSupply.DisplayEducationalSuppliesInfo();

        Console.WriteLine("\nStudent Info");
        var studentInfo = new ClassesAndOtherTypes.Student
        {
            StudentId = 10116,
            Name = "Peter Parker",
            Email = "peter@email.com",
            Address = "Forest Hills",
            City = "New York",
            Country = "USA"
        };
        studentInfo.DisplayIndividual();
        studentInfo.DisplayAddressInfo();

        Console.WriteLine("\nEmployee Info");
        var employeeInfo = new ClassesAndOtherTypes.Employee
        {
            EmployeeId = "E616",
            EmployeeName = "Curtis Connor",
            Department = "Scientist",
            Salary = 15795,
            Address = "Washington Street",
            City = "New York",
            Country = "USA",
        };
        employeeInfo.DisplayEmployee();
        employeeInfo.DisplayAddressInfo();

        Console.WriteLine("\nUniversity Website Title");
        var  universityWebsite = new ClassesAndOtherTypes.UniversityWebsite
        {
            WebsiteTitle = "ESU - Empire State University"
        };
        Console.WriteLine(universityWebsite.WebsiteTitle);

        Console.WriteLine("\nTeam Mascot");
        var basketballTeamMascot = new ClassesAndOtherTypes.Basketball
        {
            MascotName = "Jack",
            Animal = "Kangaroo",
        };
        basketballTeamMascot.GetInformations();
        basketballTeamMascot.DisplayMascotDetails();

        Console.WriteLine("\nCourses");

        var course1 = new ClassesAndOtherTypes.Course (1, "Astronomy");
        var course2 = course1 with {Description = "Astrophysics"};
        
        Console.WriteLine("Course 01: " + course1.Description);
        Console.WriteLine("Course 02: " + course2.Description);
        Console.WriteLine($"{course1.Description} is equal to {course2.Description}: {course1 == course2}");
        Console.WriteLine($"{course1.Description} is equal to {course2.Description}: {course1.Equals(course2)}");

        Console.WriteLine("\nProfessor");
        var professor1 = new ClassesAndOtherTypes.Professor {ProfessorId = 1, ProfessorName = "Otto Octavius"};
        var professor2 = professor1;
        professor2.ProfessorName = "Octopus";
        
        Console.WriteLine(professor1.ProfessorName);
        Console.WriteLine(professor2.ProfessorName);

        Console.WriteLine("\nNotifications");
        var studentNotification = new ClassesAndOtherTypes.StudentNotification();
        studentNotification.Notify();
        var professorNotification = new ClassesAndOtherTypes.ProfessorNotification();
        professorNotification.Notify();
        professorNotification.NotifyEveryone();
    }

    public static void Module06Converters()
    {
        Console.WriteLine("Value Conversions");
        var conversions = new Conversions.Conversion();
        conversions.ConvertAndParse();
        conversions.TryParse();
    }

    public static void Module07Strings()
    {
        Console.WriteLine("Strings");
        var strings = new Strings.String();
        strings.ConvertToLowercase();
        strings.ConvertToUppercase();
        strings.ExtractSubstring();
        strings.ExtractStringWithRange();
        strings.CheckIfContains();
        strings.TrimString();
        strings.CheckStartsWith();
        strings.CheckEndsWith();
        strings.ReplaceString();
        strings.LengthString();
    }

    public static void Module08Date()
    {
        Console.WriteLine("Date");
        var dates = new Dates.Date();
        dates.DisplayDateTime();
        dates.SubtractDates();
        dates.AddDaysMonthsYears();
        dates.AddHoursMinutesSeconds();
        dates.RetrieveDayOfWeek();
        dates.ExtractDateOnly();
        dates.ExtractTimeOnly();
    }

    public static void Module09ExceptionHandling()
    {
        Console.WriteLine("Exception");
        var workingWithExceptions = new ExceptionHandling.ExceptionHandling();
        workingWithExceptions.GenerateException();
        workingWithExceptions.HandleException();
    }

    public static void Module10WorkingWithFiles()
    {
        Console.WriteLine("Files");
        var workingWithFiles = new WorkingWithFile.WorkingWithFiles();
        workingWithFiles.CreateFile();
        workingWithFiles.ReadFile();
        workingWithFiles.ReadFileByLine();
        workingWithFiles.DeleteFile();
    }

    public static void Module11LINQ()
    {
        Console.WriteLine("LINQ");
        var linq = new LINQ.WorkingWithLinq();
        linq.DemonstrateWhere();
        linq.DemonstrateOrderBy();
        linq.DemonstrateTake();
        linq.DemonstrateCount();
        linq.DemonstrateFirstAndFirstOrDefault();
    }   
}