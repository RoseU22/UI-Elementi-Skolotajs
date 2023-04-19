using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtuluGenerators : MonoBehaviour {
	public GameObject[] VirtuluSagataves;
	public float laikaIntervals = 1.0f;
	float minPoz, maxPoz;
	Transform krasnsTransform;

	void Start(){
		krasnsTransform = GetComponent<Transform>();
	}

	public void sagatavotVirtulus(bool stavoklis){
		if (stavoklis)
			StartCoroutine(Generet());
		else
			StopAllCoroutines();
	}

	IEnumerator Generet(){
		while (true) {

			minPoz = krasnsTransform.position.x - 10;
			maxPoz = krasnsTransform.position.x + 10;
			var cipars = Random.Range (minPoz, maxPoz);
			var pozicija = new Vector2 (cipars, transform.position.y);
			GameObject virtulis = Instantiate (VirtuluSagataves [Random.Range (0, VirtuluSagataves.Length)], 
			pozicija, Quaternion.identity, krasnsTransform);

			yield return new WaitForSeconds (laikaIntervals);
		}
	}

}