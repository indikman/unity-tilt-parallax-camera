using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxControl : MonoBehaviour
{

    public int speed = 5;

    public Vector2 clampMax;
    public Vector2 clampMin;

    private Vector3 initialPosition;

    float xpos, ypos, xPosClamped, yPosClamped;
    Vector3 accell;
    
    void Start()
    {
        initialPosition = this.transform.position;
    }
    
    void Update()
    {
        accell = Input.acceleration;

        accell.Normalize();

        xpos = Mathf.Lerp(transform.position.x, initialPosition.x - accell.x, speed * Time.deltaTime);
        ypos = Mathf.Lerp(transform.position.y, initialPosition.y - accell.y, speed * Time.deltaTime);

        //xPosClamped = Mathf.Clamp(xpos, 4f, 6f);
        //yPosClamped = Mathf.Clamp(ypos, -1f, 1f); 

        xPosClamped = Mathf.Clamp(xpos, clampMin.x, clampMax.x);
        yPosClamped = Mathf.Clamp(ypos, clampMin.y, clampMax.x); 

        transform.position = new Vector3(xpos, ypos, initialPosition.z);
        
    }
}
