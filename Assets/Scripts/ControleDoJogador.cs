using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleDoJogador : MonoBehaviour
{
    public float velocidadeDoJogador;
    public Rigidbody oRigibody;

    private float movimentoX;
    private float movimentoZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarBola();
    }
    private void MovimentarBola()
    {
        movimentoX = Input.GetAxis("Horizontal") * velocidadeDoJogador;
        movimentoZ = Input.GetAxis("Vertical") * velocidadeDoJogador;

        oRigibody.AddForce(movimentoX, 0f, movimentoZ);

    }
}
