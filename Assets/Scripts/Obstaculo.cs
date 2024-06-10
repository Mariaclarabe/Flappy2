using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour 
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoDaPosicaoY;
    private Vector3 posicaoPassaro;
    private UIcontroler controladorUI;

    private bool pontuei;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Start(){
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;
        this.controladorUI = GameObject.FindObjectOfType<UIcontroler>();
    }

    //Uptade is called one per frame 
    void Update () 
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
        if(!this.pontuei && this.transform.position.x < posicaoPassaro.x){
            this.controladorUI.adicionarPontos();
            this.pontuei = true; 
        }
       
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}
