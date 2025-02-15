using SampSharp.ColAndreas.Entities.Definitions;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampSharp.ColAndreas.Entities.Services
{
    public class ColAndreasService : IColAndreasService
    {
        private readonly ColAndreasServiceNative _native;
        private readonly IEntityManager _entityManager;

        public ColAndreasService(IEntityManager entityManager, INativeProxy<ColAndreasServiceNative> nativeProxy)
        {
            _entityManager = entityManager;
            _native = nativeProxy.Instance;
        }

        /// <summary>
        /// Attempts to load data and initialize the plugin.
        /// </summary>
        /// <returns>true if successful</returns>
        /// <returns>false if unsuccessful</returns>
        public bool Init()
        {
            return _native.Init();
        }

        /// <summary>
        /// Attempts to remove all the buildings from the world within the given radius.
        /// </summary>
        /// <param name="modelId">The object's model.</param>
        /// <param name="x,y,z">The center point of the radius circle.</param>
        /// <param name="radius">The radius to remove buildings.</param>
        /// <returns>true if successful</returns>
        /// <returns>false if unsuccessful</returns>
        public bool RemoveBuilding(int modelId, float x, float y, float z, float radius)
        {
            return _native.RemoveBuilding(modelId, x, y, z, radius);
        }
        public bool RemoveBuilding(int modelId, Vector3 center, float radius)
        {
            return _native.RemoveBuilding(modelId, center.X, center.Y, center.Z, radius);
        }

        /// <summary>
        /// Attempts to detect collision.
        /// </summary>
        /// <param name="startX,startY,startZ">The starting point.</param>
        /// <param name="endX,endY,endZ">The ending point.</param>
        /// <param name="x,y,z">The resulting hit position.</param>
        /// <returns>0 if nothing is detected.</returns>
        /// <returns>WATER_MODEL if it hit water.</returns>
        /// <returns>modelId if it made collision.</returns>
        public int RayCastLine(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z)
        {
            return _native.RayCastLine(startX, startY, startZ, endX, endY, endZ, out x, out y, out z);
        }

        public int RayCastLine(Vector3 start, Vector3 end, out Vector3 hit)
        {
            int modelId = _native.RayCastLine(start.X, start.Y, start.Z, end.X, end.Y, end.Z, out float x, out float y, out float z);

            hit = (modelId == 0) ? Vector3.Zero : new Vector3(x, y, z);
            return modelId;
        }

        /// <summary>
        /// Attempts to detect collision with object, gives the rotation.
        /// </summary>
        /// <param name="startX,startY,startZ">The starting point.</param>
        /// <param name="endX,endY,endZ">The ending point.</param>
        /// <param name="x,y,z">The resulting hit position.</param>
        /// <param name="rx,ry,rz">The resulting hit rotation.</param>
        /// <returns>0 if didn't collide with anything.</returns>
        /// <returns>WATER_MODEL if it hit water.</returns>
        /// <returns>modelId if it made collision.</returns>
        public int RayCastLineAngle(float startX, float startY, float startZ, float endX, float endY, float endZ, out float x, out float y, out float z, out float rx, out float ry, out float rz)
        {
            return _native.RayCastLineAngle(startX, startY, startZ, endX, endY, endZ, out x, out y, out z, out rx, out ry, out rz);
        }

        public int RayCastLineAngle(Vector3 start, Vector3 end, out Vector3 hit, out Vector3 hitRotation)
        {
            int modelId = _native.RayCastLineAngle(
                start.X, start.Y, start.Z, end.X, end.Y, end.Z,
                out float x, out float y, out float z, out float rx, out float ry, out float rz
            );

            hit = (modelId == 0) ? Vector3.Zero : new Vector3(x, y, z);
            hitRotation = (modelId == 0) ? Vector3.Zero : new Vector3(rx, ry, rz);
            return modelId;
        }

        /// <summary>
        /// ColAndreas wrapper for the MapAndreas function.
        /// </summary>
        /// <param name="x,y,z"></param>
        /// <returns></returns>
        public bool FindZ_For2DCoord(float x, float y, out float z)
        {
            if (RayCastLine(x, y, 700.0f, x, y, -1000.0f, out x, out y, out z) <= 0)
            {
                return false;
            }
            return true;
        }
        public bool FindZ_For2DCoord(Vector2 xy, out float z)
        {
            if (RayCastLine(xy.X, xy.Y, 700.0f, xy.X, xy.Y, -1000.0f, out float x, out float y, out z) <= 0)
            {
                return false;
            }
            return true;
        }
        public Vector3 FindZ_For2DCoord(Vector3 position)
        {
            if (RayCastLine(position.X, position.Y, 700.0f, position.X, position.Y, -1000.0f, out float x, out float y, out float z) <= 0)
            {
                return Vector3.Zero;
            }
            return new Vector3(x, y, z);
        }

        /// <summary>
        /// Gets the bounding box of the modelId.
        /// </summary>
        /// <param name="modelId">The modelId of the object</param>
        /// <param name="minX,minY,minZ">The retrieved point of the one side of the box</param>
        /// <param name="maxX,maxY,maxZ">The retrieved point of the other side of the box</param>
        /// <returns>0 if modelId is invalid</returns>
        /// <returns>1 if successful</returns>
        public int GetModelBoundingBox(int modelId, out float minX, out float minY, out float minZ, out float maxX, out float maxY, out float maxZ)
        {
            return _native.GetModelBoundingBox(modelId, out minX, out minY, out minZ, out maxX, out maxY, out maxZ);
        }
        public int GetModelBoundingBox(int modelId, out Vector3 min, out Vector3 max)
        {
            int result = _native.GetModelBoundingBox(
                modelId,
                out float minX, out float minY, out float minZ,
                out float maxX, out float maxY, out float maxZ
            );

            min = new Vector3(minX, minY, minZ);
            max = new Vector3(maxX, maxY, maxZ);
            return result;
        }

        public int GetModelBoundingSphere(int modelId, out float offx, out float offy, out float offz, out float radius)
        {
            return _native.GetModelBoundingSphere(modelId, out offx, out offy, out offz, out radius);
        }

        public int GetModelBoundingSphere(int modelId, out Vector3 off, out float radius)
        {
            int returnValue = GetModelBoundingSphere(modelId, out float offx, out float offy, out float offz, out radius);

            off = new Vector3(offx, offy, offz);

            return returnValue;
        }

        /// <summary>
        /// Determines if the given player is facing water.
        /// This is achieved by offsetting from the player's position based on their facing angle,
        /// then casting a ray downward to see if it intersects water.
        /// </summary>
        /// <param name="player">The player entity.</param>
        /// <param name="dist">The horizontal distance from the player to start the ray.</param>
        /// <param name="height">The vertical distance (downward) to cast the ray.</param>
        /// <returns>True if the raycast hit water, false otherwise.</returns>
        public bool IsPlayerFacingWater(EntityId player, float dist = 3.0f, float height = 3.0f)
        {
            // Verify that the entity is a player.
            if (!player.IsOfAnyType(SampEntities.PlayerType))
            {
                throw new InvalidEntityArgumentException(nameof(player), SampEntities.PlayerType);
            }

            // Retrieve the player component (assumes a Player component is attached to the entity)
            var p = _entityManager.GetComponent<Player>();

            // Get player's current position.
            Vector3 pos = p.Position;
            // Get player's facing angle (in degrees).
            float facingAngle = p.Angle;

            // Calculate the offset based on the player's facing angle.
            float rad = -facingAngle * (float)Math.PI / 180.0f;
            float offsetX = dist * (float)Math.Sin(rad);
            float offsetY = dist * (float)Math.Cos(rad);

            // Compute start and end points for the raycast.
            Vector3 startPos = new Vector3(pos.X + offsetX, pos.Y + offsetY, pos.Z);
            Vector3 endPos = new Vector3(pos.X + offsetX, pos.Y + offsetY, pos.Z - height);

            // Perform the raycast.
            // The RayCastLine method should return an integer representing the type of object hit,
            // and output the hit position and normal.
            int hitType = RayCastLine(startPos, endPos, out Vector3 hitPos);

            // If the hit type equals WATER_MODEL, the player is facing water.
            return hitType == ColAndreasVars.WATER_MODEL;
        }
    }
}