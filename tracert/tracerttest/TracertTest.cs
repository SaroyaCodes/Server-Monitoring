﻿// The following code was generated by Microsoft Visual Studio 2005.
// The test owner should check each test for validity.
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Collections.Generic;
using VRK.Net;
using System.Threading;
using System.Net.NetworkInformation;
namespace tracerttest
{
	/// <summary>
	///This is a test class for VRK.Net.Tracert and is intended
	///to contain all VRK.Net.Tracert Unit Tests
	///</summary>
	[TestClass()]
	public class TracertTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}
		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for Trace ()
		///</summary>
		[TestMethod()]
		public void TraceTest()
		{
			using (Tracert target = new Tracert())
			using(AutoResetEvent doneEvent = new AutoResetEvent(false))
			{
				target.HostNameOrAddress = "www.codeproject.com";
				target.Trace();
				int nodeCount = 0;

				target.RouteNodeFound += delegate
				{
					nodeCount++;	
				};

				target.Done += delegate
				{
					doneEvent.Set();
				};

				doneEvent.WaitOne();

				Assert.AreEqual(nodeCount, target.Nodes.Length, "The number of times the RouteNodeFound event is fired should be same as the length of the Nodes list");
				Assert.IsTrue(target.Nodes.Length > 2, "There should be atleast three points on the route");
				Assert.IsTrue(target.IsDone, "The IsDone property is not set properly.");
			}
		}

		/// <summary>
		/// RoundTripTime test
		///</summary>
		[TestMethod()]
		public void RoundTripTimeTest()
		{
			using (Tracert target = new Tracert())
			using (AutoResetEvent doneEvent = new AutoResetEvent(false))
			{
				target.HostNameOrAddress = "www.codeproject.com";
				target.Trace();
				int nodeCount = 0;
				int roundTripMoreThanZero = 0;

				target.RouteNodeFound += delegate(object sender, RouteNodeFoundEventArgs e)
				{
					nodeCount++;

					if (e.Node.RoundTripTime > 0) roundTripMoreThanZero++;
					System.Diagnostics.Trace.WriteLine(e.Node.RoundTripTime);
				};

				target.Done += delegate
				{
					doneEvent.Set();
				};

				doneEvent.WaitOne();


				Assert.IsTrue(roundTripMoreThanZero >= 2, "The round trip time is zero at least 2 times.");
			}
		}
		
		[
			TestMethod,
			ExpectedException(typeof(ArgumentNullException), "An exception of type PingException should have occured")
		]
		public void InvalidDataTest()
		{
			using (Tracert target = new Tracert())
			{
				target.Trace();
			}
		}

		[TestMethod]
		public void TimeoutTest()
		{
			using (Tracert target = new Tracert())
			using (AutoResetEvent doneEvent = new AutoResetEvent(false))
			{
				target.HostNameOrAddress = "www.codeproject.com";
				target.TimeOut = 10;
				target.Trace();
				int nodeCount = 0;

				IPStatus status = IPStatus.Unknown;

				target.RouteNodeFound += delegate(object sender, RouteNodeFoundEventArgs e)
				{
					nodeCount++;
					status = IPStatus.TimedOut;
				};

				target.Done += delegate
				{
					doneEvent.Set();
				};

				doneEvent.WaitOne();

				Assert.AreEqual(status, IPStatus.TimedOut);
				Assert.AreEqual(nodeCount, target.Nodes.Length, "The number of times the RouteNodeFound event is fired should be same as the length of the Nodes list");
				Assert.IsTrue(target.Nodes.Length > 2, "There should be atleast three points on the route");
				Assert.IsTrue(target.IsDone, "The IsDone property is not set properly.");
			}			
		}


		[TestMethod]
		public void LocalTest()
		{
			using (Tracert target = new Tracert())
			using (AutoResetEvent doneEvent = new AutoResetEvent(false))
			{
				target.HostNameOrAddress = "127.0.0.1";
				target.Trace();
				int nodeCount = 0;

				target.RouteNodeFound += delegate
				{
					nodeCount++;
				};

				target.Done += delegate
				{
					doneEvent.Set();
				};

				doneEvent.WaitOne();

				Assert.AreEqual(nodeCount, target.Nodes.Length, "The number of times the RouteNodeFound event is fired should be same as the length of the Nodes list");
				Assert.IsTrue(target.Nodes.Length > 2, "There should be atleast three points on the route");
				Assert.IsTrue(target.IsDone, "The IsDone property is not set properly.");
			}
		}

		[TestMethod]
		public void DisposeTest()
		{
			using (AutoResetEvent doneEvent = new AutoResetEvent(false))
			using (ManualResetEvent nodeFoundEvent = new ManualResetEvent(false))
			{
				Tracert target = new Tracert();
				target.HostNameOrAddress = "www.codeproject.com";
				bool firstTime = true;

				target.RouteNodeFound += delegate
				{
					//Since it is a manual reset event it will be set only once
					if (firstTime)
					{
						nodeFoundEvent.WaitOne();
						firstTime = false;
					}
				};

				target.Done += delegate
				{
					doneEvent.Set();
				};

				target.Trace();
				target.Dispose();
				nodeFoundEvent.Set();
				doneEvent.WaitOne();

				Assert.IsTrue(target.IsDone, "The IsDone property is not set properly.");
				Assert.AreEqual(target.Nodes.Length, 2, "There should be exactly two nodes the first and the destination");
			}
		}
	}
}
