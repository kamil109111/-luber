using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Śluber.Models;

namespace Śluber.Controllers
{
    public class TablesController : Controller
    {
        private static Room _room = new Room
        {
            Tables = new List<Table>
            {
                new Table

                {
                    Id=Guid.NewGuid(),
                    Chairs = Enumerable.Range(0, 6).Select(number => new Chair
                        {
                            Position = number, 
                            Id=Guid.NewGuid(),
                        }).ToList(),
                },
                new Table

                {
                    Id=Guid.NewGuid(),
                    Chairs = Enumerable.Range(0, 6).Select(number => new Chair
                        {
                            Position = number,
                            Id=Guid.NewGuid(),
                        }).ToList(),
                },
                new Table

                {
                    Id=Guid.NewGuid(),
                    Chairs = Enumerable.Range(0, 6).Select(number => new Chair
                        {
                            Position = number,
                            Id=Guid.NewGuid(),
                        }).ToList(),
                },
                new Table

                {
                    Id=Guid.NewGuid(),
                    Chairs = Enumerable.Range(0, 6).Select(number => new Chair
                        {
                            Position = number,
                            Id=Guid.NewGuid(),
                        }).ToList(),
                }
            }
        ,
            AvailableGuest = new List<Guest>
            {
                new Guest
                {
                    Id = 1,
                    Name = "Magda",
                    
                },
                new Guest
                {
                    Id = 2,
                    Name = "Witam",
                    
                }
            }
        }; 

        public IActionResult Index()
        {
            return View(_room);
        }
        public IActionResult ChangeNrOfTables(IFormCollection collection)

        {
            //ToDo Dopisać tworzenie stolów i zapisanie do bazy
            return View(nameof(Index),_room);
        }
        public IActionResult AssignGuestToChair(Guid chairId, Guid tableId, int selectedGuestId)
        {
            //ToDo Dopisać dodawanie gości do stolów i zapisanie do bazy
            return View(nameof(Index), _room);
        }
    }
}