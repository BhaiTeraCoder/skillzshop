using Microsoft.AspNetCore.Mvc;
using skillzshop.Data;
using skillzshop.Models;

namespace skillzshop.Controllers
{
    public class PaymentController : Controller
    {

        private readonly AppDbContext _context;
        public PaymentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Purchase(int skillId)
        {
            // Code to process payment and complete purchase goes here
            // You could use a payment gateway API, like Stripe or PayPal, to handle the payment process

            // Redirect the user to a thank you page after the purchase is complete
            return RedirectToAction("ThankYou", "Payment");
        }


        public IActionResult ThankYou()
        {
            // Code to display thank you page after the purchase is complete goes here
            return View();
        }
    }
}
