using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Sixth.Models
{
    public class Node
    {
        [Key]
        public int Id { get; set; }

        public int Left { get; set; }

        public int Top { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int ZIndex { get; set; }

        public string Text { get; set; }

        public string Color { get; set; }
    }
}