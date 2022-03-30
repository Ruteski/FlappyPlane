using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade = 4f;
    [SerializeField] private GameObject eu;

    [SerializeField] private GameController game;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(eu, 5f);

        //encontrando o game controller da cena atual
        game = FindObjectOfType<GameController>();

        velocidade += game.RetornaLevel();
    }

    // Update is called once per frame
    void Update()
    {
        //indo pra esquerda
        transform.position += Time.deltaTime * velocidade * Vector3.left;
    }
}
