using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Green_Cloud_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        public double userInput { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet(double text)
        {
            this.userInput = text;
            return Page();
        }

        public void OnPost(double text)
        {
            this.userInput = text;
        }

        public string SayHello()
        {
            return "Hello";
        }
        public string MathProb()
        {
            bool Green = (userInput % 3 == 0);
            bool Cloud = (userInput % 5 == 0);
            bool Zero = (userInput == 0);
            bool Neither = ((userInput % 5 != 0) && (userInput % 3 != 0));
            bool NumError = (userInput < 0);
            double roundUp =(double)Math.Round(userInput);
            bool NumError2 = (userInput != roundUp);
            


            string techComp = NumError ? "Error: Please input a positive integer." :NumError2 ? "Error: Please input a whole number." :
                Green && Cloud ? "Green Cloud" : ((userInput % 3 != 0) && Cloud) ? "Cloud" :
                Green && (userInput % 5 != 0) ? "Green" : Zero ? "0" : $"{ userInput} is not able to be fully divided by 3 or 5. Try Again!";
            return techComp;
            
        }
    }
}
