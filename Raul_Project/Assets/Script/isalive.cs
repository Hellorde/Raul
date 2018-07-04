using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isalive : MonoBehaviour {

	public GameObject raul;
	bool marcou;
	// Use this for initialization
	void Start () {
		raul = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < raul.transform.position.x){
		}
		if(!marcou){
		marcou =true;
			raul.SendMessage("pontos");
		}
	}
}
