using UnityEngine;

public class InterfaceExample : MonoBehaviour
{
    
}

interface ISWord{
    float Damage { get; set; }
    void Attack();
}

interface ISHield {
    float Denfensive { get; set; }
    void Defend(); 
}

class Knight : ISWord, ISHield { // 인터페이스는 다중 장착이 가능하다. 
    public float Damage { get; set; }
    public float Denfensive { get; set; }
    public void Attack(){

    }
    public void Defend(){

    }
}