using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionExample : MonoBehaviour
{
    void Start()
    {
        int[] arr = {1,2,3,4,5};
        int sum = 0;

        try{
        for(int i = 0; i < 10; i ++)
        {
            Debug.Log(arr[i]);
            sum += arr[i];
        }
        }
        catch(System.IndexOutOfRangeException exception)
        {
            Debug.Log("에러 발생");
        }
        finally
        {
            Debug.Log(sum);
        }

        Debug.Log("완료!");
    }
}
