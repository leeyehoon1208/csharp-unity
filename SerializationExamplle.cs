using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SerializationExamplle : MonoBehaviour
{
    void Start()
    {
        // User user = new User();
        // user.level = 100;
        // user.name = "chulsoo";

        // FileStream fs = new FileStream("/Users/lee/Desktop/data.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter(); 
        // bf.Serialize(fs, user);
        // fs.Close();

        FileStream fs = new FileStream("/Users/lee/Desktop/data.dat", FileMode.Open);
        User user = (User)bf.Deserialize(fs);
        Debug.Log(user.level);
        Debug.Log(user.name);

    }
}

[System.Serializable]
class User{
    public int level;
    public string name;
}
