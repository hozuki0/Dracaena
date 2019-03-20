﻿using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace glTFIOTest
{
    [TestClass]
    public class glTFFileTest
    {
        [TestMethod]
        public void LoadBox()
        {
            var gltf = Load("../../../sample/Box/gltf/box.gltf");
            Assert.IsNotNull(gltf);
            ShowChunk(gltf);
        }

        private glTFIO.glTFFile Load(string filePath)
        {
            return new glTFIO.glTFFile(filePath); ;
        }

        private static void ShowChunk(glTFIO.glTFFile gltf)
        {
            var props = gltf.GetType().GetProperties();
            foreach (var item in props)
            {
                if (item.PropertyType.IsArray)
                {
                    var arr = gltf.GetType().InvokeMember(item.Name, System.Reflection.BindingFlags.GetProperty, null, gltf, null) as IEnumerable;
                    ShowAllMember(arr);
                }
                else
                {
                    ShowAllMember(gltf.GetType().InvokeMember(item.Name, System.Reflection.BindingFlags.GetProperty, null, gltf, null));
                }
            }
        }

        private static void ShowAllMember<T>(T value)
        {
            if (value == null) return;
            Console.WriteLine($"--{value.GetType()}Begin--");

            var props = value.GetType().GetProperties();
            foreach (var p in props)
            {
                var v = value.GetType().InvokeMember(p.Name, System.Reflection.BindingFlags.GetProperty, null, value, null);
                if (v == null) continue;

                if (IsSubClassOfDataChunk(p.PropertyType))
                {
                    ShowAllMember(v);
                }
                else if (IsSubClassOfDataChunkArray(p.PropertyType))
                {
                    ShowAllMember(v as IEnumerable);
                }
                else if (p.PropertyType.IsArray)
                {
                    var arr = v as IEnumerable;
                    foreach (var item in arr)
                    {
                        Console.WriteLine($"{p.Name}:{item}");
                    }
                }
                else
                {
                    Console.WriteLine($"{p.Name}:{v}");
                }
            }

            Console.WriteLine($"--{value.GetType()}End--\n");
        }

        private static void ShowAllMember(IEnumerable values)
        {
            if (values == null) return;
            foreach (var item in values)
            {
                ShowAllMember(item);
            }
        }

        private static bool IsSubClassOfDataChunk(Type type)
        {
            return type.IsSubclassOf(typeof(glTFIO.Internal.glTFDataChunkBase));
        }

        private static bool IsSubClassOfDataChunkArray(Type type)
        {
            return type.IsArray && type.GetElementType().IsSubclassOf(typeof(glTFIO.Internal.glTFDataChunkBase));
        }
    }
}