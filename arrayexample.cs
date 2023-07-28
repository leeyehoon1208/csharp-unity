using UnityEngine;

public class arrayexample : MonoBehaviour
{
    int[] number = {100, 200, 300};

    void Start(){
        Debug.Log(number[0]);
        Debug.Log(number[1]);
        Debug.Log(number[2]);

        number[1] = 50;
        Debug.Log(number[1]);
    }
}
