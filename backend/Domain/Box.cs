
namespace Domain;

public class Box
{
    public int Id { get; set; }

    public string ImageUrl { get; set; } = string.Empty;
    public string Description { get; set; } = "No description";

    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Thickness { get; set; }
    public double Weight { get; set; }
}
