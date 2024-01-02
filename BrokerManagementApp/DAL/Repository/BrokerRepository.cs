using BrokerManagementApp.DAL.Interface;
using BrokerManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BrokerManagementApp.DAL.Repository
{
    public class BrokerRepository : IBrokerRepository
    {
        private BrokerDbContext _context;
        public BrokerRepository(BrokerDbContext Context)
        {
            this._context = Context;
        }
      
        public Broker GetBrokerById(int brokerId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Broker> GetAllBrokers()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Broker AddBroker(Broker broker)
        {
            //write your code here
            throw new NotImplementedException();
        }


        public Broker UpdateBroker(Broker updatedBroker)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Broker DeleteBroker(int brokerId)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
