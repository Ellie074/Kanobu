using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Program = KaNoBu.Program;
using Enum = KaNoBu.Enum;


namespace UnitTests;

public class GetUserChoiceTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetUserChoice_User_Input_Is_Incorrect()
    {
        //arrange
        string userInput= "";
        
        //act
        //assert
        Assert.Throws<Exception>(() => Program.GetUserChoice(userInput));
    }
    
    [Test]
    public void GetUserChoice_User_Input_Is_Correct()
    {
        //arrange
        string userInput= "0";
        
        //act
        Enum.Variants actual = Program.GetUserChoice(userInput);
        
        //assert
        Assert.AreEqual(Enum.Variants.Rock, actual);
    }
}