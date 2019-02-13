using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToStartPosition : MonoBehaviour
{
    Vector3 startingPos;
    Vector3 resetVel = new Vector3(0.0f,0.0f,0.0f);
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
        startingPos.y = startingPos.y + 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        transform.position = startingPos;
        rb.velocity = resetVel;
    }
}