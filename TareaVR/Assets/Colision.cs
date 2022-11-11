using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Colision : MonoBehaviour
{
 public Text TextoGanar;    
    void Start()
    {
TextoGanar.text="";
    }
   
void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Lampara"))
{
    other.gameObject.SetActive(false);
    setTextoGanar();
    
}


}

void setTextoGanar(){

TextoGanar.text = "¡Ganaste!";

}
}
