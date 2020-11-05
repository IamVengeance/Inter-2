using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerScript : MonoBehaviour  
{   

    private float _rotationSpeed = 20f;
    private Vector3 _horizontalMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalMovement = new Vector3(0f, 0f, -Input.GetAxis("horizontal"));
        transform.Rotate(_horizontalMovement * _rotationSpeed * Time.deltaTime);
    }
}
