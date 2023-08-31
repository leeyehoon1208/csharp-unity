using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCollectionExample : MonoBehaviour
{
    void Start()
    {
        // 1. List<T>
        // List<int> list = new List<int>();
        // list.Add(0);
        // list.Add(1);
        // list.Add(2);
        // list.Remove(0); // {1,2}

        // Debug.Log(list[0]); // 1

        // 2. Dictionary<TKey, TValue>
        // Dictionary<int, string> dic = new Dictionary<int, string>();
        // dic.Add(1, "hello");
        // dic.Add(2, "hi");
        // dic.Add(3, "안녕");
        
        // dic.Remove(2);

        // Debug.Log(dic[0]); // hello

        // 3. Queue<T>
        // Queue<float> queue = new Queue<float>();
        // queue.Enqueue(1);
        // queue.Enqueue(2);
        // queue.Enqueue(3);

        // Debug.Log(queue.Dequeue()); // 1
        // Debug.Log(queue.Dequeue()); // 2 

        // 4. Stack<T>
        // Stack<char> stack = new Stack<char>();
        // stack.Push("a");
        // stack.Push("b");
        // stack.Push("c");

        // Debug.Log(stack.Pop()); // c
        // Debug.Log(stack.Pop()); // b
        

    }
}
