using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject BulletPrefab;
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)) // space를 누르면 총알이 나온다 
    {
        Instantiate(BulletPrefab); // 총알이 처음 생성된다. (첫 위치) ) 미리 만들어놓은 총알 프리팹을 복제해서 사용하는 것이다. 

    }
    }
}
