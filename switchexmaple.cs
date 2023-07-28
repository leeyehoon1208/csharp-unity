using UnityEngine;

public class switchexmaple : MonoBehaviour
{
    void Start()
    {
        int number = 2;
        switch(number){
            case 1: 
                Debug.Log("값이 1입니다");
            break;
            case 2: 
                Debug.Log("값이 2입니다");
            break;
            case 4: 
                Debug.Log("값이 4입니다");
            break;
            case 8: 
                Debug.Log("값이 8입니다");
            break;
            default:
                Debug.Log("값이 없습니다");
            break;           
        }

        // if문으로 바꿔서, 변환해서 쓴거

        if(number ==1){
            Debug.Log("값이 1입니다");
        } else if(number == 2){
            Debug.Log("값이 2입니다");
        } else if(number ==4){
            Debug.Log("값이 4입니다");
        } else{
            Debug.Log("값이 없습니다.");
        }
    }
}
