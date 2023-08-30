using UnityEngine;

public class StructAssignment : MonoBehaviour
{
    void Start()
{
    Point_struct point1 = new Point_struct(3, 3);
    Point_struct point2 = point1; // 클래스 

    Debug.Log(point1.GetPoint());  
    Debug.Log(point2.GetPoint()); 
    
    Point point3;
    point3.x = 1;
    point3.y = 2;
    Debug.Log(point3.GetPoint()); // (1.2)
                                  // 구조체를 이용해 생성 
}

}

class Point_struct 
    {
        public int x;
        public int y;

        public Point_struct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string GetPoint()
        {
            return $"({x}, {y})";
        }
    }