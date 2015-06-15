using UnityEngine;
using System.Collections;

public class RollDice : MonoBehaviour {
	public Rigidbody dice;
	public float forceModifier = 3f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RollTriggered() {
		Rigidbody diceInstance = (Rigidbody)Instantiate (dice, transform.position, transform.rotation);
		diceInstance.rotation = Random.rotation;
		diceInstance.velocity = transform.forward * forceModifier;
		diceInstance.angularVelocity = transform.right * forceModifier;

	}
}
