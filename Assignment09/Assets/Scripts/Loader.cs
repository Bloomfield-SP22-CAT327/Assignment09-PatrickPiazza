using UnityEngine;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Loader
{
    public static List<Data> saveFiles = new List<Data>();

    public static void Save()
    {
        Loader.saveFiles.Add(Data.display);
        BinaryFormatter bff = new BinaryFormatter();
        FileStream saved = File.Create(Application.persistentDataPath + Path.DirectorySeparatorChar + "saveFiles.gd");
        bff.Serialize(saved, Loader.saveFiles);
        saved.Close();
    }
    public static void Load()
    {
        if(File.Exists(Application.persistentDataPath + Path.DirectorySeparatorChar + "saveFiles.gd"))
        {
            BinaryFormatter bff = new BinaryFormatter();
            FileStream saved = File.Open(Application.persistentDataPath + Path.DirectorySeparatorChar + "saveFiles.gd", FileMode.Open);
            Loader.saveFiles = (List<Data>)bff.Deserialize(saved);
            saved.Close();
        }
    }
}
