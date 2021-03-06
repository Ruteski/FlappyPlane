using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //pegando as informa??es do player
    private Rigidbody2D meuRB;

    [SerializeField] private float velocidade = 5f;
    [SerializeField] private GameObject puff;

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
        VerificaLimites();
    }

    void Subir() {
        //subindo ao apertar o espa?o
        if (Input.GetKeyDown(KeyCode.Space)) {
            //fazendo a velocidade do RB ir para cima
            meuRB.velocity = Vector2.up * velocidade;

            //salvando a instancia criada em uma variavel
            GameObject meuPuff = Instantiate(puff, transform.position, Quaternion.identity);

            Destroy(meuPuff, 1.5f);  
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

    private void VerificaLimites() {
        if (transform.position.y > 6f || transform.position.y < -6f) {
            SceneManager.LoadScene("Jogo");
        }
    }
}
