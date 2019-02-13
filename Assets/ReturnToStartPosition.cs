using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToStartPosition : MonoBehaviour
{
    Vector3 startingPos;
    Quaternion startingRot;
    Vector3 resetVel = new Vector3(0.0f,0.0f,0.0f);
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = rb.position;
        startingPos.y = startingPos.y + 0.2f;
        startingRot = rb.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        rb.rotation = startingRot;
        rb.velocity = resetVel;
        rb.position = startingPos;
    }
}