// See https://aka.ms/new-console-template for more information
using triangles.Creator.Factory;
using triangles.EntityClasses.Entities;
using triangles.Helpers;

class program
{
    static void Main(string[] args)
    {
        TriangleFactory trianglesFactory = new TriangleFactory();

        List<Triangle> triangles =  trianglesFactory.CreateTriangles("data.txt");
        //Console.WriteLine(triangles.Count);
        Console.WriteLine(triangles[0].ToString());
    }
}