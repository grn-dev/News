using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using News.Domain.Contract.DataBase;

namespace News.Ui.Web.Areas.Admin.Controllers
{
    [Area ("admin")]
    public class KeywordController : Controller
    {
        //Ikeywordrepository _ikeywordrepository;

        //IkeywordRepositori keywordRepositori;

        public IActionResult Index()
        {
           //var keylist = keywordRepositori.GetAll();
           return View(); //keylist
        }
    }
}