using UnityEngine;

public class foreachexmaple : MonoBehaviour
{
    int[] numbers = {1,2,3,4,5};

    void Start(){
        foreach(int number in numbers){
            Debug.Log(number);
        }

        for(int i = 0; i < numbers.Length; i ++){
            Debug.Log(numbers[i]);
        }
    }
}
