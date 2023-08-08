using UnityEngine;

public class bullets : MonoBehaviour
{
    
    void Start()
    {
        Invoke("DestroySelf", 2.0f);
    }
    
    void DestroySelf()
    {
        Destroy(gameObject);
    }

    
}

// 이 코드는 총알이 2초가 지나면 소멸되도록 만든 코드이다. 
