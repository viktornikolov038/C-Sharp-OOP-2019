using System.Text;

namespace Problem_10.Car_Salesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            sb.AppendLine(this.Engine.Displacement == null
                ? $"    Displacement: n/a"
                : $"    Displacement: {this.Engine.Displacement}");
            sb.AppendLine(this.Engine.Efficiency == null
                ? $"    Efficiency: n/a"
                : $"    Efficiency: {this.Engine.Efficiency}");
            sb.AppendLine(this.Weight == null
                ? $"  Weight: n/a"
                : $"  Weight: {this.Weight}");
            sb.AppendLine(this.Color == null
                ? $"  Color: n/a"
                : $"  Color: {this.Color}");

            return sb.ToString();
        }
    }
}
