using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangles.Helpers
{
    public class Parser
    {
        public string[] ReadFile(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return null;
            }
        }
    }
}
