using UnityEngine;

public class EventExample : MonoBehaviour
{
    void Start(){
        Publisher pub = new Publisher();
        Subscriber sub = new Subscriber();

        pub.RunEvent();
    }
}

delegate void myEventHandler();

class Publisher{
    public static event myEventHandler myEvent;

    public void RunEvent(){
        if(myEvent != null)
        {
            myEvent();
        }
    }
}

class Subscriber{

    public Subscriber(){
        Publisher.myEvent += DoSomething;    
    }
    public void DoSomething(){
        Debug.Log("do something");
    }

}
