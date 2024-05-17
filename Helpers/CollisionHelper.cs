// Ignore Spelling: MVBP

using System.Collections.Generic;
using Jotunn;
using UnityEngine;

namespace MVBP.Helpers
{
    internal static class CollisionHelper
    {
        internal static void AddBoxCollider(GameObject prefab, Vector3 center, Vector3 size)
        {
            var collider = prefab.AddComponent<BoxCollider>();
            collider.center = center;
            collider.size = size;
        }


        /// <summary>
        ///     Adds a box collider to the prefab based on rendering bounds
        ///     of the object
        /// </summary>
        /// <param name="prefab"></param>
        internal static void PatchCollider(GameObject prefab)
        {
            // Needed to make some things work, like Stalagmite, Rock_destructible, Rock_7, silvervein, etc.
            var desiredBounds = GetRendererBounds(prefab);
            AddBoxCollider(prefab, desiredBounds.center, desiredBounds.size);
        }


        /// <summary>
        ///     Creates a bounding box that encapsulating the bounds of
        ///     all Renderer's attached to the GameObject
        /// </summary>
        /// <param name="prefab"></param>
        /// <returns></returns>
        internal static Bounds GetRendererBounds(GameObject prefab){
            Bounds desiredBounds = new();
            foreach (Renderer renderer in prefab.GetComponentsInChildren<Renderer>())
            {
                desiredBounds.Encapsulate(renderer.bounds);
            }
            return desiredBounds;
        }


        /// <summary>
        ///     Creates a bounding box that encapsulating the bounds of
        ///     all Meshes attached to the GameObject via MeshFilter or
        ///     SkinnedMeshRenderer components
        /// </summary>
        /// <param name="prefab"></param>
        /// <returns></returns>
        internal static Bounds GetMeshBounds(GameObject prefab){
            Bounds desiredBounds = new();
            foreach (MeshFilter meshFilter in prefab.GetComponentsInChildren<MeshFilter>())
            {
                desiredBounds.Encapsulate(meshFilter.mesh.bounds);
            }

            foreach (SkinnedMeshRenderer skinMeshRender in prefab.GetComponentsInChildren<SkinnedMeshRenderer>())
            {
                desiredBounds.Encapsulate(skinMeshRender.mesh.bounds);
            }
            return desiredBounds;
        }

        /// <summary>
        ///     Creates a bounding box that encapsulating the bounds of
        ///     all Colliders attached to the GameObject that are active
        ///     and not trigger colliders
        /// </summary>
        /// <param name="prefab"></param>
        /// <returns></returns>
        internal static Bounds GetColliderBounds(GameObject prefab){
            Bounds desiredBounds = new();
            foreach (Collider collider in GetAllColliders(prefab))
            {
                desiredBounds.Encapsulate(collider.bounds);
            }
            return desiredBounds;
        }


        internal static void RemoveColliders(GameObject prefab)
        {
            Collider[] colliders = prefab.GetComponentsInChildren<Collider>();
            foreach (Collider collider in colliders)
            {
                Object.DestroyImmediate(collider);
            }
        }

        internal static Vector3 GetCenter(GameObject prefab)
        {
            List<Collider> allColliders = GetAllColliders(prefab);
            Vector3 localCenter = Vector3.zero;
            foreach (Collider item in allColliders)
            {
                if ((bool)item)
                {
                    localCenter += item.bounds.center;
                }
            }
            localCenter /= allColliders.Count;
            return localCenter;
        }

        internal static List<Collider> GetAllColliders(GameObject prefab)
        {
            Collider[] componentsInChildren = prefab.GetComponentsInChildren<Collider>();
            List<Collider> colliders = new()
            {
                Capacity = componentsInChildren.Length
            };
            Collider[] array = componentsInChildren;
            foreach (Collider collider in array)
            {
                if (collider.enabled && collider.gameObject.activeInHierarchy && !collider.isTrigger)
                {
                    colliders.Add(collider);
                }
            }
            return colliders;
        }
    }
}
