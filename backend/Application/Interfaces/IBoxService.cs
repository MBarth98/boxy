
using Application.DTOs;

namespace Domain.Interfaces;

public interface IBoxService
{
    public List<Box> GetAllBoxes();
    public Box CreateNewBox(CreateBoxDTO dto);
    public Box GetById(int id);
    public bool RebuildDB();
    public Box UpdateBox(int id, Box product);
    public Box DeleteBox(int id);
}