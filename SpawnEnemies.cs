using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    [SerializeField] private GameObject _ship1, _ship2, _ship3, _ship4;

    private int _numSpawn;
    [SerializeField]
    private float _numX, _timing = 0f, _timeNext = 5f, _timePlanet = 0f;
    public float _speed = 0.1f;

    // Update is called once per frame
    private void Update () {

        if(Time.time > _timeNext)
        {
            _numSpawn = Random.Range(1, 4);
            _numX = Random.Range(-1.87f, 2.28f);
            _timing = Random.Range(1f, 5f);
            _timeNext = _timing + Time.time;

            if (_numSpawn == 1)
            {
                StartCoroutine(WaitShipOne());
                _speed += Random.Range(0.01f, 0.1f);
            }

            if (_numSpawn == 2)
            {
                StartCoroutine(WaitShipTwo());
                _speed += Random.Range(0.01f, 0.1f);
            }

            if (_numSpawn == 3)
            {
                StartCoroutine(WaitShipThree());
                _speed += Random.Range(0.01f, 0.1f);
            }

            if (_numSpawn == 4)
            {
                StartCoroutine(WaitShipFour());
                _speed += Random.Range(0.01f, 0.1f);
            }
        }


    }

    private IEnumerator WaitShipOne()
    {
        Instantiate(_ship1, new Vector2(_numX, 5.31f), Quaternion.identity);
        yield return new WaitForSeconds(_timeNext);
    }

    private IEnumerator WaitShipTwo()
    {
        Instantiate(_ship2, new Vector2(_numX, 5.31f), Quaternion.identity);
        yield return new WaitForSeconds(_timeNext);
    }

    private IEnumerator WaitShipThree()
    {
        Instantiate(_ship3, new Vector2(_numX, 5.31f), Quaternion.identity);
        yield return new WaitForSeconds(_timeNext);
    }

    private IEnumerator WaitShipFour()
    {
        Instantiate(_ship4, new Vector2(_numX, 5.31f), Quaternion.identity);
        yield return new WaitForSeconds(_timeNext);
    }

}
