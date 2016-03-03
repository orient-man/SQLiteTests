using System.Data.SQLite;
using NUnit.Framework;

namespace SqliteTests
{
    [TestFixture]
    public class SqliteTests
    {
        [Test]
        public void ShouldDoTheRightThing()
        {
            // arrange
            var conn = new SQLiteConnection("Data Source=:memory:;Version=3;New=True;");


            // act
            // assert
        }
    }
}