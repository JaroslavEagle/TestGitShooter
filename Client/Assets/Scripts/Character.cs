using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [field: SerializeField] public int maxHeallth { get; protected set; } = 10;
    [field: SerializeField] public float speed { get; protected set; } = 2f;
    public Vector3 velocity { get; protected set; }
}
