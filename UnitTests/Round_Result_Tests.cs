using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Program = KaNoBu.Program;
using Enum = KaNoBu.Enum;


namespace UnitTests;

public class RoundResultTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void RoundResult_Draft()
    {
        //arrange
        //act
        Enum.Result actual = Program.RoundResult(Enum.Variants.Rock, Enum.Variants.Rock);
        
        //assert
        Assert.AreEqual(Enum.Result.Draft, actual);
    }
    
    [Test]
    public void RoundResult_User_Win()
    {
        //arrange
        //act
        Enum.Result actual = Program.RoundResult(Enum.Variants.Scissors, Enum.Variants.Rock);
        
        //assert
        Assert.AreEqual(Enum.Result.Win, actual);
    }

    [Test]
    public void RoundResult_User_Lose()
    {
        //arrange
        //act
        Enum.Result actual = Program.RoundResult(Enum.Variants.Scissors, Enum.Variants.Paper);
        
        //assert 
        Assert.AreEqual(Enum.Result.Lose, actual);
    }
}