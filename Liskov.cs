namespace SOLID_In_C#
{
    /*
    A subclass should behave in such a 
        way that it will not cause problems 
        when used instead of the 
        superclass
    */
    public class Liskov
    {
        //Wrong Code 
        public class Employee
        {
            public virtual void GetProjectDetails()
            {
                Console.Writline("Hello From The Base Class");
            }
        }
        public class ContarctualEmployee: Employee
        {
            public override void GetProjectDetails()
            {
                //this will broke the base class
                Console.Writline("Hello From The Contractual Class");
            }

        }
        //The Right Code
        public class CasualEmployee: Employee
        {
            public override void GetProjectDetails()
            {
                //this will Not broke the base class
                base.GetProjectDetails();
                Console.Writline("Hello From The Casual Class");
            }

        }
    }
}