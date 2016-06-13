

namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public static class PathStorage
    {
        public static Path Load(string fullFileName)
        {
            Path result3DPath = new Path();
            string filePath = System.IO.Path.Combine(@"..\..\", $"{fullFileName.Trim()}.path3D");
            
            using (StreamReader loader = new StreamReader(filePath))
            {
                string[] allPointsInPath = loader.ReadToEnd().Split(new string[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in allPointsInPath)
                {
                    decimal[] coordinates3D = item.Trim('[', ']', ' ').Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
                    result3DPath.Add(new Point3D(coordinates3D[0], coordinates3D[1], coordinates3D[2]));
                }
            }
            return result3DPath;
        }

        public static void Save(Path path, string fullFileName)
        {
            string fullFilePath = System.IO.Path.Combine(@"..\..\", $"{fullFileName.Trim()}.path3D");
            using (System.IO.StreamWriter writer = System.IO.File.CreateText(fullFilePath))
            {
                writer.Write(path.ToString());
            }
        }
    }
}
