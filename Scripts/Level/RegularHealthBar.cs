using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegularHealthbar : MonoBehaviour {

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
}
