using UnityEngine;
using System;
public class ActionFunExample : MonoBehaviour
{
    

    void Start()
    {
        Action<string> del = Printmessage;
        Action act = PrintHello;
        Func<int, int, string> acts2 = Mult;
        del("Hi~");
        act();
        Debug.Log(acts2(7,3)); // 21

        // 람다식을 이용해 더 짧게 
        // Func<int, int, string> func = (a,b) => a * b;
        // Debug.Log(func(3,7)); // 21
    }

    void Printmessage(string message)
    {
        Debug.Log(message);
    }

    void PrintHello(){
        Debug.Log("Hello");
    }
    string Mult(int a, int b){
        return (a * b).ToString();
    }   
}
