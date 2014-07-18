﻿namespace ToolboxTest
{
    using System.Drawing;
    using System.IO;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Sandbox.Common.ObjectBuilders;
    using Sandbox.Common.ObjectBuilders.Definitions;
    using SEToolbox.ImageLibrary;
    using SEToolbox.Interop;
    using SEToolbox.Support;
    using TexUtil = SEToolbox.ImageLibrary.ImageTextureUtil;

    [TestClass]
    public class TextureTests
    {
        [TestMethod]
        public void LoadComponentTextures()
        {
            var location = ToolboxUpdater.GetApplicationFilePath();
            Assert.IsNotNull(location, "Space Engineers should be installed on developer machine");
            Assert.IsTrue(Directory.Exists(location), "Filepath should exist on developer machine");

            var contentPath = ToolboxUpdater.GetApplicationContentPath();

            var magnesiumOre = SpaceEngineersAPI.GetDefinition(SpaceEngineersConsts.Ore, "Magnesium");
            var magnesiumOrePath = Path.Combine(contentPath, magnesiumOre.Icon + ".dds");
            Assert.IsTrue(File.Exists(magnesiumOrePath), "Filepath should exist on developer machine");
            Assert.IsTrue(magnesiumOre is MyObjectBuilder_PhysicalItemDefinition, "Type should match");
            var magnesiumOreBmp = TexUtil.CreateBitmap(magnesiumOrePath);
            ImageTextureUtil.WriteImage(magnesiumOreBmp, @".\TestOutput\Magnesium_Ore.png");

            var goldIngot = SpaceEngineersAPI.GetDefinition(SpaceEngineersConsts.Ingot, "Gold");
            var goldIngotPath = Path.Combine(contentPath, goldIngot.Icon + ".dds");
            Assert.IsTrue(File.Exists(goldIngotPath), "Filepath should exist on developer machine");
            Assert.IsTrue(goldIngot is MyObjectBuilder_PhysicalItemDefinition, "Type should match");
            var goldIngotBmp = TexUtil.CreateBitmap(goldIngotPath);
            ImageTextureUtil.WriteImage(goldIngotBmp, @".\TestOutput\Gold_Ingot.png");

            var ammoMagazine = SpaceEngineersAPI.GetDefinition(SpaceEngineersConsts.AmmoMagazine, "NATO_5p56x45mm");
            var ammoMagazinePath = Path.Combine(contentPath, ammoMagazine.Icon + ".dds");
            Assert.IsTrue(File.Exists(ammoMagazinePath), "Filepath should exist on developer machine");
            Assert.IsTrue(ammoMagazine is MyObjectBuilder_AmmoMagazineDefinition, "Type should match");
            var ammoMagazineBmp = TexUtil.CreateBitmap(ammoMagazinePath);
            ImageTextureUtil.WriteImage(ammoMagazineBmp, @".\TestOutput\NATO_5p56x45mm.png");

            var steelPlate = SpaceEngineersAPI.GetDefinition(SpaceEngineersConsts.Component, "SteelPlate");
            var steelPlatePath = Path.Combine(contentPath, steelPlate.Icon + ".dds");
            Assert.IsTrue(File.Exists(steelPlatePath), "Filepath should exist on developer machine");
            Assert.IsTrue(steelPlate is MyObjectBuilder_ComponentDefinition, "Type should match");
            var steelPlateBmp = TexUtil.CreateBitmap(steelPlatePath);
            ImageTextureUtil.WriteImage(steelPlateBmp, @".\TestOutput\SteelPlate.png");

            var smallBlockLandingGear = SpaceEngineersAPI.GetDefinition(new MyObjectBuilderType(typeof(MyObjectBuilder_LandingGear)), "SmallBlockLandingGear");
            var smallBlockLandingGearPath = Path.Combine(contentPath, smallBlockLandingGear.Icon + ".dds");
            Assert.IsTrue(File.Exists(smallBlockLandingGearPath), "Filepath should exist on developer machine");
            Assert.IsTrue(smallBlockLandingGear is MyObjectBuilder_CubeBlockDefinition, "Type should match");
            var smallBlockLandingGearBmp = TexUtil.CreateBitmap(smallBlockLandingGearPath);
            ImageTextureUtil.WriteImage(smallBlockLandingGearBmp, @".\TestOutput\SmallBlockLandingGear.png");

            var gridItemPath = Path.Combine(contentPath, @"Textures\GUI\Controls\grid_item.dds");
            Assert.IsTrue(File.Exists(gridItemPath), "Filepath should exist on developer machine");
            var gridBmp = TexUtil.CreateBitmap(gridItemPath);
            ImageTextureUtil.WriteImage(gridBmp, @".\TestOutput\grid_item.png");

            var sunPath = Path.Combine(contentPath, @"Textures\BackgroundCube\Prerender\Sun.dds");
            Assert.IsTrue(File.Exists(sunPath), "Filepath should exist on developer machine");
            var sunBmp = TexUtil.CreateBitmap(sunPath);
            ImageTextureUtil.WriteImage(sunBmp, @".\TestOutput\sun.png");

            var goldPath = Path.Combine(contentPath, @"Textures\Voxels\Gold_01_ForAxisXZ_de.dds");
            Assert.IsTrue(File.Exists(goldPath), "Filepath should exist on developer machine");
            var goldBmp = TexUtil.CreateBitmap(goldPath);
            ImageTextureUtil.WriteImage(goldBmp, @".\TestOutput\gold.png");

            var siliconPath = Path.Combine(contentPath, @"Textures\Voxels\Silicon_01_ForAxisXZ_de.dds");
            Assert.IsTrue(File.Exists(siliconPath), "Filepath should exist on developer machine");
            var siliconBmp = TexUtil.CreateBitmap(siliconPath);
            ImageTextureUtil.WriteImage(siliconBmp, @".\TestOutput\silicon.png");

            var platinumPath = Path.Combine(contentPath, @"Textures\Voxels\Platinum_01_ForAxisXZ_de.dds");
            Assert.IsTrue(File.Exists(platinumPath), "Filepath should exist on developer machine");
            var platinumBmp = TexUtil.CreateBitmap(platinumPath);
            ImageTextureUtil.WriteImage(platinumBmp, @".\TestOutput\platinum.png");
        }

        [TestMethod]
        public void CreateMenuTextures()
        {
            var location = ToolboxUpdater.GetApplicationFilePath();
            Assert.IsNotNull(location, "Space Engineers should be installed on developer machine");
            Assert.IsTrue(Directory.Exists(location), "Filepath should exist on developer machine");

            var contentPath = ToolboxUpdater.GetApplicationContentPath();

            var smallBlockLandingGear = SpaceEngineersAPI.GetDefinition(new MyObjectBuilderType(typeof(MyObjectBuilder_LandingGear)), "SmallBlockLandingGear");
            var smallBlockLandingGearPath = Path.Combine(contentPath, smallBlockLandingGear.Icon + ".dds");
            Assert.IsTrue(File.Exists(smallBlockLandingGearPath), "Filepath should exist on developer machine");
            Assert.IsTrue(smallBlockLandingGear is MyObjectBuilder_CubeBlockDefinition, "Type should match");
            var smallBlockLandingGearBmp = TexUtil.CreateBitmap(smallBlockLandingGearPath);

            var gridItemPath = Path.Combine(contentPath, @"Textures\GUI\Controls\grid_item.dds");
            Assert.IsTrue(File.Exists(gridItemPath), "Filepath should exist on developer machine");
            var gridBmp = TexUtil.CreateBitmap(gridItemPath);

            var bmp = ImageTextureUtil.MergeImages(gridBmp, smallBlockLandingGearBmp, Brushes.Black);
            ImageTextureUtil.WriteImage(bmp, @".\TestOutput\Menu_SmallBlockLandingGear.png");
        }

        [TestMethod]
        public void ReadBackgroundTextures()
        {
            var location = ToolboxUpdater.GetApplicationFilePath();
            Assert.IsNotNull(location, "Space Engineers should be installed on developer machine");
            Assert.IsTrue(Directory.Exists(location), "Filepath should exist on developer machine");

            var contentPath = ToolboxUpdater.GetApplicationContentPath();

            var backgroundPath = Path.Combine(contentPath, @"Textures\BackgroundCube\Final\BackgroundCube.dds");
            Assert.IsTrue(File.Exists(backgroundPath), "Filepath should exist on developer machine");

            var backgroundBmp = TexUtil.CreateBitmap(backgroundPath, 0, -1, -1 );
            ImageTextureUtil.WriteImage(backgroundBmp, @".\TestOutput\BackgroundCube0_Full.png");

            backgroundBmp = TexUtil.CreateBitmap(backgroundPath, 1, 1024, 1024);
            ImageTextureUtil.WriteImage(backgroundBmp, @".\TestOutput\BackgroundCube1_1024.png");

            backgroundBmp = TexUtil.CreateBitmap(backgroundPath, 2, 512, 512);
            ImageTextureUtil.WriteImage(backgroundBmp, @".\TestOutput\BackgroundCube2_512.png");

            backgroundBmp = TexUtil.CreateBitmap(backgroundPath, 3, 128, 128);
            ImageTextureUtil.WriteImage(backgroundBmp, @".\TestOutput\BackgroundCube3_128.png");

            backgroundBmp = TexUtil.CreateBitmap(backgroundPath, 4, 64, 64);
            ImageTextureUtil.WriteImage(backgroundBmp, @".\TestOutput\BackgroundCube4_64.png");

            backgroundBmp = TexUtil.CreateBitmap(backgroundPath, 5, 32, 32);
            ImageTextureUtil.WriteImage(backgroundBmp, @".\TestOutput\BackgroundCube5_32.png");
        }

        [TestMethod]
        public void CreateBackgroundPreview()
        {
            const int size = 128;
            const bool ignoreAlpha = true;

            var location = ToolboxUpdater.GetApplicationFilePath();
            Assert.IsNotNull(location, "Space Engineers should be installed on developer machine");
            Assert.IsTrue(Directory.Exists(location), "Filepath should exist on developer machine");

            var contentPath = ToolboxUpdater.GetApplicationContentPath();

            var backgroundPath = Path.Combine(contentPath, @"Textures\BackgroundCube\Final\BackgroundCube.dds");
            Assert.IsTrue(File.Exists(backgroundPath), "Filepath should exist on developer machine");

            var result = new Bitmap(size * 4, size * 3);

            using (var graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                if (ignoreAlpha)
                {
                    graphics.FillRectangle(Brushes.Black, size * 2, size * 1, size, size);
                    graphics.FillRectangle(Brushes.Black, size * 0, size * 1, size, size);
                    graphics.FillRectangle(Brushes.Black, size * 1, size * 0, size, size);
                    graphics.FillRectangle(Brushes.Black, size * 1, size * 2, size, size);
                    graphics.FillRectangle(Brushes.Black, size * 1, size * 1, size, size);
                    graphics.FillRectangle(Brushes.Black, size * 3, size * 1, size, size);
                }

                graphics.DrawImage(TexUtil.CreateBitmap(backgroundPath, 0, size, size, ignoreAlpha), size * 2, size * 1, size, size);
                graphics.DrawImage(TexUtil.CreateBitmap(backgroundPath, 1, size, size, ignoreAlpha), size * 0, size * 1, size, size);
                graphics.DrawImage(TexUtil.CreateBitmap(backgroundPath, 2, size, size, ignoreAlpha), size * 1, size * 0, size, size);
                graphics.DrawImage(TexUtil.CreateBitmap(backgroundPath, 3, size, size, ignoreAlpha), size * 1, size * 2, size, size);
                graphics.DrawImage(TexUtil.CreateBitmap(backgroundPath, 4, size, size, ignoreAlpha), size * 1, size * 1, size, size);
                graphics.DrawImage(TexUtil.CreateBitmap(backgroundPath, 5, size, size, ignoreAlpha), size * 3, size * 1, size, size);

                // Approximate position of local Sun and light source.
                graphics.FillEllipse(Brushes.White, size * 1 + (int)(size * 0.7), size * 2 + (int)(size * 0.93), (int)(size * 0.06), (int)(size * 0.06));
            }

            ImageTextureUtil.WriteImage(result, string.Format(@".\TestOutput\BackgroundCube_{0}.png", size));
        }
    }
}
