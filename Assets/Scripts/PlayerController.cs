using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //pegando as informa��es do player
    private Rigidbody2D meuRB;

    // Start is called before the first frame update
    void Start()
    {
        //pegando meu RB sozinho
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
