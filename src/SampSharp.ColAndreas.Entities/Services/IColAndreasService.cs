using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.ColAndreas.Entities.Services
{
    public interface IColAndreasService
    {
        bool Init();

        int RayCastLine(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z);

        int RayCastLine(Vector3 start, Vector3 end, out Vector3 hit);

        int RayCastLineAngle(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float rx, out float ry, out float rz);

        int RayCastLineAngle(Vector3 start, Vector3 end, out Vector3 hit, out Vector3 hitRotation);

        bool FindZ_For2DCoord(float x, float y, out float z);

        bool FindZ_For2DCoord(Vector2 xy, out float z);

        Vector3 FindZ_For2DCoord(Vector3 position);

        bool RemoveBuilding(int modelId, float x, float y, float z, float radius);

        bool RemoveBuilding(int modelId, Vector3 center, float radius);

        int GetModelBoundingBox(int modelId, out float minX, out float minY, out float minZ, out float maxX, out float maxY, out float maxZ);

        int GetModelBoundingBox(int modelId, out Vector3 min, out Vector3 max);

        int GetModelBoundingSphere(int modelId, out Vector3 off, out float radius);

        bool IsPlayerFacingWater(EntityId player, float dist = 3.0f, float height = 3.0f);
    }
}
