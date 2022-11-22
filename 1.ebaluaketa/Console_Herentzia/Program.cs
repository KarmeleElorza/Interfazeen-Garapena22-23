using Console_Herentzia;
try
{
    A objA = new A();
    objA.Prop1 = "pepe";
    objA.Prop2 = "20";
    objA.Erakutsi();

    B objB = new B();
    objB.Prop1 = "izaskun";
    objB.Prop2 = "47";
    objB.Prop3 = "Kortabitarte";
    objB.Erakutsi();

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
