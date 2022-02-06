using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    private float zposition;
    public GameObject Tile;
    public GameObject Ball;
    public GameObject Destroyer;
    public Vector3 move;
    public float  movespeed =5f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startRunning();
    }

    public void startRunning()
    {
        move = Vector3.zero;
        move.z = -1 * movespeed * Time.deltaTime;
        Tile.transform.Translate(0, 0, move.z);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Tile")
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
