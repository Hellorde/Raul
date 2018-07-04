using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {	

	public GameObject pedra;
	public GameObject pena;
	public GameObject lesmo;
	float salto = 0;
	public GameObject raul;
	public LayerMask chao;
	public CapsuleCollider2D colideraul;	
	private bool isgrounded;
	public Text txtscore;
	int score;
	bool comecou;
	bool acabou;
	void Start()
	{  				
		txtscore.text = "TAP!!";		 	
	}

	void Update(){
		if(!acabou){
			if(Input.GetButtonDown("Fire1")){
				if(!comecou){
					comecou = true;
					//funcao, tempo para iniciar, tempo depois de iniciar
					InvokeRepeating("cria", 1, 2);
				}	
				pontos();								
				if(Input.mousePosition.x > Screen.width /2)
				{
				direita();
				} else{
				esquerda();
				}	
			}
		
		}
	}
	
	// Random value e entre 0 e 1
	// Random range (x, n)
	void cria(){ 
		
		GameObject novoinimigo = new GameObject();
		
		var sorteio = Random.Range(1,4);
		
		switch(sorteio){
			case 1: novoinimigo = Instantiate(pedra);
				break;
			case 2: novoinimigo = Instantiate(pena);
				break;
			case 3: novoinimigo = Instantiate(lesmo);
				break;
			default: break;
		}
			
		novoinimigo.GetComponent<Rigidbody2D>().gravityScale = 0.5f;			
		novoinimigo.transform.position = new Vector2(Random.Range(-5.0f, 5.0f), 6.0f); 	
		
	}

	void direita(){	
			
			if(salto < 3){
			salto = salto +3.5f;
			raul.transform.position = new Vector2(salto, -3.4f);			// Raul salta uma vez para x 1.1
			}		
		/*	raul.GetComponent<Rigidbody2D>().isKinematic = false;
			if(colideraul.IsTouchingLayers(chao)){
					raul.GetComponent<Rigidbody2D>().velocity = new Vector2(10.0f, 0);
					raul.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
									
				}else{
				
			} */			
				
	}
	void esquerda(){
		
		if(salto > -3){
			salto = salto - 3.5f;
			raul.transform.position = new Vector2(salto, -3.4f);			// Raul salta uma vez para x 1.1
		}		
	}

	void fim(){

		CancelInvoke("CriaInimigo"); 
		  
	} 

	void pontos (){
		score++;
		txtscore.text = score.ToString();
	}

}
