using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Intro.Controllers
{
    public class AboutController
    {
        public string Index()
        {
            return "Salam P130";
        }

        public int Age()
        {
            return 21;
        }


    }
}
