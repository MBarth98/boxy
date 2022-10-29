using Application.DTOs;
using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class BoxRepository : IBoxRepository
{
    private readonly DatabaseContext m_Context; 
    
    public BoxRepository(DatabaseContext context)
    {
        m_Context = context;
    }
    
    public List<Box> GetAllProducts()
    {
        return m_Context.ProductTable.ToList();
    }

    public Box CreateNewProduct(Box product)
    {
        m_Context.ProductTable.Add(product);
        m_Context.SaveChanges();
        return product;
    }

    public Box GetProductById(int id)
    {
        return m_Context.ProductTable.Find(id) ?? throw new KeyNotFoundException();
    }

    public bool RebuildDB()
    {
        m_Context.Database.EnsureDeleted();
        return m_Context.Database.EnsureCreated();
    }
    
    public Box UpdateProduct(Box product)
    {
        m_Context.ProductTable.Update(product);
        m_Context.SaveChanges();
        return product;
    }

    public Box DeleteProduct(int id)
    {
        var productToDelete = m_Context.ProductTable.Find(id) ?? throw new KeyNotFoundException();
        m_Context.ProductTable.Remove(productToDelete);
        m_Context.SaveChanges();
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