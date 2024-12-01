using System;
using UnityEngine;

public class CursorGridScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Vector2 mousePositionVector;

    // Update is called once per frame
    void Update()
    {

        mousePositionVector = Input.mousePosition;
        mousePositionVector = Camera.main.ScreenToWorldPoint(mousePositionVector);
        mousePositionVector /= (float)0.08;
        mousePositionVector += new Vector2((float)0.4,(float)0.4);
        Debug.Log(mousePositionVector);
        mousePositionVector = new Vector2((float)Math.Floor(mousePositionVector.x), (float)Math.Floor(mousePositionVector.y));
        mousePositionVector *= (float)0.08;

        transform.position = mousePositionVector;

    }
}
