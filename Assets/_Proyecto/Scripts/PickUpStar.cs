using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PickUpStar : RetroStar
{
    [SerializeField] private int scoreGiven;
    public TextMeshPro scoreBoard;
    //Hacer un scoreboard que reciba y se actualice correctamente
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        _pickingCollider = collision;
        _collidingObject = collision.gameObject;
        PickItem(collision.gameObject);
        Debug.Log($"Agarré {collision} de manera especial");
        //La idea es que ahora podría usar las estrellas para meter un sistema de puntuación paralela a la recolección de estrellas o algo del estilo
        //Pero no tengo tanto tiempo :c solo dejo la posibilidad ahi
        scoreBoard.text += scoreGiven;
    }
}
