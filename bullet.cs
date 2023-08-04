using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float BulletSpeed = 100f;
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
    {
        GameObject bullet = Instantiate(BulletPrefab); // 총알이 처음 생성된다. (첫 위치) ) 미리 만들어놓은 총알 프리팹을 복제해서 사용하는 것이다. 
        bullet.transform.position = transform.position; // 총알의 위치를 (0,0)
        bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed); // (0,1) * 100 = (0,100) 
    }
    }
}
