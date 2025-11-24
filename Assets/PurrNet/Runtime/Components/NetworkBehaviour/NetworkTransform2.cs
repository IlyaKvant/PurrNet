using System;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace PurrNet
{
    [Serializable]
    public struct Resolution<T>
    {
        public bool uniformResoltion;
        public T perComponentResolution;
    }

    [Serializable]
    public struct TickRate
    {
        public bool managerDefault;
        public int customRate;
    }

    [Serializable]
    public struct NetworkTransformSettings
    {
        [Header("Rate of sync")]
        public TickRate tickRate;
        [Header("What to sync")]
        public SyncMode syncPosition;
        public SyncMode syncRotation;
        public bool syncScale;
        public bool syncParent;
        [Header("Precision settings")]
        public Resolution<Vector3> positionResolution;
        public Resolution<Vector3> rotationResolution;
        public Resolution<Vector3> scaleResolution;
    }

    public struct NetworkTransformState
    {

    }

    public class NetworkTransform2 : NetworkIdentity
    {
        private void OnEnable()
        {
            UnityLatestUpdate.onLatestUpdate += LatestUpdate;
        }

        private void OnDisable()
        {
            UnityLatestUpdate.onLatestUpdate -= LatestUpdate;
        }

        private void LatestUpdate()
        {

        }
    }
}
