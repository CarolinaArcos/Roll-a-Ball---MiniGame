using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public GameObject object2spawn;

	public Vector2 spawnArea;

	private Vector3 pos;

	public float time2spawn = 2f;
	private float timeSinceLastSpawn;

	// Use this for initialization
	void Start () {
		pos = this.transform.position;
		timeSinceLastSpawn = time2spawn;
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawn += Time.deltaTime;

		if (timeSinceLastSpawn>=time2spawn){
			SpawnObject();
			timeSinceLastSpawn = 0;
		}
	}

	void SpawnObject(){
		Vector3 posSpawn = pos;
		posSpawn.x = Random.Range(-spawnArea.x, spawnArea.x);
		posSpawn.z = Random.Range(-spawnArea.y, spawnArea.y);

		GameObject.Instantiate(object2spawn, posSpawn, Quaternion.identity);
	}
}
