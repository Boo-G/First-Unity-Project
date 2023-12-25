using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime makes it use a built in clock rather than fps, due to update running on every frame
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime ;
        
        if (transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }
}
