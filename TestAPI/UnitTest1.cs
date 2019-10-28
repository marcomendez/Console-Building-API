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
            rootCommand.AddChild(new Command("Add"));

            Assert.IsTrue(rootCommand.Run("git Add"));
            Assert.IsTrue(rootCommand.Run("git add"));
            Assert.IsTrue(rootCommand.Run("git AdD"));
            Assert.IsTrue(rootCommand.Run("git ADD"));
        }

        [TestMethod]
        public void Verify_RootCommandAndTwoCommand_Return_True_Test()
        {
            RootCommand rootCommand = new RootCommand("git");
            rootCommand.AddChild(new Command("Add"));
            rootCommand.AddChild(new Command("Clone"));

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
        public void Verify_Comand_As_ArrayString_Return_True()
        {
            RootCommand rootCommand = new RootCommand("git");
            rootCommand.AddChild(new Command("Add"));

            Assert.IsTrue(rootCommand.Run(new string[] { "git", "add" }));
            Assert.IsTrue(rootCommand.Run(new string[] { "git", "ADd" }));
            Assert.IsTrue(rootCommand.Run(new string[] { "git", "aDD" }));
            Assert.IsTrue(rootCommand.Run(new string[] { "GIT", "ADD" }));
        }

        [TestMethod]
        public void Verify_CommandIsNotCorrect_Return_False_Test()
        {
            RootCommand rootCommand = new RootCommand("it");
            rootCommand.AddChild(new Command("add"));

            Assert.IsFalse(rootCommand.Run("git Adde"));
            Assert.IsFalse(rootCommand.Run("git adde"));
            Assert.IsFalse(rootCommand.Run("git AdDe"));
            Assert.IsFalse(rootCommand.Run("git ADDe"));
        }
    }
}
