using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{

	public GameObject bulletOriginal;
    public Text scoreText;
    private int score = 0;

	// Use this for initialization
	void Start()
	{
		bulletOriginal.SetActive(false);
	}
	
	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject bullet = Instantiate(bulletOriginal);
			bullet.transform.Translate(-5, 0, 0);
			bullet.SetActive(true);
		}
	}

    public void AddScore() {
        score += 20;
        scoreText.text = "Score: " + score;
    }
}
