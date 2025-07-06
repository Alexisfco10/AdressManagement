using Application.Dtos.Address;
using Application.Repository;
using Application.Shared.Mappers.Interface;
using Domain.Models;

namespace Application.Services;

public class AddressService(IRepository<Address> repository, IMapper<Address, AddressDto, AddressInsert, AddressUpdate> mapper) 
    : BaseService<Address, AddressDto, AddressInsert, AddressUpdate>(repository, mapper)
{
    
}