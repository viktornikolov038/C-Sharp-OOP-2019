using System;
using System.Text;

namespace Problem_15.Drawing_tool
{
    public class Square : CorDraw
    {
        public Square(int sideA)
        {
            if (sideA <= 0)
            {
                throw new ArgumentException($"Square side cannot be less than 1(one)");
            }
            this.SideA = sideA;
        }
        public int SideA { get; set; }

        public override string Draw()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"|{new string('-',this.SideA)}|");
            for (int i = 0; i < this.SideA - 2; i++)
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
