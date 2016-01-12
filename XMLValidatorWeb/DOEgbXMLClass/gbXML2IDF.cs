using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;

namespace XMLValidatorWeb.DOEgbXMLClass
{
    public class gbXML2IDF
    {
        public void gbXMLToIDF(string filelocation)
        {
            XmlDocument gbxf = new XmlDocument();
            
            //getXMLFile
            gbxf.Load(filelocation);
            XmlNamespaceManager gbxmlns = new XmlNamespaceManager(gbxf.NameTable);
            gbxmlns.AddNamespace("gbXMLv5", "http://www.gbxml.org/schema");
            
            //make zone file
            string zonestring = makeZones(gbxf, gbxmlns);

        }

        public string makeZones(XmlDocument gbxf,XmlNamespaceManager gbxmlns)
        {
            string zones = "";
            XmlNodeList nodes = gbxf.SelectNodes("/gbXMLv5:gbXML/gbXMLv5:Campus/gbXMLv5:Building/gbXMLv5:Space", gbxmlns);
            int nodecount = nodes.Count;
            foreach (XmlNode node in nodes)
            {
                
            }

            return zones;
        }
    }
}