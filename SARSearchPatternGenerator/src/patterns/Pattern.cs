﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SARSearchPatternGenerator
{
    [DataContract]
    [KnownType(typeof(DecDeg))]
    [KnownType(typeof(DegDecMin))]
    [KnownType(typeof(DegMinSec))]
    [KnownType(typeof(UTMCoord))]
    public class Pattern
    {
        public static List<Color> legColors = new List<Color>(new Color[]
        {
            Color.Red,
            Color.Blue,
            Color.Yellow,
            Color.Purple,
            Color.Green,
            Color.Orange,
            Color.Cyan
        });

        [DataMember]
        protected List<Coordinate> points;

        protected double legDistance, totalTrackLength, areaEffectivelySwept, areaCoverage, searchedArea, searchTime, probabilityOfDetection;
        protected int numLegs;
        protected bool turnRight;


        public Pattern()
        {
            points = new List<Coordinate>();
        }

        public void addPoint(Coordinate point)
        {
            points.Add(point);
        }

        public Coordinate getPoint(int index)
        {
            return points[index];
        }

        public List<Coordinate> getPattern()
        {
            return points;
        }

        public void removePoint(Coordinate point)
        {
            points.Remove(point);
        }

        public void clearPoints()
        {
            points = new List<Coordinate>();
        }


        /*
         *  Finds and returns the max latitude value of a pattern.
         */
        public double maxLat()
        {
            double max = points[0].getLat();
            for (int i = 1; i < points.Count; i++)
            {
                max = Math.Max(max, points[i].getLat());
            }
            return max;
        }


        /*
         *  Finds and returns the max longitude value of a pattern.
         */
        public double maxLong()
        {
            double max = points[0].getLng();
            for (int i = 1; i < points.Count; i++)
            {
                max = Math.Max(max, points[i].getLng());
            }
            return max;
        }


        /*
         *  Finds and returns the minimum latitude value of a pattern.
         */
        public double minLat()
        {
            double min = points[0].getLat();
            for (int i = 1; i < points.Count; i++)
            {
                min = Math.Min(min, points[i].getLat());
            }
            return min;
        }


        /*
         *  Finds and returns the minimum longitude value of a pattern.
         */
        public double minLong()
        {
            double min = points[0].getLng();
            for (int i = 1; i < points.Count; i++)
            {
                min = Math.Min(min, points[i].getLng());
            }
            return min;
        }

        public virtual void calculatePatternInfo(double searchSpeed, double sweepWidth)
        {

        }
    }
}
