﻿using System.IO;
using Beast.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Beast.Data.FileSystem.Tests
{
    /// <summary>
    ///This is a test class for FileRepositoryTest and is intended
    ///to contain all FileRepositoryTest Unit Tests
    ///</summary>
	[TestClass()]
	public class FileRepositoryTest : RepositoryTestBase
	{
		[ClassInitialize()]
		public static void InitTest(TestContext context)
		{
			Init(context);

			var repo = new FileRepository
			             	{
			             		DirectoryPath = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName
			             	};
			repo.Initialize();

			Users = repo;
			Templates = repo;
			Places = repo;
			Characters = repo;
		}

		[TestMethod()]
		public void SaveUserTest()
		{
			BaseSaveUserTest();
		}

		[TestMethod()]
		public void GetUserCountTest()
		{
			BaseGetUserCountTest();
		}

		[TestMethod()]
		public void GetUserTest()
		{
			BaseGetUserTest();
		}

		[TestMethod]
		public void SaveTemplateTest()
		{
			BaseSaveTemplateTest();
		}

		[TestMethod]
		public void GetTemplateTest()
		{
			BaseGetTemplateTest();
		}

		[TestMethod]
		public void GetPlaceTest()
		{
			BaseGetPlaceTest();
		}

		[TestMethod]
		public void SavePlaceTest()
		{
			BaseSavePlaceTest();
		}

		[TestMethod]
		public void GetCharacterTest()
		{
			BaseGetCharacterTest();
		}

		[TestMethod]
		public void SaveCharacterTest()
		{
			BaseSaveCharacterTest();
		}
	}
}
