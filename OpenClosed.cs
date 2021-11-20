namespace SOLID_In_C#
{
    #Software entities should be open for extension, but closed for modification
    public class OpenClosed
    {

        //Wrong Code (If You Want To Add New PaymentType ,You Will Modify This Code)
        public enum PaymenType { Cash,CreditCard };
        public class PaymentManager
        {
             public PaymenType PaymenType {get; set;}
             public void Pay (Money Money)
             {
                if (PaymentType==PaymentType.Cash)
                {
                    //do Something
                }
                else
                {
                    //do SomeThing
                }
             }
            
        }

        //The Right Code
        //1:Open For Extension
        public class Payment
        {
            public virtual void Pay(Money Money)
            {
                //From Base
            }
        }
        //2:Close(near to Be Modified) For Modification 
        public class CashPayment: Payment
        {
            public override void Pay(Money Money)
            {
                //Pay with Cash
            }
            
        }
        public class CreditPayment: Payment
        {
            public override void Pay(Money Money)
            {
                //Pay with Credit
            }
            
        }
    }
}