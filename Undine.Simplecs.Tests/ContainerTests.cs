﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Undine.Core;
using Undine.Simplecs.Tests.Components;

namespace Undine.Simplecs.Tests
{
    [TestClass]
    public class ContainerTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void EntityCanBeCreated()
        {
            var container = new SimplecsContainer();
            var entity = container.CreateNewEntity();
            Assert.IsNotNull(entity);
        }

        [TestMethod]
        public void OneTypeSystemCanBeAdded()
        {
            var container = new SimplecsContainer();
            var mock = new Mock<UnifiedSystem<AComponent>>();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void TwoTypeSystemCanBeAdded()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent>>();
            var container = new SimplecsContainer();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void ThreeTypeSystemCanBeAdded()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent>>();
            var container = new SimplecsContainer();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void FourTypeSystemCanBeAdded()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent, DComponent>>();
            var container = new SimplecsContainer();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void OneTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent>>();
            var container = new SimplecsContainer();
            container.GetSystem(mock.Object);
        }

        [TestMethod]
        public void TwoTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent>>();
            var container = new SimplecsContainer();
            container.GetSystem(mock.Object);
        }

        [TestMethod]
        public void ThreeTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent>>();
            var container = new SimplecsContainer();
            container.GetSystem(mock.Object);
        }

        [TestMethod]
        public void FourTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent, DComponent>>();
            var container = new SimplecsContainer();
            container.GetSystem(mock.Object);
        }
    }
}