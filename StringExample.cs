using UnityEngine;

public class StringExample : MonoBehaviour
{
    void Start(){
        string str1 = "Hello";
        string str2 = "Hello World";

        // 1. Length 
        Debug.Log(str1.Length); // 5
        Debug.Log(str2.Length); // 11

        // 2. IndexOf()
        Debug.Log(str1.IndexOf("e")); // 1 
        Debug.Log(str1.IndexOf("o")); // 4

        // 3. Replace()
        Debug.Log(str1.Replace("el", "55")); // el 을 55 로 치환

        // 4. Spit()
        string str3 = "abcdef";
        string[] arr = str3.Split('c');
        Debug.Log(arr.Length);
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);

        string str4 ="철수,영희,훈이,뽀삐";
        string[] namearr = str4.Split(',');
        foreach(string name in namearr)
        {
            Debug.Log(name);
        }

        // 5. Substring()
        string str5 = "tomato";
        Debug.Log(str5.Substring(1));
        Debug.Log(str5.Substring(1,3));

        // 6. string.Format()
        string newStr = string.Format("43 * 72 = {0}", 43 * 72);
        Debug.Log(newStr);

        for(int i = 2; i < 10; i++)
        {
            for(int j = 1; j < 10; j++)
            {
                Debug.Log(string.Format("{0} * {1} = {2}", i, j, i*j));
            }
        }

       // 7. string 형변환
        int num = 1;
        string str8 = num.ToString(); // "1"

        int num2 = int.Parse(str8); // 1 
    





    }
}
