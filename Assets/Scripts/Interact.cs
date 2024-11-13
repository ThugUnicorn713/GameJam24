using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Interact : MonoBehaviour
{
    
    public void OnInteract()
    {
        Debug.Log("Interacted with " + gameObject.name);
        gameObject.SetActive(false);
    }

    

}

    

