using System;
using System.Text;

namespace Problem_15.Drawing_tool
{
    public class Rectangle : CorDraw
    {
        public Rectangle(int sideA, int sideB)
        {
            if (sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentException($"Square side cannot be less than 1(one)");

            }
            this.SideA = sideA;
            this.SideB = sideB;
        }
        public int SideA { get; set; }
        public int SideB { get; set; }
        public override string Draw()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"|{new string('-', this.SideA)}|");
            for (int i = 0; i < this.SideB - 2; i++)
            {
                sb.Append('|');
                sb.Append(new string(' ', this.SideA));
                sb.Append('|');
                sb.AppendLine();
            }
            sb.AppendLine($"|{new string('-', this.SideA)}|");
            return sb.ToString().TrimEnd();
        }
    }
}
