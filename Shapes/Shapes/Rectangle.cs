using System;

namespace Calculator
{
    public class Rectangle
    {
        /// <summary>
        /// width of the rectangle.
        /// </summary>
        private int width;

        /// <summary>
        /// height of the rectangle.
        /// </summary>
        private int height;

        /// <summary>
        /// color of the rectangle.
        /// </summary>
        private Color color;

        /// <summary>
        /// indicates whether the rectangle is transparent or not.
        /// </summary>
        private bool isTransparent;

        /// <summary>
        /// Constructor for class Rectangle.
        /// </summary>
        /// <param name="width">width of the rectangle.</param>
        /// <param name="height">height of the rectangle.</param>
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Constructor for class Rectangle.
        /// It calls the constructor within THIS class which has two parameters.
        /// </summary>
        /// <param name="width">width of the rectangle.</param>
        /// <param name="height">height of the rectangle.</param>
        /// <param name="color">color of the rectangle.</param>
        public Rectangle(int width, int height, Color color) : this(width, height)
        {
            this.color = color;
        }
        /// <summary>
        /// Yet another Constructor for class Rectangle.
        /// It calls the constructor within THIS class which has two parameters.
        /// </summary>
        /// <param name="width">width of the rectangle.</param>
        /// <param name="height">height of the rectangle.</param>
        /// <param name="isTransparent">true, if the rectangle is transparent.</param>
        public Rectangle(int width, int height, bool isTransparent) : this(width, height)
        {
            this.isTransparent = isTransparent;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Calls first constructor
            Rectangle rechtangle1 = new Rectangle(10, 18);

            // Calls second constructor
            Rectangle rechtangle2 = new Rectangle(10, 18, Color.Green);

            // Calls third constructor
            Rectangle rechtangle3 = new Rectangle(10, 18, true);
        }
    }
