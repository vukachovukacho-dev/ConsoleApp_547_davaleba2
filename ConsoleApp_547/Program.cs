ChildClass childClass = new ChildClass("John", ' ', "This is child property");
ParentClass childClass1 = new ChildClass("John1", ' ', "This is child property 1");

childClass.Print();
childClass1.Print();

class ParentClass
{
    public int Id { get; set; }
    public string Name { get; set; }
    public char Example { get; set; }

    public ParentClass(string name, char example)
    {
        this.Name = name;
        this.Example = example;
        Console.WriteLine("This is parent class!");
    }

    public virtual void Print() // virtual, abstract, override
    {
        Console.WriteLine("Print method - parent class!");
    }
}

class ChildClass : ParentClass
{
    public string ChildProperty { get; set; }

    public ChildClass(string name, char example, string childProperty) : base(name, example)
    {
        this.ChildProperty = childProperty;
        Console.WriteLine("This is child class!");
    }

    //public new void Print()
    //{
    //    Console.WriteLine("Print method - child class!");
    //}

    public override void Print()
    {
        Console.WriteLine("Print method - child class!");
    }
}
