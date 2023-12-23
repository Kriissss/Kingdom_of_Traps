using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Serializer
{
    public static void SavePlayer(GameManager progress)
    {
        //creating a formatter
        BinaryFormatter formatter = new BinaryFormatter();

        //path of the save file
        string path = Application.persistentDataPath + "/Progres.bin";
        
        //creating the file
        FileStream stream = new FileStream(path, FileMode.Create);

        //access the data
        PlayerData data = new PlayerData(progress);

        //write into file
        formatter.Serialize(stream, data);

        //close file
        stream.Close();
    }

    public static PlayerData LoadProgress()
    {
        string path = Application.persistentDataPath + "/Progres.bin";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;

            stream.Close();
            Debug.Log("Load Success!");
            return data;
        }
        else
        {
            Debug.Log("Error Load data!");
            return null;
        }
    }
}
