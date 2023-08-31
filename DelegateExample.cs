using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{

    delegate void ExampleDelegate();

    void Hello(){
        Debug.Log("hello");
    }

    void Bye(){
        Debug.Log("bye");
    }
    void Start()
    {

        // Mom mom = new Mom();
        // Son son= new Son();

        // mom.RunStudy();
        // ExampleDelegate ed  = new ExampleDelegate(Hello);
        // ExampleDelegate ed = Hello;
        // ed += Bye;
        // ed(); 

        Mom mom = new Mom();    
        Son son = new Son();

        mom.GetSonToStudy(son); // 아들 객체가 필요하기 때문에 아들 객체를 넣어준다. 
    }
    
    delegate void StudyDelegate();

    class Mom{
        public static event StudyDelegate sd;
        
        public void GetSonToStudy(Son son){
            // StudyDelegate sd = FinishStudy;
            Mom.sd += FinishStudy;
            son.Study(sd);
        }
        public void FinishStudy(){
            Debug.Log("Study done!");
        }
    }

    class Son{
        public void Study(StudyDelegate sd){
            Debug.Log("Studying...");
            sd();
        }
    }


    // event로 만들어봤닫. 
//     delegate void StudyDelegate();

//     class Mom{
//         public static event StudyDelegate sd;

//         public void RunStudy(){
//             if(sd != null){
//                 sd();
//             }
        
//         }
//     }

//     class Son{

//         public Son(){
//             Mom.sd += Study;
//         }
//         public void Study(){
//             Debug.Log("studying...");
//         }
//     }
    
}
