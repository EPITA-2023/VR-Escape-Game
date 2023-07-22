using UnityEngine;

[ExecuteAlways] // 에디터 모드에서도 실행되어 테스트가 쉽다.
public class RevealObject : MonoBehaviour
{
    [SerializeField] Light SpotLight;

    private Material m_Mat;

    private void Start()
    {
        m_Mat = GetComponent<Renderer>().sharedMaterial;
    }

    private void Update()
    {
        m_Mat.SetVector("_MyLightPosition", SpotLight.transform.position);
        m_Mat.SetVector("_MyLightDirection", -SpotLight.transform.forward);
    }
}