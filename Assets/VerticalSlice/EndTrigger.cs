using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {
	public string scenename = "EndScreen";


	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {			
			SceneManager.LoadScene (scenename);
		}
	}
}
