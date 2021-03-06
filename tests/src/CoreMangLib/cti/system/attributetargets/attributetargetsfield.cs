using System;
/// <summary>
///Field
/// </summary>

public class AttributeTargetsField
{
    public static int Main()
    {
        AttributeTargetsField AttributeTargetsField = new AttributeTargetsField();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsField");
        if (AttributeTargetsField.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Field value is 0x0100. ");
        try
        {
            int expectValue = 0x0100;
            if ((int)AttributeTargets.Field != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Field should return 0x0100.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

