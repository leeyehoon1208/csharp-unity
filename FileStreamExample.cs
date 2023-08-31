using UnityEngine;
using System.IO;
public class FileStreamExample : MonoBehaviour
{
    void Start(){
        // FileStream fs = new FileStream("/Users/lee/Desktop/example.txt", FileMode.Create);
        // StreamWriter sw = new StreamWriter(fs);
        // sw.Write("안녕하세요~");
        // sw.Close();

        // fs = new FileStream("/Users/lee/Desktop/example.txt", FileMode.Open);
        // StreamReader sr = new StreamReader(fs);
        // Debug.Log(sr.ReadLine());
        // sr.Close();

        FileStream fs2 = new FileStream("/Users/lee/Desktop/examplebin.txt", FileMode.Create);
        BinaryWriter bw = new BinaryWriter(fs2);
        bw.Write("안녕하세요2~");
        bw.Write(945);
        bw.Close();

        fs2 = new FileStream("/Users/lee/Desktop/examplebin.txt", FileMode.Open);
        BinaryReader br = new BinaryReader(fs2);
        Debug.Log(br.ReadString());
        Debug.Log(br.ReadInt32());
        br.Close();



    }
}
