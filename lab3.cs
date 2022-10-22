class Program
{
    static void Main(string[] args)
    {
        Component University = new CurrentIn("UzhNU");
        // under Uzhnu
        Component Faculties = new CurrentIn("Faculties");
        //Faculties
        Component Fmdt = new CurrentIn("FMDT");

        Component LawFac = new CurrentIn("LawFaculty");
        // Cathedras
        Component CathedrasInFmdt = new CurrentIn("Cathedras in Fmdt ");

        Component CathedrasInLaw = new CurrentIn("Cathedras in Laws ");

        //Cathedras!

        Component SystemAnalysis = new CurrentIn("System Analysis");

        Component Law = new CurrentIn("Laws");

        //Employees

        Component EmployeesinSa = new CurrentIn("Employees in Cathedra: ");

        Component EmployeesinLaws = new CurrentIn("Employees in Cathedra: ");

        //Their Post

        Component TeacherInFmdt = new CurrentIn("Teacher is: ");

        Component DeanInFmdt = new CurrentIn("Dean is: ");

        Component TeacherInLaw = new CurrentIn("Teacher is: ");

        Component DeanInLaw = new CurrentIn("Dean is: ");

        //Name of Employees

        Component TeacherInSa = new ObjectIn("Andrashko Yurii Vasylovich , Hlebena Myroslava Ivanivna");

        Component TeacherInLaws = new ObjectIn("Hlebena Yurii Vasylovich , Mylesa Myroslava Ivanivna");

        Component ChiefOfFmdt = new ObjectIn("Mylesa Pavlo Pavlovych");

        Component ChiefOfLaw = new ObjectIn("Andrashko Pavlo Pavlovych");

        //


        // add components to Faculties and Show It
        Faculties.Add(Fmdt);      

        Fmdt.Add(CathedrasInFmdt);
        
        CathedrasInFmdt.Add(SystemAnalysis);

        SystemAnalysis.Add(EmployeesinSa);

        EmployeesinSa.Add(TeacherInFmdt);

        TeacherInFmdt.Add(TeacherInSa);

        EmployeesinSa.Add(DeanInFmdt);

        DeanInFmdt.Add(ChiefOfFmdt);



        //------------------------------------------------------------------------------------

        Faculties.Add(LawFac);

        LawFac.Add(CathedrasInLaw);

        CathedrasInLaw.Add(Law);

        Law.Add(EmployeesinLaws);

        EmployeesinLaws.Add(TeacherInLaw);

        TeacherInLaw.Add(TeacherInLaws);

        EmployeesinLaws.Add(DeanInLaw);

        DeanInLaw.Add(ChiefOfLaw);



        // Add Faculties to University
        University.Add(Faculties);
        // Print all Data
        University.Print();


        Console.Read();
    }
}

abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public virtual void Add(Component component) { }

    public virtual void Remove(Component component) { }

    public virtual void Print()
    {
        Console.WriteLine(name);
    }
}
class CurrentIn : Component
{
    private List<Component> components = new List<Component>();

    public CurrentIn(string name)
    : base(name)
    {
    }

    public override void Add(Component component)
    {
        components.Add(component);
    }

    public override void Remove(Component component)
    {
        components.Remove(component);
    }

    public override void Print()
    {
        Console.WriteLine(">>> " + name);
        //Console.WriteLine(">>> " + name);
        for (int i = 0; i < components.Count; i++)
        {
            components[i].Print();
        }
    }
}

class ObjectIn : Component
{
    public ObjectIn(string name)
    : base(name)
    { }
}
