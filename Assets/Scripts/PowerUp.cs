using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    public float PowerUpAmount = 20.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Speed Increased!");
            other.gameObject.GetComponent<Move>().MoveSpeed = PowerUpAmount;
            Destroy(gameObject);
        }
    }
}
