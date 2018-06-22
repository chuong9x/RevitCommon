﻿/* 
* Copyright 2012 © Victor Chekalin
* 
* THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
* KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
* PARTICULAR PURPOSE.
* https://github.com/chekalin-v/VCExtensibleStorageExtension
* http://thebuildingcoder.typepad.com/blog/2013/05/effortless-extensible-storage.html
*/

using System;
using Autodesk.Revit.DB;

namespace RevitCommon.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldAttribute : Attribute
    {
        public FieldAttribute()
        {
            UnitType = UnitType.UT_Undefined;
        }

        public string Documentation { get; set; }
        public UnitType UnitType { get; set; }
    }
}
