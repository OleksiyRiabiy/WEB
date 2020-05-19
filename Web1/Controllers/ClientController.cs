using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Web1.Models;

namespace Web1.Controllers
{
    public class ClientController:Controller
    {
        Context context;

        public ClientController(Context context)
        {
            this.context = context;
        }

        [HttpGet("client")]
        public ActionResult Index()
        {
            IEnumerable<Client> clients = context.Clients.ToList();
            return View(clients);
        }
    }
}