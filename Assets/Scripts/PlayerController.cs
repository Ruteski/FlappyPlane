using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //pegando as informações do player
    private Rigidbody2D meuRB;

    [SerializeField] private float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //pegando meu RB sozinho
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();

        LimitandoVelocidadeQueda();
    }

    void Subir() {
        //subindo ao apertar o espaço
        if (Input.GetKeyDown(KeyCode.Space)) {
            //fazendo a velocidade do RB ir para cima
            meuRB.velocity = Vector2.up * velocidade;
        }
    }

    void LimitandoVelocidadeQueda() {
        //limitando a velocidade de queda
        if (meuRB.velocity.y < -velocidade) {
            //travando a velocidade de queda em -5
            meuRB.velocity = Vector2.down * velocidade;
        }
    }

    //configurando a colisao do player
    private void OnTriggerEnter2D(Collider2D collision) {
        SceneManager.LoadScene("Jogo");
    }
}
