using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIcontroler : MonoBehaviour

{
    private int pontos;
    private Label textoPontuacao;
    

    

    public void adicionarPontos()
    {
        this.pontos++;
       this.textoPontuacao.text = this.pontos.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
