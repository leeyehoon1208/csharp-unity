using UnityEngine;

public class whileexample : MonoBehaviour
{
     void Start (){
        int i = 0;
        while(i < 10){
            Debug.Log(i);
            i ++;
        }   
    }

    //짝수만 출력하는 코드
        int j = 0;
        while(j < 10){
            if(j % 2 ==1 ){

                j ++;
                continue;
            }
            Debug.Log(j);
            j ++;
        }   
    }
    // 1부터 10까지 출력, 10보다 크면 while문을 빠져나간다. 
    int k = 0;
    while(true){
        if (k > 10){
            break;
        }
        Debug.Log(k);
            k ++;
    }
 // 1부터 100까지 3의 배수만 출력
    for(int l = 1; l <=100; l ++){
        if(l % 3 != 0){
            continue;
        }
        Debug.Log(l);
    }

// 1부터 100까지 3의 배수로 출력이지만 50이 넘으면 break
for(int m = 1; m <=100; m ++){
        if(m >50){
            break;
        }
        if(m % 3 != 0){
            continue;
        }
        Debug.Log(m);
    }
