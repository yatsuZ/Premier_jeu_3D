using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    // Start est appeler avant la premier frame d'update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update est appeler une fois par frame
    void Update()
    {
        
    }

    // Similaire à update mais n'est pas apeller frame par frame mais à temp regulier
    void FixedUpdate()
    {
        // Input.GetAxis done 1 0 ou -1 en fonction de la ou es qu'on appuye ou non.
        transform.Translate(Vector3.forward * 5f * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        transform.Translate(Vector3.right * 5f * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
    }

}
