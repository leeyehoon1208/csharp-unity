using UnityEngine;


public class MethodExample : MonoBehaviour
{
    /* 
        1. 실생활에서 자주 쓰이는 메소드, Half -> 매개변수에 입력된 값을 반으로 나누어 반환하는 메소드 
        2. 반환값이 없는 메소드
        3. 매개변수가 없는 메소드
        4. 매개변수가 여러개인 메소드
        5. 반환값과 매개변수가 없는 메소드

    */

    float Half(float num){
        float answer = num / 2;
        return answer;
    }
    void PrintHello(int num){
        Debug.Log(num);
    }  
    int GetTen(){
        return 10;
    }

    int Add(int a, int b){
        return a + b;
    }

    void PrintNumber(){
        Debug.Log("Hello");
    }

void Start(){
    float value = Half(10);
    Debug.Log(value);

    // PrintHello(10);

    // Debug.Log(GetTen);

    // Debug.Log(Add(1,3));

    // PrintNumber();
    }
    
    
}
