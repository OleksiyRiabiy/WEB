using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web1.Models;

namespace Web1.Controllers
{
    [Authorize]
    public class StateController : Controller
    {
        Context context;

        public StateController(Context context)
        {
            this.context = context;
        }

        [HttpGet("state")]
        public IActionResult Index(string sort)
        {
            IEnumerable<State> states;

            if (User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value.Equals("admin"))
            {
                states = context.States.ToList();
            }
            else
            {
                states = (from state in context.States
                    join sc in context.StateClients on state.id equals sc.id
                    where sc.id == context.Clients.FirstOrDefault(c => c.email == User.Identity.Name).id
                    select state).AsEnumerable();
            }


            switch (sort)
            {
                case "id":
                    states = states.OrderBy(s => s.id);
                    break;
                case "name":
                    states = states.OrderBy(s => s.name);
                    break;
                case "area":
                    states = states.OrderBy(s => s.area);
                    break;
                case "population":
                    states = states.OrderBy(s => s.population);
                    break;
                case "language":
                    states = states.OrderBy(s => s.language);
                    break;
                default:
                    states = states.OrderBy(s => s.id);
                    break;
            }


            return View(states);
        }

        [HttpGet("state/{id:int}")]
        public IActionResult getOneState(int id)
        {
            if (context.StateClients.FirstOrDefault(u => u.state_id == id) == null &&
                User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value != "admin")
            {
                return NotFound();
            }

            State addressItem = context.States.Find(id);
            if (addressItem == null)
            {
                return NotFound();
            }

            return View(addressItem);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(State s)
        {
            
            if (ModelState.IsValid )
            {

                State state = new State()
                {
                    name =s.name, area = s.area, population =s.population, language = s.language
                };
              
                context.States.Add(state);
                context.SaveChanges();
                string userEmail = User.Identity.Name;
                Client client = context.Clients.FirstOrDefault(u => u.email == userEmail);

                if (client != null)
                    context.StateClients.Add(new StateClient()
                    {
                        state_id = state.id, client_id = client.id
                    });
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(s);
            }
        }

        [HttpGet]
        public ActionResult deleteState(int id)
        {
           

            State s = context.States.Find(id);
            if (s != null)
            {
                return View(s);
              
            }
            return NotFound();
        }

        [HttpPost, ActionName("deleteState")]
        public ActionResult DeleteConfirmed(int id)
        {
            State b =context.States.Find(id);
            if (b == null)
            {
                return NotFound();
            }

            context.States.Remove(b);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult editState(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            State state = context.States.Find(id);
            if (state != null)
            {
                return View(state);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult editState(State editState)
        {
            if (ModelState.IsValid)
            {
                State curState = context.States.Find(editState.id);
                curState.id = editState.id;
                curState.name = editState.name;
                curState.area = editState.area;
                curState.population = editState.population;
                curState.language = editState.language;

                context.Entry(curState).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(editState);
            }
        }
    }
}