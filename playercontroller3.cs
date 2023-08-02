using UnityEngine;

public class playercontroller3 : MonoBehaviour
{
   
    void Update()
    {
       if (Input.GetKey(KeyCode.A)){
        Debug.Log("A가 눌렸다");   //- a가 눌릴때마다 입력을 받아온다. a가 눌릴 때마다 getkey는 true를 반환한다.

    if (Input.GetKey(KeyCode.A)){
        transform.Translate(0.01f,0,0);  // 이 코드는 A가 눌리면, translate 함수가 실행될때마다 게임오브젝트가 x축으로 -0.01만큼(왼쪽) 움직인다. (if문이 실행되는 것이다.) 
       }
        
    }

   float speed = 0.02f; // 변수라는 그릇에 속도를 담아서 사용한다. 그러면 만약 속도를 바꿀때도 용이하다.  
    if (Input.GetKey(KeyCode.W)){
        transform.Translate(0,speed,0);
        
    }
    if (Input.GetKey(KeyCode.A)){
        transform.Translate(-speed,0,0);
        
    }
    if (Input.GetKey(KeyCode.S)){
        transform.Translate(0,-speed,0);
        
    }
    if (Input.GetKey(KeyCode.D)){
        transform.Translate(speed,0,0);
        
    }
}
}
// 이 코드는 w,a,s,d를 클릭하면 게임 오브젝트가 w,a,s,d 방향으로 움직인다. 
