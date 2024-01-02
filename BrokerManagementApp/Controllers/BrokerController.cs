using Microsoft.AspNetCore.Mvc;
using BrokerManagementApp.DAL.Interface;
using BrokerManagementApp.Models;

namespace BrokerManagementApp.Controllers
{
    public class BrokerController : Controller
    {
        private readonly IBrokerInterface _brokerRepository;

        public BrokerController(IBrokerInterface brokerRepository)
        {
            _brokerRepository = brokerRepository;
        }

        // GET: /Broker/Index
        public IActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Broker/Details/{id}
        public IActionResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Broker/Create
        public IActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Broker/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Broker broker)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Broker/Edit/{id}
        public IActionResult Edit(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Broker/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Broker updatedBroker)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // GET: /Broker/Delete/{id}
        public IActionResult Delete(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        // POST: /Broker/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
