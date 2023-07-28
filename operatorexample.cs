using UnityEngine;

public class operatorexample : MonoBehaviour
{
    void Start(){
        int a = 10;
        int b = 2;

        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a % b);

        bool name = true;
        bool name2 = false;

        Debug.Log(name && name2);
        Debug.Log(name || name2);
        Debug.Log(!name);

        int c = 4;
        int d = 6;

        Debug.Log(c < d);
        Debug.Log(c >= d);
        Debug.Log(c == d);
    }
}
