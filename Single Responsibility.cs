namespace SOLID_In_C#
{
    #A class should have one and only one reason to change
    public class Single Responsibility
    {
        //The Wrong Code
        public class Employee
        {  
            public void EmployeeCalc()
            {
                
            }
            public void EmployeeSave()
            {

            }
            
        }
        //The Right Code 
        public class Employee2
        {
            public void EmployeeCalc()
            {
                
            } 
        } 
        public class EmployeeRepository
        {
            public Employee EmployeeSave()
            {

            } 
        }
    }
}