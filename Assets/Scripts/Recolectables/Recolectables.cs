using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Recolectables : MonoBehaviour
{
    public int CantidadPanes;
    public TextMeshProUGUI numero;
    private void Update()
    {
        numero.text = ("Panes: "+CantidadPanes.ToString()+" / 7");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bread"))
        {
            Destroy(other.gameObject);
            CantidadPanes++;
        }
    }
}
