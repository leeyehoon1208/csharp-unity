using UnityEngine;

public class AbstractExmaple : MonoBehaviour
{
    void Start()
    {
        Bird eagle = new Bird();
        Fish shark = new Fish();

        eagle.Move();
        shark.Move();
    }
}

abstract class Animal{
    public abstract void Move();
}

class Bird : Animal{
    public override void Move(){
        Debug.Log("Fly!");
    }
}
class Fish : Animal{
    public override void Move(){
        Debug.Log("Swim!");
    }
}