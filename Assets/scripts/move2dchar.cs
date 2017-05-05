using UnityEngine;

public class move2dchar : MonoBehaviour {

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        Vector2 newDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Animator>().SetFloat("x", newDirection.x);
        GetComponent<Animator>().SetFloat("y", newDirection.y);
        GetComponent<Animator>().SetBool("isMoving", newDirection.magnitude > 0.1);
    }
}
