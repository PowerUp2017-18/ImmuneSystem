using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelperTCellHealth : MonoBehaviour {

	public float health = 100f;
	public Image healthbar;
	
	void Start() {
		healthbar.fillAmount = health;
	}

	void Update() {
		
		}
	
	void LateUpdate() {
		healthbar.fillAmount = health / 100f;
		if (health <= 0) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter(Collision co) {
		if (co.gameObject.tag == "Macrophage") {
			health = health - 100;
		}
		if (co.gameObject.tag == "Neutrophil") {
			health = health - 100;
		}
	}
}
