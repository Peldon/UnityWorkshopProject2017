using UnityEngine;
using System.Collections.Generic;

public class ExampleScript : MonoBehaviour {
    public int wholenumber = 0;
    public float number = 3.14f;
    public string message = "hello!";
    public Vector3 position = new Vector3(0, 5, 0);
    public GameObject ball_prefab;
    // not visible in inspector, because variables are private
    private bool isEverythingFine = true;
    private List<GameObject> balls = new List<GameObject>();
    
    // Use this for initialization
    void Start() {
        if(ball_prefab == null) {
            Debug.LogError("ball prefab not found! creating a new one");
            ball_prefab = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            ball_prefab.AddComponent<Rigidbody>();
        }
    }
    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space was pressed. creating a new ball");
			AddBall ();
        }
        if(balls.Count >= 10) {
            Debug.Log("What a mess, cleaning up");
            foreach(GameObject b in balls) {
                Destroy(b);
            }
            balls.Clear();
        }
    }
	public void AddBall() {
		GameObject ball = CreateBall();
		balls.Add(ball);
	}

    private GameObject CreateBall() {
        GameObject newball = UnityEngine.Object.Instantiate(ball_prefab);
        newball.name = "ball" + wholenumber;
        wholenumber = wholenumber + 1;
        newball.transform.position = position;
        return newball;
    }
}
