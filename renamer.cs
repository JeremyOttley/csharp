using System.IO;
using System;

public class Renamer {
	  public static bool isImage(string filename) {
      switch(Path.GetExtension(filename).ToLower()) 
      {
        case ".jpg":
          return true;
        case ".png":
          return true;
        case ".bmp":
          return true;
        case ".jpeg":
          return true;
        default:
          return false;
      }
    }

public static void Main(string[] args)
		{
      string f = "file.bmp";
			bool result = Renamer.isImage(f);
			Console.WriteLine(result);
		}
	}
