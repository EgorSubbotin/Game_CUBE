using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager theGameManager;
    private void OnTriggerEnter()
    {
        theGameManager.CompliteLevel();
    }
}
