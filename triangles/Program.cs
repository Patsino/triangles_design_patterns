// See https://aka.ms/new-console-template for more information
using Serilog;
using triangles.Creator.Factory;
using triangles.EntityClasses.Entities;
using triangles.Helpers;
using triangles.Repository;
using triangles.Repository.RepositoryImpl;

class Program
{
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration().WriteTo.Console().WriteTo.File("log.txt").CreateLogger();
        TriangleRepository repository = new();
        TriangleFactory trianglesFactory = new TriangleFactory(repository);
        string file = "data.txt";
        if (!File.Exists(file))
        {
            Log.Error("file not found.");
            return;
        }


        List<Triangle> triangles =  trianglesFactory.CreateTriangles(file);
        //Console.WriteLine(triangles.Count);
        //Console.WriteLine(triangles[0].ToString());
        //Console.WriteLine(triangles[1].ToString());
        foreach (Triangle triangle in repository.SortTriangles(new IdComparer()))
        {
            Log.Information($"sorted triangle {triangle}");
        }
    }
}