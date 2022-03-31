using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //pegando o material do fundo
    private Renderer meuFundo;

    //posicao do meu offset X
    private float xOffset = 0f;

    //posicao da minha textura
    private Vector2 texturaOffset;

    [SerializeField] private float velocidade = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //pegando meu fundo
        meuFundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xOffset += (velocidade * Time.deltaTime);

        texturaOffset.x = xOffset;

        //movendo o offset x do meu renderer
        meuFundo.material.mainTextureOffset = texturaOffset;
    }
}
