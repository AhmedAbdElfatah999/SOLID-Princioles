namespace SOLID_In_C#
{
    /*
    Clients should not be forced
        to depend upon interfaces 
        that they don't use
    */
    public class InterfaceSegregation
    {
      //The Wrong Code
      public interface IEmployee
      {
          public void GetEmployeeDetails();
          public void GetProjectDetails();
      }
      public class CasulaEmployee: IEmployee
      {
          public void GetEmployeeDetails()
          {
              //some Code Here
          }
          public void GetProjectDetails()
          {
              //Why Should I Implement a method That I Does Need ??
              throw new NotImplementedException();
          }
      }
      //The Right Code (If You Need it,Implement It)
      public interface IEmployee2
      {
         public void GetEmployeeDetails(); 
      }
      public interface IProject
      {
          public void GetProjectDetails();
      }
    }
}