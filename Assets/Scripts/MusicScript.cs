﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour {

	public Object[] myPlaylist;
	public AudioSource _audio;
	Scene  thisScene;

	//Play Global
	private static MusicScript instance = null;
	public static MusicScript Instance
	{
		get { return instance; }
	}

	void Awake()
	{
		_audio = GetComponent<AudioSource> ();
		myPlaylist = Resources.LoadAll ("Music", typeof(AudioClip));

		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}

		DontDestroyOnLoad(this.gameObject);
	}
	//Play Gobal End

	void Start(){
		thisScene = SceneManager.GetActiveScene ();
	}
	void RandomPLaylist(){

		_audio.clip = myPlaylist [Random.Range (0, myPlaylist.Length)] as AudioClip;
		_audio.Play ();
	}


	// Update is called once per frame
	void Update () {
		if (_audio.isPlaying == false && thisScene.name =="4_Evento01" ) {
			RandomPLaylist ();
		}
	}
}
