using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour {

    public GameObject player;

    private Vector3 targetPos;

    private float speed = 1.5f;

    private bool isMoving = false;

    // Start is called before the first frame update
    void Start() {

        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 2, player.transform.position.z);

    }

    // Update is called once per frame
    void Update() {

        targetPos = new Vector3(player.transform.position.x, player.transform.position.y + 2, player.transform.position.z);

        Vector3 movement = (targetPos - transform.position).normalized;

        if (Vector3.Distance(transform.position, targetPos) < 1) {

        }

        transform.position += movement * speed;
        Debug.Log(transform.position);

    }

}
