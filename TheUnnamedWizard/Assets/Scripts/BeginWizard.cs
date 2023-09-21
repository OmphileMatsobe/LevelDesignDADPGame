using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginWizard : MonoBehaviour
{
    [SerializeField]
    private GameObject Wizard;


    private void Awake()
    {
        Wizard.transform.position = gameObject.transform.position;
    }
}
