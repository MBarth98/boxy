using Application.DTOs;
using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class BoxRepository : IBoxRepository
{

    private readonly DatabaseContext _context; 
    
    public BoxRepository(DatabaseContext context)
    {
        _context = context;
    }
    
    public List<Box> GetAllProducts()
    {
        return _context.ProductTable.ToList();
    }

    public Box CreateNewProduct(Box product)
    {
        _context.ProductTable.Add(product);
        _context.SaveChanges();
        return product;
    }

    public Box GetProductById(int id)
    {
        return _context.ProductTable.Find(id) ?? throw new KeyNotFoundException();
    }

    public bool RebuildDB()
    {
        _context.Database.EnsureDeleted();
        return _context.Database.EnsureCreated();
    }
    
    public Box UpdateProduct(Box product)
    {
        _context.ProductTable.Update(product);
        _context.SaveChanges();
        return product;
    }

    public Box DeleteProduct(int id)
    {
        var productToDelete = _context.ProductTable.Find(id) ?? throw new KeyNotFoundException();
        _context.ProductTable.Remove(productToDelete);
        _context.SaveChanges();
        return productToDelete;
    }

    public Box SubtractProduct(int id, int amount)
    {
        throw new NotImplementedException();
    }

    public Box AddProduct(int id, int amount)
    {
        throw new NotImplementedException();
    }
}