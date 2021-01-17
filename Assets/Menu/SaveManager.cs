using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.Runtime.Serialization;

public class SaveManager : MonoBehaviour
{
    public void Awake()
    {
        //_level = GameObject.FindObjectOfType<Level>();
    }

    public void Save()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/save.dat", FileMode.OpenOrCreate);

        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(file,_level)
        }
        catch(SerializationException e)
        {
            Debug.LogError("There was issue serializing this data: " + e.Message);
        }
        finally
        {
            file.Close();
        }
    }

    public void Load()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/save.dat", FileMode.Open);

        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            //_level = (Level)formatter.Deserialize(file);
        }
        catch (SerializationException e)
        {
            Debug.LogError("Error deserialize data: " + e.Message);
        }
        finally
        {
            file.Close();
        }
    }
}
