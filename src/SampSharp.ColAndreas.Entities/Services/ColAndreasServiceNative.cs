using SampSharp.Core.Natives.NativeObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.ColAndreas.Entities.Services
{
    #pragma warning disable 1591

    public class ColAndreasServiceNative
    {
        [NativeMethod(Function = "CA_Init")]
        public virtual bool Init()
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RemoveBuilding")]
        public virtual bool RemoveBuilding(int modelId, float x, float y, float z, float radius)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastLine")]
        public virtual int RayCastLine(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastLineId")]
        public virtual int RayCastLineId(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastLineExtraID")]
        public virtual int RayCastLineExtraId(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(11, 11, 11, 11, 11, Function = "CA_RayCastMultiLine")]
        public virtual int RayCastMultiLine(float startX, float startY, float startZ, float endX, float endY, float endZ, out float[] x, out float[] y, out float[] z, out float[] distance, out int[] modelId, int size)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastLineAngle")]
        public virtual int RayCastLineAngle(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float rx, out float ry, out float rz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastReflectionVector")]
        public virtual int RayCastReflectionVector(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float nx, out float ny, out float nz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastLineNormal")]
        public virtual int RayCastLineNormal(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float nx, out float ny, out float nz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_ContactTest")]
        public virtual int ContactTest(int modelId, float x, float y, float z, float rx, float ry, float rz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_EulerToQuat")]
        public virtual int EulerToQuat(float rx, float ry, float rz, out float x, out float y, out float z, out float w)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_QuatToEuler")]
        public virtual int QuatToEuler(float x, float y, float z, float w, out float rx, out float ry, out float rz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_GetModelBoundingSphere")]
        public virtual int GetModelBoundingSphere(int modelId, out float offsetX, out float offsetY, out float offsetZ, out float radius)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_GetModelBoundingBox")]
        public virtual int GetModelBoundingBox(int modelId, out float minX, out float minY, out float minZ, out float maxX, out float maxY, out float maxZ)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastLineEx")]
        public virtual int RayCastLineEx(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float rx, out float ry, out float rz, out float rw, out float cx, out float cy, out float cz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_RayCastLineAngleEx")]
        public virtual int RayCastLineAngleEx(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float rx, out float ry, out float rz, out float ocx, out float ocy, out float ocz, out float orx, out float ory, out float orz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_CreateObject")]
        public virtual int CreateObject(int modelId, float x, float y, float z, float rx, float ry, float rz, bool index = false)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_DestroyObject")]
        public virtual int DestroyObject(int collisionId)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_SetObjectPos")]
        public virtual int SetObjectPos(int collisionId, float x, float y, float z)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_SetObjectRot")]
        public virtual int SetObjectRot(int collisionId, float rx, float ry, float rz)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_SetObjectExtraID")]
        public virtual int SetObjectExtraID(int collisionId, int data, int value)
        {
            throw new NativeNotImplementedException();
        }

        [NativeMethod(Function = "CA_GetObjectExtraID")]
        public virtual int GetObjectExtraID(int collisionId, int data)
        {
            throw new NativeNotImplementedException();
        }
    }
}
