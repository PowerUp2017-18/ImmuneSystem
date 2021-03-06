﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MacrophageHealth : MonoBehaviour {

	public float health = 100f;
	public Image healthbar;
	
	void Start() {
		healthbar.fillAmount = health;
	}

	void Update() {
		
		}
	
	void LateUpdate() {
		health -= Time.deltaTime * 1f;
		healthbar.fillAmount = health / 100f;
		if (health <= 0) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision co) {
		if (co.gameObject.tag == "Helper T Cell") {
			health = 100;
			Destroy(co.gameObject);
		}
		if (co.gameObject.tag == "Bacteria") {
			health = health - 1;
		}
		if (co.gameObject.tag == "Neutrophil") {
			health = health - 100;
		}
	}
}