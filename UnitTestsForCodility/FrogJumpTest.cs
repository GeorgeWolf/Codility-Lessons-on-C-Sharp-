﻿using System;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class FrogJumpTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void NumberOutOfRangeTest()
		{
			int catchException = 0;
			try
			{
				FrogJump.solution(int.MaxValue, 5, 5);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException++;
			}

			try
			{
				FrogJump.solution(5, int.MaxValue, 5);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException++;
			}

			try
			{
			FrogJump.solution(5, 5, int.MaxValue);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException++;
			}

			
			try
			{
			FrogJump.solution(0, 5, 5);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException++;
			}
			try
			{
			FrogJump.solution(5, 0, 5);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException++;
			}
			try
			{
			FrogJump.solution(0, 0, 0);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException++;
			}
			try
			{
				FrogJump.solution(5, 5, 0);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException++;
			}
			
			if (catchException==7)
				Assert.Pass();
			else
				Assert.Fail();
		}

		[Test]
		public void XSmallerThenYTest()
		{
			bool catchException = false;
			try
			{
				FrogJump.solution(15, 4, 5);	

			}
			catch (ArgumentException)
			{
				catchException = true;
			}

			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();

		}

		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(3, FrogJump.solution(10,85,30));
		}
		// exactly on the position  X=20,Y=50,D=15;should return 2
		// with start positon 0     X=0, Y=255,D=2; should return128
		// One Jump                 X=30, y=60,D=80; should return 1
		[Test]
		public void ExactlyOnPostionTest()
		{
			Assert.AreEqual(2, FrogJump.solution(20,50,15));
		}

		[Test]
		public void WitheZeroStartTest()
		{
			Assert.AreEqual(128, FrogJump.solution(1,256,2));
		}

		[Test]
		public void OneJumpTest()
		{
			Assert.AreEqual(1, FrogJump.solution(30,60,80));
		}

		[Test]
		public void ZeroJumpTest()
		{
			Assert.AreEqual(0, FrogJump.solution(30,30,10));
		}
		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}
	}
} 