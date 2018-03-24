using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
        gameObject.transform.Translate(Time.deltaTime * 10f, 0f, 0f);

        if (gameObject.transform.position.x > 15) {
            Destroy(gameObject);
        }
	}
}
