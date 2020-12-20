using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SQLTestDataGenerator
{
    class XmlReader
    {
        public List<string> _first_name { get; set; }
        public List<string> _last_name { get; set; }
        public List<string> _middle_name { get; set; }
        public List<string> _suffix { get; set; }
        public List<string> _prefix { get; set; }

        public XmlReader()
        {
            _first_name = new List<string>();
            _middle_name = new List<string>();
            _last_name = new List<string>();
            _suffix = new List<string>();
            _prefix = new List<string>();
            ReadName();
        }
        public void ReadName()
        {
            var doc = XDocument.Load(@"Statics\Name.xml");
            XElement root = doc.Root;
            //load first name
            var query= root.Elements("firstname");
            foreach(var q in query)
            {
                foreach(var e in q.Elements("value"))
                {
                    _first_name.Add(e.Value);

                }
            }
            //load middle name
            query = root.Elements("middlename");
            foreach (var q in query)
            {
                foreach (var e in q.Elements("value"))
                {
                    _middle_name.Add(e.Value);

                }
            }
            //load last name
            query = root.Elements("lastname");
            foreach (var q in query)
            {
                foreach (var e in q.Elements("value"))
                {
                    _last_name.Add(e.Value);

                }
            }
            //load prefix
            query = root.Elements("prefix");
            foreach (var q in query)
            {
                foreach (var e in q.Elements("value"))
                {
                    _prefix.Add(e.Value);

                }
            }

        }

    }
}
