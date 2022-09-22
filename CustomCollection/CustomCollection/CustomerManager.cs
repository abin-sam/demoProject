using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    internal class CustomerManager:IEnumerable<Customer>
    {
        private List<Customer> lcst = null;

        public CustomerManager()
        {
            lcst = new List<Customer>();
        }

        public void AddCustomer(Customer cst)
        {
            lcst.Add(cst);
        }
        public List<Customer> getallCustomer()
            {
            return lcst;
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            return lcst.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
