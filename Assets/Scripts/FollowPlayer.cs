using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform thePlayer;
   public  Vector3 temp;    

    void Update()
    {
        transform.position = thePlayer.position + temp;
    }
}
