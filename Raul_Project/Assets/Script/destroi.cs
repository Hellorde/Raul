using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroi : MonoBehaviour {	
	void Start () {

	}	

	void Update () {
		if(this.transform.position.y < -3.3f){
			Destroy(this.gameObject);
		}
 	}
}

