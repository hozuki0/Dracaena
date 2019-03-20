using System;
using System.Linq;
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
            var gltf = Load(@"..\2.0\box\glTF\box.gltf");
            Assert.IsNotNull(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadAvocado()
        {
            var gltf = Load(@"..\2.0\Avocado\glTF\Avocado.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadAnimationCube()
        {
            var gltf = Load(@"C:\Working\Reference\glTF-Sample-Models\2.0\AnimatedCube\glTF\AnimatedCube.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadAnimationMorphSphere()
        {
            var gltf = Load(@"C:\Working\Reference\glTF-Sample-Models\2.0\AnimatedMorphSphere\glTF\AnimatedMorphSphere.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void Load2CylinderEngine()
        {
            var gltf = Load(@"..\2.0\2CylinderEngine\glTF\2CylinderEngine.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadAlphaBlendModeTest()
        {
            var gltf = Load(@"..\2.0\AlphaBlendModeTest\glTF\AlphaBlendModeTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadAnimatedMorphCube()
        {
            var gltf = Load(@"..\2.0\AnimatedMorphCube\glTF\AnimatedMorphCube.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadAnimatedTriangle()
        {
            var gltf = Load(@"..\2.0\AnimatedTriangle\glTF\AnimatedTriangle.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadAntiqueCamera()
        {
            var gltf = Load(@"..\2.0\AntiqueCamera\glTF\AntiqueCamera.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBarramundiFish()
        {
            var gltf = Load(@"..\2.0\BarramundiFish\glTF\BarramundiFish.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBoxAnimated()
        {
            var gltf = Load(@"..\2.0\BoxAnimated\glTF\BoxAnimated.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBoomBox()
        {
            var gltf = Load(@"..\2.0\BoomBox\glTF\BoomBox.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBoxInterleaved()
        {
            var gltf = Load(@"..\2.0\BoxInterleaved\glTF\BoxInterleaved.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBoxTextured()
        {
            var gltf = Load(@"..\2.0\BoxTextured\glTF\BoxTextured.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBoxTexturedNonPowerOfTwo()
        {
            var gltf = Load(@"..\2.0\BoxTexturedNonPowerOfTwo\glTF\BoxTexturedNonPowerOfTwo.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBoxVertexColors()
        {
            var gltf = Load(@"..\2.0\BoxVertexColors\glTF\BoxVertexColors.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBrainStem()
        {
            var gltf = Load(@"..\2.0\BrainStem\glTF\BrainStem.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadBuggy()
        {
            var gltf = Load(@"..\2.0\Buggy\glTF\Buggy.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadCameras()
        {
            var gltf = Load(@"..\2.0\Cameras\glTF\Cameras.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadCesiumMan()
        {
            var gltf = Load(@"..\2.0\CesiumMan\glTF\CesiumMan.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadCesiumMilkTruck()
        {
            var gltf = Load(@"..\2.0\CesiumMilkTruck\glTF\CesiumMilkTruck.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadCorset()
        {
            var gltf = Load(@"..\2.0\Corset\glTF\Corset.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadCube()
        {
            var gltf = Load(@"..\2.0\Cube\glTF\Cube.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadDamagedHelmet()
        {
            var gltf = Load(@"..\2.0\DamagedHelmet\glTF\DamagedHelmet.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadDuck()
        {
            var gltf = Load(@"..\2.0\Duck\glTF\Duck.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadFlightHelmet()
        {
            var gltf = Load(@"..\2.0\FlightHelmet\glTF\FlightHelmet.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadGearboxAssy()
        {
            var gltf = Load(@"..\2.0\GearboxAssy\glTF\GearboxAssy.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadInterpolationTest()
        {
            var gltf = Load(@"..\2.0\InterpolationTest\glTF\InterpolationTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadLantern()
        {
            var gltf = Load(@"..\2.0\Lantern\glTF\Lantern.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadMetalRoughSpheres()
        {
            var gltf = Load(@"..\2.0\MetalRoughSpheres\glTF\MetalRoughSpheres.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadMonster()
        {
            var gltf = Load(@"..\2.0\Monster\glTF\Monster.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadMorphPrimitivesTest()
        {
            var gltf = Load(@"..\2.0\MorphPrimitivesTest\glTF\MorphPrimitivesTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadMultiUVTest()
        {
            var gltf = Load(@"..\2.0\MultiUVTest\glTF\MultiUVTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadNormalTangentMirrorTest()
        {
            var gltf = Load(@"..\2.0\NormalTangentMirrorTest\glTF\NormalTangentMirrorTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadNormalTangentTest()
        {
            var gltf = Load(@"..\2.0\NormalTangentTest\glTF\NormalTangentTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadOrientationTest()
        {
            var gltf = Load(@"..\2.0\OrientationTest\glTF\OrientationTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadReciprocatingSaw()
        {
            var gltf = Load(@"..\2.0\ReciprocatingSaw\glTF\ReciprocatingSaw.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadRiggedFigure()
        {
            var gltf = Load(@"..\2.0\RiggedFigure\glTF\RiggedFigure.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadRiggedSimple()
        {
            var gltf = Load(@"..\2.0\RiggedSimple\glTF\RiggedSimple.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadSciFiHelmet()
        {
            var gltf = Load(@"..\2.0\SciFiHelmet\glTF\SciFiHelmet.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadSimpleSparseAccessor()
        {
            var gltf = Load(@"..\2.0\SimpleSparseAccessor\glTF\SimpleSparseAccessor.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadSimpleMeshes()
        {
            var gltf = Load(@"..\2.0\SimpleMeshes\glTF\SimpleMeshes.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadSimpleMorph()
        {
            var gltf = Load(@"..\2.0\SimpleMorph\glTF\SimpleMorph.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadSpecGlossVsMetalRough()
        {
            var gltf = Load(@"..\2.0\SpecGlossVsMetalRough\glTF\SpecGlossVsMetalRough.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadSponza()
        {
            var gltf = Load(@"..\2.0\Sponza\glTF\Sponza.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadSuzanne()
        {
            var gltf = Load(@"..\2.0\Suzanne\glTF\Suzanne.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadTextureCoordinateTest()
        {
            var gltf = Load(@"..\2.0\TextureCoordinateTest\glTF\TextureCoordinateTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadTextureSettingsTest()
        {
            var gltf = Load(@"..\2.0\TextureSettingsTest\glTF\TextureSettingsTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadTextureTransformTest()
        {
            var gltf = Load(@"..\2.0\TextureTransformTest\glTF\TextureTransformTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadTriangle()
        {
            var gltf = Load(@"..\2.0\Triangle\glTF\Triangle.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadTriangleWithoutIndices()
        {
            var gltf = Load(@"..\2.0\TriangleWithoutIndices\glTF\TriangleWithoutIndices.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadTwoSidedPlane()
        {
            var gltf = Load(@"..\2.0\TwoSidedPlane\glTF\TwoSidedPlane.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadUnlitTest()
        {
            var gltf = Load(@"..\2.0\UnlitTest\glTF\UnlitTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadVC()
        {
            var gltf = Load(@"..\2.0\VC\glTF\VC.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadVertexColorTest()
        {
            var gltf = Load(@"..\2.0\VertexColorTest\glTF\VertexColorTest.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }
        [TestMethod]
        public void LoadWaterBottle()
        {
            var gltf = Load(@"..\2.0\WaterBottle\glTF\WaterBottle.gltf");
            Assert.IsNotNull(gltf);
            CheckRequiredItem(gltf);
            ShowChunk(gltf);
        }

        private void CheckRequiredItem(glTFIO.glTFFile file)
        {
            Assert.IsNotNull(file.Asset);
            Assert.IsNotNull(file.BufferViews);
            Assert.IsNotNull(file.Buffers);
            Assert.IsNotNull(file.Scenes);
            Assert.IsNotNull(file.Meshes);
            Assert.IsNotNull(file.Nodes);
            Assert.IsNotNull(file.Accessors);

            Assert.IsFalse(file.BufferViews.Length == 0);
            Assert.IsFalse(file.Buffers.Length == 0);
            Assert.IsFalse(file.Scenes.Length == 0);
            Assert.IsFalse(file.Meshes.Length == 0);
            Assert.IsFalse(file.Nodes.Length == 0);
            Assert.IsFalse(file.Accessors.Length == 0);
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
                else if (IsDictionary(p.PropertyType))
                {
                    var keys = v.GetType().InvokeMember("Keys", System.Reflection.BindingFlags.GetProperty, null, v, null) as IEnumerable;
                    var values = v.GetType().InvokeMember("Values", System.Reflection.BindingFlags.GetProperty, null, v, null) as IEnumerable;
                    var km = keys.GetEnumerator();
                    var vm = values.GetEnumerator();
                    km.Reset();
                    vm.Reset();
                    while (true)
                    {
                        if (!km.MoveNext() || !vm.MoveNext()) break;
                        var k = km.Current;
                        var n = vm.Current;
                        Console.WriteLine($"{k}:{n}");
                    }
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

        private static bool IsList(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
        }
        private static bool IsDictionary(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<,>);
        }
    }
}
