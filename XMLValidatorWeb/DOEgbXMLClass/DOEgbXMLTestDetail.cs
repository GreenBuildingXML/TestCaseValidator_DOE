using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOEgbXML
{
    public class DOEgbXMLTestDetail
    {
        public string testName;
        public string testSummary;
        public string passString;
        public string failString;
        public string shortTitle;
        public double thinWalledAltBuildingArea;
        public double thinWalledExpectedBuildingArea;
        public List<ThinWalledAlternatives> ThinWalledSpecs { get; set; }

        public DOEgbXMLTestDetail()
        {
            ThinWalledSpecs = new List<ThinWalledAlternatives>();
        }
        //holds a bunch of strings for a given test
        //this list will have this format:  TestShortTitle, Pass String, Fail String, Summary String
      //  public List<string> testString = new List<string>();

        //this List will store all the test Detail
        public List<DOEgbXMLTestDetail> TestDetailList;
        

        public void InitializeTestResultStrings()
        {
            //holds the Detail object for all the tests
            TestDetailList = new List<DOEgbXMLTestDetail>();

            //get the strings for the summary page table
            //initialize the testdetails for all the tests
            //DOEgbXMLTestDetail test1detail = new DOEgbXMLTestDetail();
            //DOEgbXMLTestDetail test2detail = new DOEgbXMLTestDetail();
            DOEgbXMLTestDetail test3detail = new DOEgbXMLTestDetail();
            //DOEgbXMLTestDetail test4detail = new DOEgbXMLTestDetail();
            //DOEgbXMLTestDetail test5detail = new DOEgbXMLTestDetail();
            DOEgbXMLTestDetail test6detail = new DOEgbXMLTestDetail();

            DOEgbXMLTestDetail test7detail = new DOEgbXMLTestDetail();
            DOEgbXMLTestDetail test8detail = new DOEgbXMLTestDetail();
            DOEgbXMLTestDetail test12detail = new DOEgbXMLTestDetail();

            //DOEgbXMLTestDetail test25detail = new DOEgbXMLTestDetail();
            //DOEgbXMLTestDetail test28detail = new DOEgbXMLTestDetail();

            DOEgbXMLTestDetail testwholeBuild1detail = new DOEgbXMLTestDetail();
            //DOEgbXMLTestDetail testwholeBuild2detail = new DOEgbXMLTestDetail();

            //create the strings
            //reach test.  TBD
            //Test1
            //test1detail.testName = "Test1";
            //test1detail.shortTitle = "2 Walls of Different Thicknesses with Parallel Aligned Faces";
            //test1detail.testSummary = "This test is designed to make sure that when walls of different thicknesses are joined with their faces aligned, that the centerline offset does not create extra walls during the gbXML creation process.  If these extra sliver walls are found in the gbXML file, this test will fail.";
            //test1detail.passString = "This test has passed.";
            //test1detail.failString = "This test has failed.";
            //ADD list to local testStrings List of Lists
            //TestDetailList.Add(test1detail);

            //reach test.  TBD
            //test 2
            //test2detail.testName = "Test2";
            //test2detail.shortTitle = "Single window with overhang that bisects the window's height.";
            //test2detail.testSummary = "A 1-zone, one story, simple model with exterior shading devices that act as overhangs and exterior light shelves for windows on the south façade.  Light shelves are 1” thick and split a single window instance in the BIM along its centerline.  This test is designed to ensure that this window should be represented as two windows in gbXML, the one window that is above the overhang, and the other that is below.";
            //test2detail.passString = "This test has passed.";
            //test2detail.failString = "This test has failed.";
            //ADD list to local testStrings List of Lists
            //TestDetailList.Add(test2detail);

            //test 3
            test3detail.testName = "Test3";
            test3detail.shortTitle = "Interior walls and Floor Second Level Space Boundary Test  ";
            test3detail.testSummary = "A 5-zone model with overlapping zones and a double-height zone.  This test is designed to ensure that the tool used to create the zones can properly follow the basic conventions for second level space boundaries.";
            test3detail.passString = "This test has passed.";
            test3detail.failString = "This test has failed.";
            test3detail.thinWalledAltBuildingArea = 6321.25;
            test3detail.thinWalledExpectedBuildingArea = 6500.00;
            ThinWalledAlternatives sp2 = new ThinWalledAlternatives("sp-2-Space",600,7800); //spacename in standard file, thin walled area (ft2), thin walled volume (ft3)
            test3detail.ThinWalledSpecs.Add(sp2);
            ThinWalledAlternatives sp3 = new ThinWalledAlternatives("sp-3-Space", 1400, 18200);
            test3detail.ThinWalledSpecs.Add(sp3);
            ThinWalledAlternatives sp4 = new ThinWalledAlternatives("sp-4-Space",2500,65000);
            test3detail.ThinWalledSpecs.Add(sp4);
            ThinWalledAlternatives sp5 = new ThinWalledAlternatives("sp-5-Space", 1400, 18200);
            test3detail.ThinWalledSpecs.Add(sp5);
            ThinWalledAlternatives sp6 = new ThinWalledAlternatives("sp-6-Space",600,7800);
            test3detail.ThinWalledSpecs.Add(sp6);
            //ADD list to local testStrings List of Lists
            TestDetailList.Add(test3detail);

            //reach test.  TBD
            //test 4 
            //test4detail.testName = "Test4";
            //test4detail.shortTitle = "Double height space with hole cut in floor and a skylight";
            //test4detail.testSummary = "This test is a large open atrium with a hole cut in the floor to allow light to penetrate through to the floor below.";
            //test4detail.passString = "This test has passed.";
            //test4detail.failString = "This test has failed.";
            //ADD list to local testStrings List of Lists
            //TestDetailList.Add(test4detail);

            //reach test.  TBD
            //test 5 
            //test5detail.testName = "Test5";
            //test5detail.shortTitle = "Basement walls that extend above grade and bound two different spaces";
            //test5detail.testSummary = "A two zone model that ensures exterior walls can properly be defined as underground and above grade.  A single wall has been drawn by the user that begins below grade, and terminates above grade.  Above grade, the walls bound a space that is above grade.  Below grade, the walls bound a space that is entirely below grade.";
            //test5detail.passString = "This test has passed.";
            //test5detail.failString = "This test has failed.";
            //ADD list to local testStrings List of Lists
            //TestDetailList.Add(test5detail);


            //Test 6
            test6detail.testName = "Test6";
            test6detail.shortTitle = "Simple box adjacency test.";
            test6detail.testSummary = "All above-grade zones, being tested to see if adjacency relationships are preserved.  Zones with surfaces touching one another should have these surfaces defined as \"Interior\" types and the correct adjacency conditions.";
            test6detail.passString = "This test has passed.";
            test6detail.failString = "This test has failed.";
            test6detail.thinWalledExpectedBuildingArea = 1160;
            test6detail.thinWalledAltBuildingArea = 1160;
            //ADD list to local testStrings List of Lists
            ThinWalledAlternatives sp_0_0_6 = new ThinWalledAlternatives("Space_0_0", 6027.79, 138433.493); //remember has to be in feet2 and feet3
            test6detail.ThinWalledSpecs.Add(sp_0_0_6);
            ThinWalledAlternatives sp_1_0_6 = new ThinWalledAlternatives("Space_1_0", 2152.78, 49440.533);
            test6detail.ThinWalledSpecs.Add(sp_1_0_6);
            ThinWalledAlternatives sp_2_0_6 = new ThinWalledAlternatives("Space_2_0", 2152.78, 49440.533);
            test6detail.ThinWalledSpecs.Add(sp_2_0_6);
            ThinWalledAlternatives sp_3_0_6 = new ThinWalledAlternatives("Space_3_0", 2152.78, 49440.533);
            test6detail.ThinWalledSpecs.Add(sp_3_0_6);
            TestDetailList.Add(test6detail);

            //test 7 
            test7detail.testName = "Test7";
            test7detail.shortTitle = "Folded roof element.";
            test7detail.testSummary = "This is the first in a proposed series of tests that focus on roof elements that grow in geometric complexity.";
            test7detail.passString = "This test has passed.";
            test7detail.failString = "This test has failed.";
            test7detail.thinWalledExpectedBuildingArea = 3200;
            test7detail.thinWalledAltBuildingArea = 3042;
            ThinWalledAlternatives sp1_7 = new ThinWalledAlternatives("sp-1-Space", 1600, 16000); //remember has to be in feet2 and feet3
            test7detail.ThinWalledSpecs.Add(sp1_7);
            ThinWalledAlternatives sp2_7 = new ThinWalledAlternatives("sp-2-Space", 1600, 22925.25); //remember has to be in feet2 and feet3
            test7detail.ThinWalledSpecs.Add(sp2_7);
            //ADD list to local testStrings List of Lists
            TestDetailList.Add(test7detail);

            //test 8 
            test8detail.testName = "Test8";
            test8detail.shortTitle = "Sloping slab on grade";
            test8detail.testSummary = "Ensures that sloping slab on grade comes through properly in gbXML, and that walls, which terminate at grade, are turned into the appropriate surfaceType (\"UndergroundWall\")";
            test8detail.passString = "This test has passed.";
            test8detail.failString = "This test has failed.";
            test8detail.thinWalledExpectedBuildingArea = 6029.88;
            test8detail.thinWalledAltBuildingArea = 5870.7183;
            //ADD list to local testStrings List of Lists
            ThinWalledAlternatives sp1_Aud_occ = new ThinWalledAlternatives("sp-1-Occupied_Auditorium", 6029.88, 90000); //enter expected thin walled values
            test8detail.ThinWalledSpecs.Add(sp1_Aud_occ);
            ThinWalledAlternatives sp2_Aud_unocc = new ThinWalledAlternatives("sp-2-Unoccupied_Auditorium",6000,120000);
            test8detail.ThinWalledSpecs.Add(sp2_Aud_unocc);
            ThinWalledAlternatives sp3_Roof = new ThinWalledAlternatives("sp-3-Roof_Void", 6000, 45000);
            test8detail.ThinWalledSpecs.Add(sp3_Roof);
            TestDetailList.Add(test8detail);

            //test 12
            test12detail.testName = "Test12";
            test12detail.shortTitle = "Simple box stacking test.";
            test12detail.testSummary = "All above-grade zones, being tested to see if adjacency relationships are preserved.  Zones with surfaces touching one another should have these surfaces defined as \"Interior\" types and the correct adjacency conditions.";
            test12detail.passString = "This test has passed.";
            test12detail.failString = "This test has failed.";
            test12detail.thinWalledExpectedBuildingArea = 16791.7003; //this is already a thin walled test case, so the two are the same
            test12detail.thinWalledAltBuildingArea = 16791.7003;
            //ADD list to local testStrings List of Lists
            ThinWalledAlternatives sp_0_0_12 = new ThinWalledAlternatives("Space_0_0", 6027.79, 138433.493); //remember has to be in feet2 and feet3
            test12detail.ThinWalledSpecs.Add(sp_0_0_12);
            ThinWalledAlternatives sp_1_0_12 = new ThinWalledAlternatives("Space_1_0", 2152.78, 49440.533);
            test12detail.ThinWalledSpecs.Add(sp_1_0_12);
            ThinWalledAlternatives sp_2_0_12 = new ThinWalledAlternatives("Space_2_0", 2152.78, 49440.533);
            test12detail.ThinWalledSpecs.Add(sp_2_0_12);
            ThinWalledAlternatives sp_3_0_12 = new ThinWalledAlternatives("Space_3_0", 2152.78, 49440.533);
            test12detail.ThinWalledSpecs.Add(sp_3_0_12);
            ThinWalledAlternatives sp_4_0_12 = new ThinWalledAlternatives("Space_4_0", 4305.564, 98881.0668);
            test12detail.ThinWalledSpecs.Add(sp_4_0_12);
            TestDetailList.Add(test12detail);

            //test whole building 1
            testwholeBuild1detail.testName = "Whole Building Test 1";
            testwholeBuild1detail.shortTitle = "Test for multi-floor building with ceiling return plenum.";
            testwholeBuild1detail.testSummary = "Ensures that the plenum horizontal surfaces are properly translated into interior surfaces, and have the proper adjacency conditions.";
            testwholeBuild1detail.passString = "This test has passed.";
            testwholeBuild1detail.failString = "This test has failed.";
            //ADD list to local testStrings List of Lists
            TestDetailList.Add(testwholeBuild1detail);

            //test whole building 2 
            //testwholeBuild2detail.testName = "Whole Building Test 2";
            //testwholeBuild2detail.shortTitle = "Test for plenums and multi-zone objects over basement.";
            //testwholeBuild2detail.testSummary = "Tests a simple building that is multiple stories and with plenums.  This is a very standard building, typical of DOE prototype buildings, e.g.  In addition to the features of Whole Building Test Case 1, this building also has underground surfaces.  Ensures that the plenum horizontal surfaces are properly translated into interior surfaces, and have the proper adjacency conditions.";
            //testwholeBuild2detail.passString = "This test has passed.";
            //testwholeBuild2detail.failString = "This test has failed.";
            //ADD list to local testStrings List of Lists
            //TestDetailList.Add(testwholeBuild2detail);

            ////test 25
            //test25detail.testName = "Test25";
            //test25detail.shortTitle = "Stacked interior walls with openings";
            //test25detail.testSummary = "A simplified 4-zone model of a building that has interior walls stacked on top of one another.  The interior walls each have openings cut into them, to simulate something that may be drawn as a hallway by a designer.";
            //test25detail.passString = "This test has passed.";
            //test25detail.failString = "This test has failed.";
            ////ADD list to local testStrings List of Lists
            //TestDetailList.Add(test25detail);

            ////test 28
            //test28detail.testName = "Test28";
            //test28detail.shortTitle = "Roof eaves are turned into shading devices automatically";
            //test28detail.testSummary = "A simplified 3-zone model of a building shaped like a residential home has been created.  The home is a simple two story example that has a small attic formed by a roof with a 30 degree pitch which slopes along one of the site’s Cartesian axes.  This test is a simple test that ensures the authoring tool is able to automatically break the roof into a space bounding object and shade object appropriately without any user intervention.";
            //test28detail.passString = "This test has passed.";
            //test28detail.failString = "This test has failed.";
            ////ADD list to local testStrings List of Lists
            //TestDetailList.Add(test28detail);


        }
    }

    public class ThinWalledAlternatives
    {
        public string SpaceName { get; set; }
        public double FloorArea { get; set; }
        public double Volume { get; set; }

        public ThinWalledAlternatives()
        {

        }

        public ThinWalledAlternatives(string name,double area,double vol)
        {
            SpaceName = name;
            FloorArea = area;
            Volume = vol;
        }
    }

}