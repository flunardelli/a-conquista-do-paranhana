﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    //public int valor = 0;

    [SerializeField]
    public int Valor
    {
        get { return _valor; }
        set { 
            _valor = value; 
            if (txt != null) {
                txt.text = (_valor > 1) ? _valor.ToString() + " x " + Descricao : Descricao;
            }
        }
    }
    public int _valor = 1;
    public string id;
    public string Descricao;
    private Text txt;
	// Use this for initialization
    void Awake () {
        txt = GetComponent<Text>();
        if (txt != null) {
            txt.text = Descricao;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
