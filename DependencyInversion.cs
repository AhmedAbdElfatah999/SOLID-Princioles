namespace SOLID_In_C#
{
        /*
        “High-level modules should not 
        depend on low-level modules. Both 
        should depend on abstractions.”
        
        “Abstractions should not depend upon 
        details. Details should depend upon 
        abstractions.”
        */
    public class DependencyInversion
    {
        //The Wrong Email
        public class Email
        { 
            public void SendEmail()
            {

            }
            
        }
        pubic class Notification
        {
            //And if I need to send a notification by SMS? You need to change this.
            private Email _email;
            //the right code is to make Constructor injection ,Property injection ,Method injection
            public Notification()
            {
                _email=new Email ();
            }
            public void PromotionalNotification()
            {
                _email.SendEmail();
            }

        }
        //The Right Code
        public interface IMessanger
        {
            void SendMeassage();
        }
        public class Email :IMessanger
        {
            public void SendMeassage()
            {
              //Implement The Email Code
            }
        }
        public class SMS :IMessanger
        {
            public void SendMeassage()
            {
              //Implement The SMS Code
            }
        }
        public IMessanger _imessanger;
        public IMessanger MessageService
        {
            private get;
            private set
            {
                _imessanger=value;
            }
        }
    }
}