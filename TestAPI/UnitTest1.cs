using Microsoft.VisualStudio.TestTools.UnitTesting;

using Commands;
using Root;

namespace TestAPI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Verify_RootCommandAndOneCommand_Return_True_Test()
        {
            RootCommand rootCommand = new RootCommand("git");
            rootCommand.AddCommand(new Command("Add"));

            Assert.IsTrue(rootCommand.Run("git Add"));
            Assert.IsTrue(rootCommand.Run("git add"));
            Assert.IsTrue(rootCommand.Run("git AdD"));
            Assert.IsTrue(rootCommand.Run("git ADD"));
        }

        [TestMethod]
        public void Verify_RootCommandAndTwoCommand_Return_True_Test()
        {
            RootCommand rootCommand = new RootCommand("git");
            rootCommand.AddCommand(new Command("Add"));
            rootCommand.AddCommand(new Command("Clone"));

            Assert.IsTrue(rootCommand.Run("git Add"));
            Assert.IsTrue(rootCommand.Run("git add"));
            Assert.IsTrue(rootCommand.Run("git AdD"));
            Assert.IsTrue(rootCommand.Run("git ADD"));

            Assert.IsTrue(rootCommand.Run("git Clone"));
            Assert.IsTrue(rootCommand.Run("git clone"));
            Assert.IsTrue(rootCommand.Run("git CloNe"));
            Assert.IsTrue(rootCommand.Run("git CLONE"));
        }

        [TestMethod]
        public void Verify_RootCommandAndTwoCommandIsCorrectCommand_Return_True_Test()
        {
            RootCommand rootCommand = new RootCommand("git");
            rootCommand.AddCommand(new Command("Add"));
            rootCommand.AddCommand(new Command("CLone"));

            Assert.IsTrue(rootCommand.Run("git Add Clone"));
            Assert.IsTrue(rootCommand.Run("git add clone"));
            Assert.IsTrue(rootCommand.Run("git AdD CloNe"));
            Assert.IsTrue(rootCommand.Run("git ADD CLONE"));
        }

        [TestMethod]
        public void Verify_CommandIsNotCorrect_Return_False_Test()
        {
            RootCommand rootCommand = new RootCommand("git");
            rootCommand.AddCommand(new Command("add"));

            Assert.IsFalse(rootCommand.Run("git Adde"));
            Assert.IsFalse(rootCommand.Run("git adde"));
            Assert.IsFalse(rootCommand.Run("git AdDe"));
            Assert.IsFalse(rootCommand.Run("git ADDe"));
        }
    }
}
