using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    private float spawnz = 40f;
    public GameObject[] Tile;
    private int TileAmount=5;
    private float dist = 3f;

    private List<GameObject> Tilelists;
    private Transform Tiletransform;


    // Start is called before the first frame update
    void Start()
    {
        Tilelists = new List<GameObject>();
        Tiletransform = GameObject.FindGameObjectWithTag("Tile").transform;
        for (int i = 0; i < TileAmount; ++i)
            SpawnTile(0);
    }

    // Update is called once per frame

    /* void Update()
    {
        if (Tiletransform.position.z < (spawnz - TileAmount * dist))
        {
            SpawnTile(0);
            DeleteTile();
        }   
    }
    void SpawnTile(int TileIndex )
    {
        GameObject go;

        int randomTile = Random.Range(0, Tile.Length);
        Vector3 hposition = new Vector3(Random.Range(-4f, 4f), 0.3f, spawnz);

        go = Instantiate(Tile[randomTile], hposition, Tile[randomTile].transform.rotation) as GameObject;
        spawnz += dist;

        Tilelists.Add(go);
    }
    void DeleteTile()
    {
        Destroy(Tilelists[0]);
        Tilelists.RemoveAt(0);
    }*/
    void Update()
    {
        if (spawnz<40f)
        {
            SpawnTile(0);
            //spawnz += 10f;
            DeleteTile();
        }   
    }
    void SpawnTile(int TileIndex )
    {
        GameObject go;

        int randomTile = Random.Range(0, Tile.Length);
        Vector3 hposition = new Vector3(Random.Range(-4f, 4f), 0.3f, spawnz+10f);

        go = Instantiate(Tile[randomTile], hposition, Tile[randomTile].transform.rotation) as GameObject;
        // spawnz =go.transform.rotation.z;
        //spawnz -= dist;

        Tilelists.Add(go);
    }
    void DeleteTile()
    {
        Destroy(Tilelists[0]);
        Tilelists.RemoveAt(0);
    }
}
