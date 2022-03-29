using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    //timer
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;

    //posicao minima e maxima para criacao
    [SerializeField] private float posMin = -0.3f;
    [SerializeField] private float posMax = 2.4f;

    //tempo min e max para criacao dos obstaculos
    [SerializeField] private float tMin = 1f;
    [SerializeField] private float tMax = 4f;

    //posicao para criar obstaculo
    [SerializeField] private Vector3 posicao;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        timer -= Time.deltaTime;

        if (timer <= 0f) {
            timer = Random.Range(tMin, tMax);

            posicao.y = Random.Range(posMin, posMax);

            //criando os obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity); // ou da pra usar o tranform.rotation no lugar do quaternion
        }
    }

    //
}