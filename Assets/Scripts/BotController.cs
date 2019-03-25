using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour {

    public Transform[] path;
    public int targetId = 1;
    public bool arrived = false;

    public float maxTimeStop = 10.0f;
    private float actualTimeStop = 0.0f;

    public GameObject player;

    public int speed;

    // Start is called before the first frame update
    void Start() {

        player = GameObject.FindGameObjectWithTag("Player");

        path = GameObject.FindGameObjectWithTag("PathRoom1").GetComponentsInChildren<Transform>();

        Debug.Log("Bot: El jugador empieza en el nivel: " + player.GetComponent<Valve.VR.InteractionSystem.Player>().level);

    }

    // Update is called once per frame
    void Update() {
        
        if (!arrived) {

            if (path != null) {
                transform.position += (path[targetId].position - transform.position).normalized * speed * Time.deltaTime;
                if (Vector3.Distance(transform.position, path[targetId].position) < 1) arrived = true;
            } else {
                if (Vector3.Distance(transform.position, player.transform.position) > 2) {
                    transform.position += (player.transform.position - transform.position).normalized * speed * Time.deltaTime;
                }
            }

        } else if (actualTimeStop < maxTimeStop) {

            actualTimeStop += Time.deltaTime;

        } else {

            targetId++;
            if (targetId >= path.Length) targetId = 1;
            arrived = false;
            actualTimeStop = 0.0f;

        }

    }

}
