using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForward : MonoBehaviour {

    public SpawnEnemies _spawnSpeed;

    private void Start()
    {
        _spawnSpeed = GameObject.Find("Spawn Object").GetComponent < SpawnEnemies >();
    }

    private void Update()
    {
        transform.Translate(Vector2.up * -1 * _spawnSpeed._speed * Time.deltaTime);


        if(transform.position.y <= -5.51f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
