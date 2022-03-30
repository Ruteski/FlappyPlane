using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // pra poder pegar as informações do canvas

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

    //variavel dos pontos
    private float pontos = 0f;

    //variavel dos pontos do canvas
    [SerializeField] private Text pontosTexto;

    //variavel do level
    private int level = 1;

    //variavel para ganhar level
    [SerializeField] private float proximoLevel = 10f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //ganhando pontos
        Pontos();
        CriaObstaculo();
        GanhaLevel();
    }

    private void Pontos() {
        pontos += Time.deltaTime;

        pontosTexto.text = Mathf.Round(pontos).ToString();
    }
    
    private void GanhaLevel() {
        if (pontos >= proximoLevel) {
            level++;
            proximoLevel += proximoLevel;
        }
    }

    private void CriaObstaculo() {
        timer -= Time.deltaTime;

        if (timer <= 0f) {
            timer = Random.Range(tMin, tMax);

            posicao.y = Random.Range(posMin, posMax);

            //criando os obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity); // ou da pra usar o tranform.rotation no lugar do quaternion
        }
    }
}