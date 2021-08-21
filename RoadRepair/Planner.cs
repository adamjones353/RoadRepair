using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RoadRepair
{
    public class Planner
    {
        /// <summary>
        /// The total number of hours needed to complete the work.
        /// </summary>
        public double HoursOfWork { get; set; }

        /// <summary>
        /// The number of people available to do the work
        /// </summary>
        public double Workers { get; set; }

        /// <summary>
        /// The time to complete the work, using all the workers.
        /// </summary>
        /// <returns>The number of hours to complete the work.</returns>
        public double GetTime()
        {
            double time = HoursOfWork / Workers;
            return time;
        }

        /// <summary>
        /// Return the correct type of repair (either a patch or a resurface) depending on
        /// the density of potholes.
        /// </summary>
        /// <param name="road">A road needing repair</param>
        /// <returns>Either a PatchingRepair or a Resurfacing</returns>
        public object SelectRepairType(Road road)
        {
            // Use the road.Width, road.Length and road.Potholes properties to calculate the density of potholes. 

            // If the density of potholes is more than 20% the road should be resurfaced.
            // Otherwise it should be patched.

            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// Calculate the total volume of all the repairs for a list of roads that need repairs.
        /// </summary>
        /// <param name="roads">A list of roads needing repairs</param>
        /// <returns>The total volume of all the repairs</returns>
        public double GetVolumeOfRepairs(List<Road> roads)
        {
            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// When there is not enough material available to repair all the roads,
        /// select a subset of the roads so that the volume of repairs is less than or equal to the available material.
        /// </summary>
        /// <param name="roads">A list of roads needing repairs</param>
        /// <param name="availableMaterial">The volume of material available for repairs</param>
        /// <returns>A subset of roads that can be repaired with the available material</returns>
        public List<Road> SelectRoadsToRepair(List<Road> roads, double availableMaterial)
        {
            throw new NotImplementedException("TODO");
        }
    }

}
