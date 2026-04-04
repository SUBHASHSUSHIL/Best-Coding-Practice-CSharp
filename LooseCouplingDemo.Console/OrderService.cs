using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingDemo.Console
{
    public class OrderService
    {

        // This is Bad Practice because OrderService is tightly coupled
        // with these services. Agar inme se koi service change hoti hai to
        // OrderService ko bhi change karna padega, jo ki maintainability aur scalability ke liye problem create karta hai.


        //private EmailService emailService = new EmailService();
        //private SmsService smsService = new SmsService();
        //private PaymentService paymentService = new PaymentService();
        //private Logger logger = new Logger();
        //private DiscountService discountService = new DiscountService();

        //public void ProcessOrder()
        //{
        //    // sab kuch yahi handle kar raha hai 😵
        //}


        // This is Good Practice because OrderService is loosely coupled with these services. Agar inme se koi service change hoti hai to
        private readonly INotificationService notificationService;
        private readonly IPaymentService paymentService;

        public OrderService(INotificationService notificationService,
                            IPaymentService paymentService)
        {
            this.notificationService = notificationService;
            this.paymentService = paymentService;
        }
    }
}
