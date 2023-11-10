using Microsoft.AspNetCore.Mvc;
using FriendsApp.Models; 

namespace FriendsApp.Controllers
{
    public class FriendsController : Controller
    {
        public static List<Friend> friends = new List<Friend>(); 
        public IActionResult List()
        {
            return View(friends);
        }
        static FriendsController()
        {
            friends.Add(new Friend
            {
                Number = 1,
                Name = "Ali",
                Image  = ".././Img/p1.png"
            });
            friends.Add(new Friend
            {
                Number = 2,
                Name = "Ana",
                Image = ".././Img/p2.png"
            });
            friends.Add(new Friend
            {
                Number = 3,
                Name = "Baran",
                Image = ".././Img/p3.png"
            });
            friends.Add(new Friend
            {
                Number = 4,
                Name = "Bahram",
                Image = ".././Img/p4.png"
            });
            friends.Add(new Friend
            {
                Number = 5,
                Name = "Sara",
                Image = ".././Img/p5.png"
            });
            friends.Add(new Friend
            {
                Number = 6,
                Name = "Sina",
                Image = ".././Img/p6.png"
            });
            friends.Add(new Friend
            {
                Number = 7,
                Name = "Saba",
                Image = ".././Img/p7.png"
            });
            friends.Add(new Friend
            {
                Number = 8,
                Name = "Anne",
                Image = ".././Img/p8.png"
            });
            friends.Add(new Friend
            {
                Number = 9,
                Name = "Radin",
                Image = ".././Img/p9.png"
            });
            friends.Add(new Friend
            {
                Number = 10,
                Name = "Mina",
                Image = ".././Img/p10.png"
            });
        }
        public IActionResult Detail(int id)
        {
            var friend = friends.FirstOrDefault(f => f.Number == id);
            if (friend == null)
            {
                return NotFound();
            }
            return View(friend);
        }

 
        [HttpGet]
        public IActionResult NewPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewPage(Friend friend)
        {
            friends.Add(friend);
            return RedirectToAction("List");
        }

    }
}
