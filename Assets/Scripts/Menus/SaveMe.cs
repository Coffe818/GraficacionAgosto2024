using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Mantener el objeto en todas las escenas para que se siga reproduciendo la musica
        DontDestroyOnLoad(this.gameObject);
    }

}
