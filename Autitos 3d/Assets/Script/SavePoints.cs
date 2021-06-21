
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SavePoints
{

  public static void SavePlayerPoints(saves seconds) {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data.fun";
        FileStream stream = new FileStream(path,FileMode.Create);

        PlayerData data = new PlayerData(seconds);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/data.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

           PlayerData data= formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;

        }
        else
        {
            Debug.LogError("No save data found");
            return null;
        }

    }
}
