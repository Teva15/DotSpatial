using System.Collections.Generic;

using NUnit.Framework;

namespace DotSpatial.Projections.Tests.Projected.NationalGrids
{
    /// <summary>
    /// This class contains all the tests for the Asia category of Projected coordinate systems
    /// </summary>
    [TestFixture]
    public class Asia
    {
        [Test]
        [TestCaseSource(nameof(GetProjections))]
        public void AsiaProjectedTests(ProjectionInfoDesc pInfo)
        {
            Tester.TestProjection(pInfo.ProjectionInfo);
            Assert.AreEqual(false, pInfo.ProjectionInfo.IsLatLon);
        }

        private static IEnumerable<ProjectionInfoDesc> GetProjections()
        {
            return ProjectionInfoDesc.GetForCoordinateSystemCategory(KnownCoordinateSystems.Projected.NationalGrids.Asia);
        }
    }
}