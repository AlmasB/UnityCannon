using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingScript : MonoBehaviour {

    private GameScript gameScript;

	// Use this for initialization
	void Start () {
        gameScript = GameObject.FindWithTag("MainCamera").GetComponent<GameScript>();
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(0f, Time.deltaTime * -5f, 0f);

        if (gameObject.transform.position.y < -6) {
            transform.position = new Vector3(gameObject.transform.position.x, 6f, 0f);
        }
	}

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "bullet") {
            transform.position = new Vector3(gameObject.transform.position.x, 6f, 0f);

            gameScript.AddScore();
        }
    }
}
