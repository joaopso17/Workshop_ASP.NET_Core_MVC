using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWeb_MVC.Data;
using SalesWeb_MVC.Models;
using SalesWeb_MVC.Services;

namespace SalesWeb_MVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _SellerService;

        public SellersController(SellerService sellerService)
        {
            _SellerService = sellerService;
        }

        public async Task<IActionResult> Index()
        {
            var list = _SellerService.FindAll();
            return View(list);
        }


    }
}
