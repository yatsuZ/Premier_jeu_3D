using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn2 : MonoBehaviour
{
    private Vector3 startPosition; // Position de départ du cube

    // Start is called before the first frame update
    void Start()
    {
        // Stocke la position de départ du cube
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Vérifie si l'objet est en-dessous de la position y -10
        if (transform.position.y < -10f)
        {
            Respawn();
        }
    }

    // Fonction pour faire respawn l'objet
    void Respawn()
    {
        // Réinitialise la position de l'objet au point de respawn
        transform.position = startPosition;
    }
}
