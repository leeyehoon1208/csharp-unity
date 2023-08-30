using UnityEngine;

public class StructExample : MonoBehaviour
{
    void Start ()
    {
        Point point1 = new Point(1, 1);
        Debug.Log(point1.GetPoint());
    }

}

struct Point 
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string GetPoint()
        {
            return $"({x}, {y})";
        }
    }