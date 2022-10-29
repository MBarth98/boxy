using Application.DTOs;
using Domain;

namespace Application.Interfaces;

public interface IBoxRepository
{
    public List<Box> GetAllProducts();
    public Box CreateNewProduct(Box product);
    public Box GetProductById(int id);
    public bool RebuildDB();
    public Box UpdateProduct(Box product);
    public Box DeleteProduct(int id);
    public Box SubtractProduct(int id, int amount);
    public Box AddProduct(int id, int amount);
}