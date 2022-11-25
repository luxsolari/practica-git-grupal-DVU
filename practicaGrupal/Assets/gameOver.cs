using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "GoalLeft" && other.gameObject.tag == "Ball")
        {
            Debug.Log("Gol en el arco izquierdo");
        }
        if (this.gameObject.tag == "GoalRight" && other.gameObject.tag == "Ball")
        {
            Debug.Log("Gol en el arco derecho");
        }
    }
}
