using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonymousMethodExample : MonoBehaviour
{
    delegate int myDelegate(int a, int b);
    void Start(){
        // 1. 익명메소드
        // myDelegate del = delegate(int a, int b){
        //     return a + b;
        // };

        // 람다식 1
        // myDelegate del = (int a, int b) =>{
        //     return a + b;
        // };

        // 람다식 2 
        myDelegate del = (a, b) => a + b;
        
        Debug.Log(del(2,4));
    }
}

    



