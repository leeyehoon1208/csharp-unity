using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionExample : MonoBehaviour
{
    void Start(){
        // 1. ArrayList
        // ArrayList myAL = new ArrayList();
        // myAL.Add(1);
        // myAL.Add(2);
        // myAL.Add("Hello");
        // Debug.Log(myAL[0]);
        // Debug.Log(myAL.Count);

        // myAL.Remove(1);
        // Debug.Log(myAL.Count);

        // myAL.RemoveAt(1);
        // Debug.Log(myAL[0]);

        // 2. Hashtable
        // Hashtable myHT = new Hashtable();
        // myHT.Add("첫번째", 2);
        // myHT.Add("두번째", 4);

        // Debug.Log(myHT["첫번째"]);

        // myHT.Remove("첫번째");
        
        // Debug.Log(myHT.Count);

        // 3. Queue : First In First Out (FIFO)
        // Queue myQueue = new Queue();
        // myQueue.Enqueue(3);
        // myQueue.Enqueue(4);
        // myQueue.Enqueue(5);

        // Debug.Log(myQueue.Dequeue());
        // Debug.Log(myQueue.Dequeue());

        // 4. Stack : Last In First Out (LIFO)
        Stack mystack = new Stack();    
        mystack.Push("a");
        mystack.Push("b");
        mystack.Push("c");

        // Debug.Log(mystack.Pop());
        // Debug.Log(mystack.Pop());
        Debug.Log(mystack.Peek());

        // Object 

        object num = 1;
        object str = "hello";

        int num2 = 2;
        object a = num; // 암시적 형변환 ->박싱

        object b = 5;
        int num3 = (int)b; // 명시적 형변환 ->언박싱


    

    }
}
