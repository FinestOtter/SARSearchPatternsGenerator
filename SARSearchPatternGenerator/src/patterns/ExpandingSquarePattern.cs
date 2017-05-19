﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SARSearchPatternGenerator
{
    /// <summary>
    /// Contains methods that generate an expanding square pattern and stores
    /// the coordinates in the points variable.
    /// </summary>
    public class ExpandingSquarePattern : Pattern
    {
        public ExpandingSquarePattern() :base() {}

        /*
         * Generates an expanding square search starting at the datum with the
         * given number of legs of the given size. The first leg will go in the
         * bearing specified by orientation, and then you will turn right or left
         * depending on the value of turnRight for the first turn.
         */
        public List<Coordinate> generatePattern(Coordinate datum, int numLegs, double orientation, double firstLegDistance, bool turnRight, DistanceUnit dUnit)
        {
            double turnDegrees, legDistance = firstLegDistance;
            bool secondLeg = false;
            addPoint(datum);

            if(turnRight)
            {
                turnDegrees = 90;
            }
            else
            {
                turnDegrees = -90;
            }

            //leg is just a move and a turn

            for (int i = 0; i < numLegs; i++)
            {
                //Add a point that is the legDistance away from the datum in the
                //direction of the orientation.
                addPoint(points.ElementAt(i).travel(orientation, legDistance, dUnit));

                //Turn orientation for next leg
                orientation += turnDegrees;

                if (secondLeg)
                {
                    //Increase legDistance
                    legDistance += firstLegDistance;
                }

                secondLeg = !secondLeg;
            }

            return points;
        }
    }
}
