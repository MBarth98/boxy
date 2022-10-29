using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain;
using Domain.Interfaces;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace Application;

public class BoxService : IBoxService
{
    public BoxService(IBoxRepository repo, IValidator<CreateBoxDTO> dto, IValidator<Box> product, IMapper mapper) =>
    (m_Repository, m_ValidatorDTO, m_ValidatorBase, m_Mapper) = (repo, dto, product, mapper);

    public List<Box> GetAllBoxes() => m_Repository.GetAllProducts();
    public Box GetById(int id) => m_Repository.GetProductById(id);
    public Box DeleteBox(int id) => m_Repository.DeleteProduct(id);
    public Box AddBox(int id, int amount) => m_Repository.AddProduct(id, amount);
    public Box SubtractBox(int id, int amount) => m_Repository.SubtractProduct(id, amount);

    public Box CreateNewBox(CreateBoxDTO dto) 
    {
        var validation = m_ValidatorDTO.Validate(dto);
        if (!validation.IsValid)
            throw new ValidationException(validation.ToString());

        return m_Repository.CreateNewProduct(m_Mapper.Map<Box>(dto));
    }

    public Box UpdateBox(int id, Box product)
    {
        if (id != product.Id)
            throw new ValidationException("ID in body and route are different");
            
        var validation = m_ValidatorBase.Validate(product);
        if (!validation.IsValid)
            throw new ValidationException(validation.ToString());

        return m_Repository.UpdateProduct(product);
    }

    public void RebuildDB() => m_Repository.RebuildDB();
    
    private readonly IBoxRepository m_Repository;
    private readonly IValidator<CreateBoxDTO> m_ValidatorDTO;
    private readonly IValidator<Box> m_ValidatorBase;
    private readonly IMapper m_Mapper;
}