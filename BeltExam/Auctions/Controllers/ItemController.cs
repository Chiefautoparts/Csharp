using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Auctions.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Auctions.Controllers
{
    public class ItemController : Controller
    {
        private AuctionsContext _context;
        public ItemController(AuctionsContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Auction/Current")]
        public IActionResult Current(int ItemNum)
        {
            if (ItemNum != (int)HttpContext.Session.GetInt32("UserId"))
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }
            List<Item> AllItems = _context.Items.OrderByDescending(Item => Item.CreatedAt).ToList();
            ViewBag.AllItems = AllItems;
            Console.WriteLine(ViewBag.AllItems.Count);
            ViewBag.Wallet = 1000;
            foreach (Item bought in AllItems)
            {
                ViewBag.Wallet -= bought.Price;
            }
            ViewBag.UserItem = _context.Users.SingleOrDefault(user => user.UserId == ItemNum).FirstName;
            return View("Current");

        }
        [HttpGet]
        [Route("AddItem")]
        public IActionResult Create(ItemViewModels model)
        {
                if (ModelState.IsValid)
                {
                    Item NewItem = new Item
                    {
                        Name = model.Name,
                        Description = model.Description,
                        Price = model.Price,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        Expires = DateTime.UtcNow.AddDays(7)
                    };
                    _context.Add(NewItem);
                    _context.SaveChanges();
                    NewItem = _context.Items.SingleOrDefault(Item => Item.Name == NewItem.Name);
                    HttpContext.Session.SetInt32("ItemId", NewItem.ItemId);
                    return RedirectToAction("Current", "Auction", new { ItemNum = HttpContext.Session.GetInt32("ItemId")});
                }
                else
                {
                    return View("Current", model);
                }
            }
        }

    }