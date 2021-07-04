using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewPortTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Vector2 screenToViewPort(Vector2 screenPosition)
    {
        Vector2 viewportValue = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
        return viewportValue;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            var mousePos = Input.mousePosition;
            Debug.Log("mouse position in pixels " + mousePos);
            Debug.Log("View port point " + Camera.main.ScreenToViewportPoint(mousePos));

            Debug.Log("converted viewport value " + screenToViewPort(mousePos));
        }


    }
}
