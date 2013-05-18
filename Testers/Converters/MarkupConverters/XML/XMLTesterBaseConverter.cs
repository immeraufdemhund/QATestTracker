namespace Testers
{
    internal class XMLTesterBaseConverter : TesterConverter
    {
        public XMLTesterBaseConverter(TesterBase test)
        {
            this.tester = test;
        }
        public override string GetAddStatement()
        {
            var xml = new System.Xml.Linq.XElement("TesterBase",
                new System.Xml.Linq.XElement("TesterId", tester.TesterId),
                new System.Xml.Linq.XElement("Name", tester.Name),
                new System.Xml.Linq.XElement("PrivilegeLevel", tester.PrivilegeLevel));

            return xml.ToString();
        }

        public override string GetUpdateStatement()
        {
            throw new System.NotImplementedException();
        }

        public override string GetDeleteStatement()
        {
            throw new System.NotImplementedException();
        }

        public override void Extract()
        {
            throw new System.NotImplementedException();
        }

        private TesterBase tester;
    }
}
