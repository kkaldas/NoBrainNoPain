﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Essa classe estah meio que fazendo uma função de ataque Ranged para o Player.
// Talvez possa ser usada no futuro para fazer ataque de inimigos também.
public class Ataque : MonoBehaviour
{
    [SerializeField] GameObject Boca; //spawn point do vomito
    [SerializeField] GameObject mordida;
    [SerializeField] GameObject Vomito; //o vomito em si, que por si soh jah se move.
    public float vomitoMaximo = 100f;
    [SerializeField] float vomitoAtual;
    
    bool podevomito;
    public vida barraVomito;


    private void Start()
    {
        StartCoroutine(zeraVomito());
    }

    IEnumerator zeraVomito(){
        yield return null;
        yield return null;
        setVomitoAtual(0);
    }

    public float getVomitoAtual()
    {
        return this.vomitoAtual;
    }

    public void setVomitoAtual(float value)
    {
        if(Comprou.estamagos == 0)
        {
            vomitoAtual = 0;
            barraVomito.VidaDoPersonagem = 0;
        } else {
            vomitoAtual = value;
            barraVomito.VidaDoPersonagem = vomitoAtual;
        }
    }

    public void TentarAtaqueRanged(){
        if (vomitoAtual > 99) {
            Instantiate(Vomito, Boca.transform.position, Boca.transform.rotation);
            setVomitoAtual(0);
        }
    }

    public void TentarAtaqueMelee(){
        Instantiate(mordida, Boca.transform.position, Boca.transform.rotation);
    }

}