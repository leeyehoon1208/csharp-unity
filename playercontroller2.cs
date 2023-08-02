using UnityEngine;

public class playercontroller2 : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log(transform.position);
       transform.position = Vector2.one;

       // position의 x값을 3을 옯기는 코드
       Vector2 pos = transform.position;
       pos.x += 3;
       transform.position = pos; // 이코드는 게임오브젝트의 x값을 3으로 옮기는 코드이다. 
    }
    void Update()
    {
        Vector2 pos = transform.position;
       pos.x += 0.01f;
       transform.position = pos; // 이 코드는 게임오브젝트가 매 프레임마다 x축으로 0.01 움직인다. 
    }
}
   
