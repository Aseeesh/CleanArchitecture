using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Clean.Domain;
using Clean.Domain.Entities;

namespace Clean.Application.customerData.Queries.GetCustomersList
{
    public class GetCustomersListQueryHandler : IRequestHandler<GetCustomersListQuery, CustomersListViewModel>
    {
        private readonly NorthwindTradersContext _context;

        public GetCustomersListQueryHandler(NorthwindTradersContext context)
        {
            _context = context;
        }

        public async Task<CustomersListViewModel> Handle(GetCustomersListQuery request, CancellationToken cancellationToken)
        {
            var vm = new CustomersListViewModel
            {
                Customers = await _context.Customers.Select(c =>
                    new CustomerLookupModel
                    {
                        Id = c.CustomerId,
                        Name = c.CompanyName
                    }).ToListAsync(cancellationToken)
            };

            return vm;
        }
    }
}
