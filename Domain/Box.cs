using UnitsNet;

namespace Domain;

public class Box
{
    public int Id { get; set; } = -1;

    public List<string> Tags { get; set; } = new List<string>();
    public string ImageUrl { get; set; } = string.Empty;
    public string Description { get; set; } = "No description";

    public int Quantity { get; set; } = 0;
    public float Price { get; set; } = float.MaxValue; 

    /*
        todo: optimize json serialization

        public Length Height { get; set; }
        public Length Width { get; set; }
        public Length Depth { get; set; }
        public Length Thickness { get; set; }
        public Mass Weight { get; set; }
    */
    public double Height { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Thickness { get; set; }
    public double Weight { get; set; }
}
