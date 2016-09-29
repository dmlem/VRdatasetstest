using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public Transform point;
    public int numToSpawn;
    public Vector3 position;

    // Use this for initialization
    void Start () {
        int spawned = 0;

        while (spawned < numToSpawn)
        {
            position = new Vector3(Random.Range(100.0F, 1000.0F), 70, Random.Range(100.0F, 1000.0F));
            Instantiate(point, position, Quaternion.identity);
            spawned++;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
