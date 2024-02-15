using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutPaddleScript : MonoBehaviour {
    private float xPos, yPos;
    public float paddleSpeed = .05f;
    public float topWall, bottomWall;
    public float leftWall, rightWall; 
    public KeyCode leftKey, rightKey;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(leftKey)) {
            if (xPos > leftWall) {
                xPos -= paddleSpeed;
            }
        }

        if (Input.GetKey(rightKey)) {
            if (xPos < rightWall) {
                xPos += paddleSpeed;
            }
        }

        transform.localPosition = new Vector3(xPos, transform.position.y, 0);
    }
}

