using UnityEngine;

public class EnumExample : MonoBehaviour
{
    string[] names = {"john", "chulsoo", "bbobbi"};

    void Start(){
        // Debug.Log((int)Days.Mon);
        // Debug.Log(names[1]);
        Debug.Log((int)Names.bbobbi);


    }
}
enum Days {
    Mon, Tue, Wed, Thu, Fri, Sat, Sun
}

enum Names {
    chulsoo = 1, bbobbi
}