using BrokerManagementApp.DAL.Interface;
using BrokerManagementApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrokerManagementApp.DAL.Repository
{
    public class BrokerManagementService : IBrokerInterface
    {
        private IBrokerRepository _repo;
        public BrokerManagementService(IBrokerRepository repo)
        {
            this._repo = repo;
        }

        public Broker AddBroker(Broker broker)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Broker DeleteBroker(int brokerId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public IEnumerable<Broker> GetAllBrokers()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Broker GetBrokerById(int brokerId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Broker UpdateBroker(Broker broker)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}