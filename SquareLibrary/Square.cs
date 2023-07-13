namespace SquareLibrary;

public static class Square
{
    public static double GetSquare(Figure figure, params double[] data)
    {
        if (figure == Figure.Triangle)
        {
            if (data.Length != 3)
            {
                throw new ArgumentException("Неверное количество сторон треугольника");
            }

            return TriangleSquare(data[0], data[1], data[2]);
        }
        else if (figure == Figure.Circle)
        {
            if (data.Length != 1)
            {
                throw new ArgumentException("Неверное количество радиусов треугольника");
            }

            return CircleSquare(data[0]);
        }
        else
        {
            throw new ArgumentException("Заданной фигуры не существует");
        }
    }

    private static double TriangleSquare(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentOutOfRangeException("sides", "Стороны треугольника не могут быть неположительными");
        }

        if (a + b <= c || a + c <= b || c + b <= a)
        {
            throw new ArgumentOutOfRangeException("sides", "Сумма двух сторон треугольника должна быть больше третьей стороны");
        }

        if (a > c)
        {
            var temp = a;
            a = c;
            c = temp;
        }

        if (b > c)
        {
            var temp = b;
            b = c;
            c = temp;
        }

        if (a * a + b * b == c * c)
        {
            return a * b / 2;
        }
        else
        {
            var p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    private static double CircleSquare(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException("sides", "Радиус круга не может быть неположительными");
        }

        return Math.PI * radius * radius;
    }
}


/* 
SELECT Products."Name", Categories."Name"
FROM Products LEFT JOIN ProductCategories
ON Products.Id = ProductCategories.ProductId LEFT JOIN Categories
ON ProductCategories.CategoryId = Categories.Id;
*/