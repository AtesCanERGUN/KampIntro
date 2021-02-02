using InterfaceAbstractDemo.Entities;
using System.Linq;
using System;
using System.Threading.Channels;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
