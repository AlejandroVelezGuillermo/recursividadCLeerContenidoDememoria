using System.IO;
using System;

    Console.Write("Ingresa la ruta de la memoria USB: ");
    string usbPath = Console.ReadLine();

    if (Directory.Exists(usbPath))
    {
        Console.WriteLine("Contenido de la memoria USB:");

        string[] directories = Directory.GetDirectories(usbPath);
        foreach (string directory in directories)
        {
            Console.WriteLine($"[Directorio] {Path.GetFileName(directory)}");
        }

        string[] files = Directory.GetFiles(usbPath);
        foreach (string file in files)
        {
            Console.WriteLine($"[Archivo] {Path.GetFileName(file)}");
        }
    }
    else
    {
        Console.WriteLine("La ruta de la memoria USB no es válida.");
    }
