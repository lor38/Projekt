namespace Auf7.Test
{
    public class EmployeeTest
    {
        
        [Test]
        public void WhenGetsStatisticsCalled_ShouldReturnCorrectMax()
        {
            var employee = new Employee("Rafael", "Lorenc");

            employee.AddGrade(2);
            employee.AddGrade(8);
            employee.AddGrade(6);


            var statistics = employee.GetStatistics();


            Assert.AreEqual(8, statistics.Max);
        }

        [Test]
        public void WhenGetsStatisticsCalled_ShouldReturnCorrectMin()
        {
            var employee = new Employee("Rafael", "Lorenc");

            employee.AddGrade(2);
            employee.AddGrade(8);
            employee.AddGrade(6);


            var statistics = employee.GetStatistics();


            Assert.AreEqual(2, statistics.Min);
        }


        [Test]
        public void WhenGetsStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Rafael", "Lorenc");

            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(3);


            var statistics = employee.GetStatistics();


            Assert.AreEqual(3, 6, statistics.Average);
        }

    }
}