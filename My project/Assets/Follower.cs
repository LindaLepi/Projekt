using UnityEngine;
using PathCreation; // You'll need to include this namespace

public class MyScript : MonoBehaviour
{
   // This needs to be assigned to in the inspector
   public PathCreator pathCreator;

   void Start()
   {
       // You can now access the vertex path with pathCreator.path
       // For example, this sets the position to the middle of the path:
       transform.position = pathCreator.path.GetPoint(0.5f);
   }
}