using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public interface ICollectable
    {
        void Collect();  // M�todo que ser� chamado quando o item for coletado
    }
}
