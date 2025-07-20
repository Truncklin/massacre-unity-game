using System.Collections;
using UnityEngine;

public class CartoonPunchSystem : MonoBehaviour
{
    [Header("Деформация")]
    public SkinnedMeshRenderer headMesh;
    public float deformRadius = 0.3f;
    public float maxDeform = 0.5f;

    [Header("Эффекты")]
    public ParticleSystem starsFX;
    public AudioClip[] punchSounds; // Резиновые/плюшевые звуки

    private Vector3[] originalVertices;
    private bool isDeformed;

    void Start() {
        // Кэшируем оригинальные вершины
        originalVertices = headMesh.sharedMesh.vertices;
    }

    public void Punch(Vector3 hitPoint, float force) {
        // 1. Деформация меша
        StartCoroutine(DeformHead(hitPoint, force));

        // 2. Визуальные эффекты
        Instantiate(starsFX, hitPoint, Quaternion.identity);
        SFXPlayer.PlayRandom(punchSounds, pitch: force);

        // 3. Тряска камеры
        CinemachineShake.Instance.Shake(force / 2f);
    }

    IEnumerator DeformHead(Vector3 hitPoint, float force) {
        Vector3[] vertices = headMesh.sharedMesh.vertices;
        
        for (int i = 0; i < vertices.Length; i++) {
            float distance = Vector3.Distance(hitPoint, vertices[i]);
            if (distance < deformRadius) {
                vertices[i] += Random.insideUnitSphere * (force * maxDeform);
            }
        }

        headMesh.sharedMesh.vertices = vertices;
        yield return new WaitForSeconds(0.5f);
        ResetDeformation();
    }

    void ResetDeformation() {
        headMesh.sharedMesh.vertices = originalVertices;
    }
}