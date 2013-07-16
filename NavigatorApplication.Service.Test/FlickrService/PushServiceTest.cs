﻿namespace NavigatorApplication.Service.Test.FlickrService
{
    using Microsoft.Practices.Unity;

    using NavigatorApplication.Common.DI;
    using NavigatorApplication.Service.FlickrService;
    using NavigatorApplication.Service.Test.Helpers;

    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PushServiceTest
    {
        private IPushService pushService;
        
        [SetUp]
        public void Setup()
        {
            IoC.Container.RegisterType<IPushService, PushService>();

            pushService = IoC.Container.Resolve<IPushService>();
        }

        [Test]
        public void Can_Get_List_of_Topics()
        {
            var topics = pushService.PushGetTopics();
            foreach (var topic in topics)
            {
                Console.WriteLine(topic);
            }
        }

        [Test]
        public void Can_Subscribe_UnSubscribe()
        {
            var callback = "http://www.wackylabs.net/dev/push/test.php";
            var topic = "contacts_photos";
            var lease = 0;
            var verify = "sync";

            //TODO: Need to setup Authentication 
            //See: http://flickrnet.codeplex.com/SourceControl/latest#FlickrNetTest/PushTests.cs
            var f = FlickrHelpers.GetAuthInstance();
            
            f.PushSubscribe(topic, callback, verify, null, lease, null, null, 0, 0, 0, FlickrNet.RadiusUnit.None, FlickrNet.GeoAccuracy.None, null, null);

            Assert.Fail("TODO");
        }


        public void Test()
        {
            
        }





    }
}
