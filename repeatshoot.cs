using UnityEngine;

public class shootingbulletsrepeatedly : MonoBehaviour
{
    public GameObject bulletprefab;
    public float BulletSpeed = 100;
    void Update()
    {
        // 총알이 한번 누르면 총아리 연속으로 나가도록 만든 코드이지만 자연스럽지 않다.
        if(Input.GetKey(Keycode.Space)){
         bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed * (i + 1)); // 이것은 마지막 총알이 더 빠르게 나간다.
        }
        if(Input.GetKey(Keycode.Space)){
         bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed * (1 + (i * 01.f))); // // 첫번째 총알은 그대로이고 두번째는 1.1, 세번째 총알은 1.2로 날아간다.
        }

        // 총알이 한번 누르면 3발 연속으로 나가도록 만든 코드 // 자연스럽다 
        if(Input.GetKey(Keycode.Space)){
        for (int i = 0; i < 3; i ++){
        GameObject bullet = Instantiate(bulletprefab);
       bullet.transform.position = transform.position;
       Vector2 pos = bullet.transform.position;
       pos.y = i * 0.3f;
       bullet.transform.position = pos; 
       bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);
        }
    }
    // 총알이 플레이어 앞에서 발사되도록 만든 코드 
    if(Input.GetKey(Keycode.Space)){
        for(int j = 0; j < 3; j ++){
        GameObject bullet = Instantiate(bulletprefab);
        Vector3 bulletstartpos = transform.position + new Vector3(0,0.5,0);
        bulletstartpos.y = j * 0.3f;
        bullet.transform.position = bulletstartpos;
        bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * BulletSpeed);
        }
        }

    }

}
