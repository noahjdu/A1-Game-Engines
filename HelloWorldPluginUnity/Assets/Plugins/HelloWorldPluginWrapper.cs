using UnityEngine;
using System.Runtime.InteropServices;

public class HelloWorldPluginWrapper : MonoBehaviour
{
    public GameObject player;
    Vector3 positionInitial;

    const string DLL_NAME = "HelloWorldPlugin";

    [DllImport(DLL_NAME)]
    private static extern System.IntPtr SayHello();

    [DllImport(DLL_NAME)]
    private static extern void SetPosition(Vector3 position);

    [DllImport(DLL_NAME)]
    private static extern Vector3 GetPos();

    [DllImport(DLL_NAME)]
    private static extern int Add(int first, int second);

	




    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
           // print(Add(7, 3));
           positionInitial = player.transform.position;
            Debug.Log(positionInitial);

            SetPosition(positionInitial);
            //System.IntPtr intPtr = SayHello();
           // string message = Marshal.PtrToStringAnsi(intPtr);
           
            Debug.Log(positionInitial);
        }
        else if(Input.GetKeyDown(KeyCode.G))
        {

            player.transform.position =  GetPos();
            //string message = Marshal.PtrToStringAnsi(SayHello());

            Debug.Log(GetPos());
        }
    }
}
