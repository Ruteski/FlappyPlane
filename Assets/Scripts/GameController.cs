using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //timer
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;

    //posicao para criar obstaculo
    [SerializeField] private Vector3 posicao;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f) {
            timer = 1f;

            //criando os obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }

    //
}
