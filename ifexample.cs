using UnityEngine;

public class ifexample : MonoBehaviour
{
    void Start(){
        int number = 10;
        if(number > 12){
            Debug.Log("CORRECT");
        } else if(number < 9){
            Debug.Log("CORRECT");
        } else{
            Debug.Log("맞았습니다");
        }
    }
}
