using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crsoromment : MonoBehaviour
{
    public Vector2 turn;
    public float sens  =5f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        turn.x +=  Input.GetAxis("Mouse X") * sens;
        turn.y += Input.GetAxis("Mouse Y") * sens;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
        
    }
}
