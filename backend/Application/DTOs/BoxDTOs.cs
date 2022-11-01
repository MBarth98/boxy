namespace Application.DTOs;

public class CreateBoxDTO
{
    public string ImageUrl { get; set; } = string.Empty;
    public string Description { get; set; } = "No description"; 

    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Thickness { get; set; }
    public double Weight { get; set; }
}

public class UpdateBoxDTO
{
    public string? ImageUrl { get; set; } = null;
    public string? Description { get; set; } = null; 

    public double? Height { get; set; } = null;
    public double? Width { get; set; } = null;
    public double? Depth { get; set; } = null;
    public double? Thickness { get; set; } = null;
    public double? Weight { get; set; } = null;
}
