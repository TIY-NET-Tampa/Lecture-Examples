using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkReview
{
    public class Building
    {
        #region Question
        // How to do a read only property that can be changed by a method
        private int occupants;

        public int Occupants
        {
            get { return occupants; }
        }

        public void IncreaseOccupants(int people)
        {
            this.occupants += people;
        }
        #endregion

        #region Question
        // Create a building contstructor that setst he constuction type

        public string BuildingType { get; set; }
        public Building(string buildingType)
        {
            this.BuildingType = buildingType;
        }
        #endregion
    }
}
