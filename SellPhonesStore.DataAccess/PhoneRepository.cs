using SellPhonesStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.DataAccess
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly SellPhonesStoreDBContext _context=new SellPhonesStoreDBContext();
        public long SavePhone(Phone phone)
        {
            _context.Phones.Add(phone);

            _context.SaveChanges();
            return phone.PhoneId;
        }

        public long SaveCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer.CustomerId;
        }

        public long SaveOrder(CustomerOrder order)
        {
            _context.CustomerOrders.Add(order);
            _context.SaveChanges();
            return order.OrderId;
        }

        public long SaveOrderedPhone(OrderedPhone orderPhone, long orderId)
        {
            var customerOrder = _context.CustomerOrders.Find(orderId);
            if (customerOrder == null)
            {
                throw new ArgumentException("Invalid Order ID");
            }
            customerOrder.OrderedPhones.Add(orderPhone);
            _context.SaveChanges();
            return orderPhone.OrderedPhoneId;
        }

        public List<CustomerOrder> GetCustomerOrders(long customerId)
        {
            return _context.CustomerOrders
                .Where(order => order.CustomerId == customerId)
                .ToList();
        }

        public List<CustomerOrder> GetAllCustomerOrders()
        {
            return _context.CustomerOrders.ToList();
        }
    }
}
