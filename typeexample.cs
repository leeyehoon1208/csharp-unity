using UnityEngine;

public class typeexample : MonoBehaviour
{
    int a =1;
    long b = 1000;
    void Start(){

        a = (int)b;
        Debug.Log(a);
    }
}
