using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericExample : MonoBehaviour

// 예를 들어, int 형과 float 형, 문자열로 data를 담는 클래스를 만들어야 한다면 하나씩 클래스를 만들면 되는데 이것은 비효율적이기 때문에 형식변수를 사용한다. 

{
    void Start()
    {
        DataClass<int> dc = new DataClass<int>();
        dc.data = 1;
        dc.GetData();

        DataClass<float> dc2 = new DataClass<float>();
        dc2.data = 1.0f;
        dc2.GetData();


    }
}

class DataClass<T>{
    public T data;

    public T GetData(){
        return data;
    }
}