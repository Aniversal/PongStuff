using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//For a class working with primitice rectangles
public class Prect : MonoBehaviour
{

    public string name;
    public Rect rect;
    public int x, y, w, h;
    public bool hasCollision;
    public string tag;

    //Default Constructor
    public Prect()
    {

    }

    public Prect(string Name, int XPOS, int YPOS, int Width, int Height, bool HASCOLLISION, string TAG)
    {
        name = Name;
        x = XPOS;
        y = YPOS;
        w = Width;
        h = Height;
        rect.x = x;
        rect.y = y;
        rect.width = w;
        rect.height = h;
        hasCollision = HASCOLLISION;
        tag = TAG;

    }

}
