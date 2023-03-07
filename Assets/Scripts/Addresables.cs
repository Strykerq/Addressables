using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Addresables : MonoBehaviour
{

    private IEnumerator Start()
    {
        var prefab = "Assets/Prefabs/Cube.prefab";
        var handle = Addressables.LoadAssetAsync<GameObject>(prefab);
        yield return handle;
        var cube = handle.Result;
        Instantiate(cube);
    }
}
