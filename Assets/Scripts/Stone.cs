using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
