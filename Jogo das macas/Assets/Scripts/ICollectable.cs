using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public interface ICollectable
    {
        void Collect();  // Método que será chamado quando o item for coletado
    }
}
