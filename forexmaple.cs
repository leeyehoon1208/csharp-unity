using UnityEngine;

public class forexmaple : MonoBehaviour
{
    void Start(){
        for(int i = 0; i <10; i++){
            Debug.Log(i);
        }

        for(int i = 0; i <= 10; i +=2){
            Debug.Log(i);
        }
        for(int i = 1; i <= 11; i +=2){
            Debug.Log(i);
        }
    }
}
