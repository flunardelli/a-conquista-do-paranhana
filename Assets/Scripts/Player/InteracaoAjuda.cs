﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoAjuda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Debug.Log (gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D other) {
		//Destroy(other.gameObject);
		//Debug.Log("enter" + other.name);

		Ajuda info = other.GetComponent<Ajuda> ();
		if (info && info.Interagir) {
			string t = (info.Descricao.Length != 0) ? info.Descricao + "\n" + info.Texto : info.Texto;
			EventManager.TriggerEvent ("newPlayerDialog",t);
		} else if (info) {
			EventManager.TriggerEvent ("newPlayerDialog",info.Descricao);
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		//Destroy(other.gameObject);
		//Debug.Log("exit" + other.name);
		EventManager.TriggerEvent ("newPlayerDialog","");
	}
}
