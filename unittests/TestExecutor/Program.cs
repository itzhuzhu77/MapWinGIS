﻿using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using MapWinGISTests;

namespace ConsoleApplication1
{
    /// <summary>
    /// This program is used as Debug target for MapWinGIS project. 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestData\";
            Directory.SetCurrentDirectory(path);
            Debug.WriteLine("Current path: " + Directory.GetCurrentDirectory());

            /* *******************************************
             * This binary is used in MapWinGIS to debug
             * and step through the C++ code
             * First make a unit test in the MapWinGISTests 
             * project (also in this solution)
             * Next call this tests below,
             * compile this solution and now you can
             * debug MapWinGIS and set break points
             * *******************************************/

            // var t = new GdalTests();
            // t.CreateLayerSQLiteTest();
            // t.GdalInfoHdf5();

            // var t = new OgrDatasourceTests();
            // t.ImportShapefileTest();

            //var t = new ShapefileTests();
            //t.Reproject2280Test();

            var t = new UtilTests();
            t.ZonalStatistics();

            Console.ReadLine();
        }
    }
}
