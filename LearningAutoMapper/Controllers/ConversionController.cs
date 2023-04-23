using AutoMapper;
using LearningAutoMapper.DTOs;
using LearningAutoMapper.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LearningAutoMapper.Controllers;

[ApiController]
[Route("[controller]")]
public class ConversionController : ControllerBase {

    private readonly IMapper _mapper;

    public ConversionController(IMapper mapper) {
        _mapper = mapper;
    }

    #region Public methods. Get entities.
    [HttpGet("GetCustomerEntities")]
    public List<Customer> GetCustomerEntities() => GetCustomers();

    [HttpGet("GetProductEntities")]
    public List<Product> GetProductsEntities() => GetProducts();

    [HttpGet("GetOrderEntities")]
    public List<Order> GetOrderEntities() => GetOrders();
    #endregion Public methods. Get entities.

    #region Public methods. Get DTOs.
    [HttpGet("GetCustomersDTOs")]
    public List<CustomerDTO> GetCustomersDTOs() => GetCustomers().Select(_mapper.Map<CustomerDTO>).ToList();

    [HttpGet("GetProductsDTOs")]
    public List<ProductDTO> GetProductsDTOs() => GetProducts().Select(_mapper.Map<ProductDTO>).ToList();

    [HttpGet("GetOrdersDTOs")]
    public List<OrderDTO> GetOrdersDTOs() => GetOrders().Select(_mapper.Map<OrderDTO>).ToList();
    #endregion Public methods. Get DTOs.

    #region Private methods. Fake data.
    private List<Customer> GetCustomers() {
        Customer customer1 = new(1, "Emma", "Smith", "EmmaSmith@gmail.com");
        Customer customer2 = new(2, "Liam", "Johnson", "LiamJohnson@gmail.com");
        Customer customer3 = new(3, "Olivia", "Brown", "OliviaBrown@gmail.com");
        Customer customer4 = new(4, "Noah", "Garcia", "NoahGarcia@gmail.com");
        Customer customer5 = new(5, "Sophia", "Miller", "SophiaMiller@gmail.com");

        return new List<Customer> { customer1, customer2, customer3, customer4, customer5 };
    }

    private List<Product> GetProducts() {
        Product product1 = new(1, "Laptop", 599.99M, "This laptop has a 6 core Intel processor.");
        Product product2 = new(2, "Smartphone", 200M, "This smartphone uses the latest version of Android.");

        return new List<Product> { product1, product2 };
    }

    private List<Order> GetOrders() {
        List<Customer> customers = GetCustomers();
        List<Product> products = GetProducts();

        Order order1 = new(1, products.ElementAt(0), customers.ElementAt(0), 1);
        Order order2 = new(2, products.ElementAt(1), customers.ElementAt(1), 2);
        Order order3 = new(3, products.ElementAt(0), customers.ElementAt(2), 3);
        Order order4 = new(4, products.ElementAt(1), customers.ElementAt(3), 4);
        Order order5 = new(5, products.ElementAt(0), customers.ElementAt(4), 5);
        Order order6 = new(6, products.ElementAt(1), customers.ElementAt(0), 1);

        return new List<Order> { order1, order2, order3, order4, order5, order6 };
    }
    #endregion Private methods. Fake data.
}