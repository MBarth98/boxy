using Application.DTOs;
using Domain;
using Domain.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BoxController : ControllerBase
{
    public BoxController(IBoxService productService) => m_Service = productService;

    [HttpGet]
    public ActionResult<List<Box>> GetAll()
    {
        return m_Service.GetAllBoxes();
    }

    [HttpPost]
    public ActionResult<Box> Create([FromBody] CreateBoxDTO dto)
    {
        try
        {
            return Created("", m_Service.CreateNewBox(dto));
        }
        catch (ValidationException v)
        {
            return BadRequest(v.Message);
        }
        catch (System.Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }

    [HttpGet]
    [Route("{id}")]
    public ActionResult<Box> GetById([FromRoute] int id)
    {
        try
        {
            return m_Service.GetById(id);
        }
        catch (KeyNotFoundException) 
        {
            return NotFound("No product found at ID " + id);
        } 
        catch (Exception e)
        {
            return StatusCode(500, e.ToString());
        }
    }

    [HttpGet]
    [Route("RebuildDB")]
    public void RebuildDB()
    {
        m_Service.RebuildDB();
    }

    [HttpPut]
    [Route("{id}")]
    public ActionResult<Box> Update([FromRoute]int id, [FromBody] Box product)
    {
        try
        {
            return Ok(m_Service.UpdateBox(id, product));
        } 
        catch (KeyNotFoundException) 
        {
            return NotFound("No box found with ID " + id);
        } 
        catch (Exception e)
        {
            return StatusCode(500, e.ToString());
        }
    }

    [HttpDelete]
    [Route("{id}")]
    public ActionResult<Box> Delete([FromRoute] int id)
    {
        try
        {
            return Ok(m_Service.DeleteBox(id));
        } 
        catch (KeyNotFoundException) 
        {
            return NotFound("No box found with ID " + id);
        } 
        catch (Exception e)
        {
            return StatusCode(500, e.ToString());
        }
    }

    private IBoxService m_Service;
}