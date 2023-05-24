using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_cube : MonoBehaviour
{
    public GameObject canvasObject; // Référence vers le GameObject contenant le Canvas
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Goal")
        {
            Debug.Log("Félicitations, vous avez atteint le but !");
            canvasObject.SetActive(true); // Active le Canvas
        }
    }
}
