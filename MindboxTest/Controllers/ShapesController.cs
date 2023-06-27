using Microsoft.AspNetCore.Mvc;
using MindboxTest.AreaCalculator.Services;

namespace MindboxTest.Controllers;

[ApiController]
[Route("[controller]")]
public class ShapesController : ControllerBase
{
    private readonly ILogger<ShapesController> _logger;
    private readonly IShapeService _shapeService;

    public ShapesController(ILogger<ShapesController> logger, IShapeService shapeService)
    {
        _logger = logger;
        _shapeService = shapeService;
    }

    [HttpGet("GetCircleArea")]
    public IActionResult GetCircleArea(double radius)
    {
        return Ok(_shapeService.GetCircleArea(radius));
    }
    
    [HttpGet("GetTriangleArea")]
    public IActionResult GetTriangleArea(double sideA, double sideB, double sideC)
    {
        return Ok(_shapeService.GetTriangleArea(sideA, sideB, sideC));
    }
    
    [HttpGet("IsRightTriangle")]
    public IActionResult IsRightTriangle(double sideA, double sideB, double sideC)
    {
        return Ok(_shapeService.IsRightTriangle(sideA, sideB, sideC));
    }
}